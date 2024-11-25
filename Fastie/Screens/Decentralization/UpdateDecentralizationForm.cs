using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.DecentralizationBLL;
using BLL.ListRoleBLL;
using DTO;
using DTO.ListRoleDTO;
using Fastie.Components.LayoutDecentralization;
using Fastie.Components.Toastify;
using Fastie.Screens.Decentralization;

namespace Fastie
{
    public partial class UpdateDecentralizationForm : Form
    {

        private DecentralizationBLL decentralizationBLL = new DecentralizationBLL();
        private Dictionary<string, CheckBox> permissionCheckboxMap;
        private string accountName;

        private LayoutDecentralizationForm layoutdecentralizationForm;
        private DecentralizationForm decentralizationForm;
        public delegate void FormClosingHandler();
        public event FormClosingHandler OnFormClosing;
        ListRoleBLL listRoleBLL = new ListRoleBLL();

        public UpdateDecentralizationForm(LayoutDecentralizationForm layoutdecentralizationForm,DecentralizationForm decentralizationForm) //replace by DecentralizationForm decentralizationForm ,string accountName
        {
            InitializeComponent();
            InitializePermissionCheckboxMap();
            this.accountName = layoutdecentralizationForm.AccountName;
            this.decentralizationForm = decentralizationForm;
            this.layoutdecentralizationForm = layoutdecentralizationForm;
        }

        private void checkboxPersonnelManagement_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxPersonnelManagement.Checked)
            {
                checkboxAddPersonnel.Checked = true;
                checkboxUpdatePersonnel.Checked = true;
                checkboxDeletePersonnel.Checked = true;
            } else
            {
                checkboxAddPersonnel.Checked = false;
                checkboxUpdatePersonnel.Checked = false;
                checkboxDeletePersonnel.Checked = false;
            }   
        }

        private void checkboxPartManagement_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxPartManagement.Checked)
            {
                checkboxAddPart.Checked = true;
                checkboxUpdatePart.Checked = true;
                checkboxDeletePart.Checked = true;
            } else
            {
                checkboxAddPart.Checked = false;
                checkboxUpdatePart.Checked = false;
                checkboxDeletePart.Checked = false;
            }
        }

        private void checkboxPositionManagement_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxPositionManagement.Checked)
            {
                checkboxAddPosition.Checked = true;
                checkboxUpdatePosition.Checked = true;
                checkboxDeletePosition.Checked = true;
            } else
            {
                checkboxAddPosition.Checked = false;
                checkboxUpdatePosition.Checked = false;
                checkboxDeletePosition.Checked = false;
            }
        }

        private void checkboxAccountManagement_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxAccountManagement.Checked)
            {
                checkboxAddAccount.Checked = true;
                checkboxUpdateAccount.Checked = true;
                checkboxDeleteAccount.Checked = true;
            } else
            {
                checkboxAddAccount.Checked = false;
                checkboxUpdateAccount.Checked = false;
                checkboxDeleteAccount.Checked = false;
            }
        }

        private void checkboxTasksManagement_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxTasksManagement.Checked)
            {
                checkboxSendNotification.Checked = true;
                checkboxAssignTasks.Checked = true;
                checkboxDeleteTasks.Checked = true;
                checkboxUpdateTasks.Checked = true;
                checkBoxGetTasks.Checked = true;
                checkBoxReportTasks.Checked = true;

            } else
            {
                checkboxSendNotification.Checked = false;
                checkboxAssignTasks.Checked = false;
                checkboxDeleteTasks.Checked = false;
                checkboxUpdateTasks.Checked = false;
                checkBoxGetTasks.Checked = false;
                checkBoxReportTasks.Checked = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnFormClosing?.Invoke();
            this.Close();   
        }

        private void CreateDecentralizationForm_Load(object sender, EventArgs e)
        {
            CheckPermissions();
            this.AcceptButton = btnAdd;
        }

        private void InitializePermissionCheckboxMap()
        {
            permissionCheckboxMap = new Dictionary<string, CheckBox>
            {
                {"Quản lý nhân sự", checkboxPersonnelManagement},
                {"Thêm nhân sự", checkboxAddPersonnel},
                {"Cập nhật nhân sự", checkboxUpdatePersonnel},
                {"Xóa nhân sự", checkboxDeletePersonnel},

                {"Quản lý bộ phận", checkboxPartManagement},
                {"Thêm bộ phận", checkboxAddPart},
                {"Cập nhật bộ phận", checkboxUpdatePart},
                {"Xóa bộ phận", checkboxDeletePart},

                {"Quản lý chức vụ", checkboxPositionManagement},
                {"Thêm chức vụ", checkboxAddPosition},
                {"Cập nhật chức vụ", checkboxUpdatePosition},
                {"Xóa chức vụ", checkboxDeletePosition},

                {"Quản lý tài khoản", checkboxAccountManagement},
                {"Thêm tài khoản", checkboxAddAccount},
                {"Cập nhật tài khoản", checkboxUpdateAccount},
                {"Xóa tài khoản", checkboxDeleteAccount},

                {"Quản lý công việc", checkboxTasksManagement},
                {"Ra thông báo", checkboxSendNotification},
                {"Giao việc", checkboxAssignTasks},
                {"Cập nhật công việc", checkboxUpdateTasks},
                {"Xóa công việc", checkboxDeleteTasks},
                {"Nhận việc", checkBoxGetTasks },
                {"Báo cáo công việc", checkBoxReportTasks }
            };
        }

        private void CheckPermissionCheckboxes(List<Permission> permissionNames)
        {
            foreach (var checkbox in permissionCheckboxMap.Values)
            {
                checkbox.Checked = false;
            }

            foreach (Permission permissionName in permissionNames)
            {
                if (permissionCheckboxMap.ContainsKey(permissionName.ten))
                {
                    permissionCheckboxMap[permissionName.ten].Checked = true;
                }
            }

            CheckParentCheckboxes();
        }

        private void CheckParentCheckboxes()
        {
            checkboxPersonnelManagement.Checked =
                checkboxAddPersonnel.Checked &&
                checkboxUpdatePersonnel.Checked &&
                checkboxDeletePersonnel.Checked;

            checkboxPartManagement.Checked =
                checkboxAddPart.Checked &&
                checkboxUpdatePart.Checked &&
                checkboxDeletePart.Checked;

            checkboxPositionManagement.Checked =
                checkboxAddPosition.Checked &&
                checkboxUpdatePosition.Checked &&
                checkboxDeletePosition.Checked;

            checkboxAccountManagement.Checked =
                checkboxAddAccount.Checked &&
                checkboxUpdateAccount.Checked &&
                checkboxDeleteAccount.Checked;

            checkboxTasksManagement.Checked =
                checkboxSendNotification.Checked &&
                checkboxAssignTasks.Checked &&
                checkboxUpdateTasks.Checked &&
                checkboxDeleteTasks.Checked &&
                checkBoxGetTasks.Checked &&
                checkBoxReportTasks.Checked;
        }
        private void CheckPermissions()
        {
            try
            {
                AccountInfo info = decentralizationBLL.getAccountInfo(this.accountName);
                List<Permission> permissions = decentralizationBLL.getAllPermissions(this.accountName);
                CheckPermissionCheckboxes(permissions);
                if (info != null)
                {
                    txtPersonnel.Text = info.TenNhanSu;
                    txtDepartment.Text = info.TenBoPhan;
                    txtPosition.Text = info.TenChucVu;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" +  ex.Message);
            }
        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                List<ListRole> listRoles = listRoleBLL.LayDanhSachQuyen();
                List<string> permissionsList = new List<string>();

                foreach (var role in listRoles)
                {
                    if (permissionCheckboxMap.ContainsKey(role.TenQuyen) && permissionCheckboxMap[role.TenQuyen].Checked)
                    {
                        Console.Write(role.TenQuyen + " ,  ");
                        permissionsList.Add(role.TenQuyen);
                    }
                }
                string selectedPermissions = string.Join(",", permissionsList);

                if (!string.IsNullOrEmpty(selectedPermissions))
                {
                    bool result = decentralizationBLL.updateRoles(this.accountName, selectedPermissions);
                    if (result)
                    {
                        layoutdecentralizationForm.loadDataFromDecentralization();
                        showMessage("Cập nhật quyền thành công!", "success");
                        this.Close();
                    }
                    else
                    {
                        showMessage("Cập nhật quyền thất bại!", "error");
                        this.Close();
                    }
                }
                else
                {
                    showMessage("Vui lòng chọn ít nhất một quyền!", "error");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void checkboxAddPersonnel_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
