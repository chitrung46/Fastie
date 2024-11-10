using BLL.DecentralizationBLL;
using DTO;
using Fastie.Components.LayoutDecentralization;
using Fastie.Components.LayoutRole;
using Fastie.Components.Toastify;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Screens.Decentralization
{
    public partial class DecentralizationForm : Form
    {
        DecentralizationBLL decentralizationBLL = new DecentralizationBLL();
        private string stateCurrentList;
        private bool isLoaded = false;
        private string selectedDepartmentId;
        private string selectedPositionId;

        public string StateCurrentList { get => stateCurrentList; set => stateCurrentList = value; }

        public DecentralizationForm()
        {
            InitializeComponent();
        }
        private void setStateButton(Button stateBtn)
        {
            Button[] button = { btnHaveRole, btnRoleless};
            for (int i = 0; i < button.Length; i++)
            {
                if (button[i] != stateBtn)
                {
                    button[i].BackColor = Color.Transparent;
                }
            }
            stateBtn.BackColor = Color.IndianRed;
        }

        private void LoadDataPersonnel(List<AccountInfo> accountInfos)
        {
            flowLayoutPanelPersonnel.Controls.Clear();
            switch (this.stateCurrentList)
            {
                case "Role":
                    loadDataFormat(accountInfos);
                    break;
                case "RoleLess":
                    loadDataFormat(accountInfos);
                    break;
                default:
                    loadDataFormat(accountInfos);
                    break;
            }
        }


        private void loadDataFormat(List<AccountInfo> accountInfos)
        {
            int i = 0;
            foreach (AccountInfo accountInfo in accountInfos)
            {
                var layoutDecentralizationForm = new LayoutDecentralizationForm(this)
                {
                    Number = (i + 1).ToString(),
                    PersonnelName = accountInfo.TenNhanSu,
                    PositionName = accountInfo.TenBoPhan,
                    DepartmentName = accountInfo.TenChucVu,
                    AccountName = accountInfo.TenDangNhap
                };
                flowLayoutPanelPersonnel.Controls.Add(layoutDecentralizationForm);
                i++;
            }
        }

        private void loadDataPositionList()
        {
            List<PositionInfo> positionInfos = decentralizationBLL.getPositionList();

            if (positionInfos != null)
            {
                cbPosition.Items.Clear();
                cbPosition.Items.Add(new KeyValuePair<string, string>(null, "Tất cả"));

                foreach (PositionInfo position in positionInfos)
                {
                    cbPosition.Items.Add(new KeyValuePair<string, string>(position.IdChucVu, position.TenChucVu));
                }

                cbPosition.DisplayMember = "Value";
                cbPosition.ValueMember = "Key";

                cbPosition.SelectedIndex = 0;
            }
        }

        private void loadDataDepartmentList()
        {
            List<DepartmentInfo> departmentInfos = decentralizationBLL.getDepartmentList();

            if (departmentInfos != null)
            {
                cbDepartment.Items.Clear();
                cbDepartment.Items.Add(new KeyValuePair<string, string>(null, "Tất cả"));

                foreach (DepartmentInfo department in departmentInfos)
                {
                    cbDepartment.Items.Add(new KeyValuePair<string, string>(department.IdBoPhan, department.TenBoPhan));
                }

                cbDepartment.DisplayMember = "Value";
                cbDepartment.ValueMember = "Key";

                cbDepartment.SelectedIndex = 0;
            }
        }
        public void loadDataForRole()
        {
            List<AccountInfo> accountInfoPersonnel = decentralizationBLL.getAllAccountInfo();
            this.stateCurrentList = "Role";
            LoadDataPersonnel(accountInfoPersonnel);
        }
        public void loadDataForRoleLess()
        {
            List<AccountInfo> accountInfoRoleless = decentralizationBLL.getAllPersonnelRoleLess();
            this.stateCurrentList = "Roleless";
            LoadDataPersonnel(accountInfoRoleless);
        }

        private void DecentralizationBackupForm_Load(object sender, EventArgs e)
        {
            isLoaded = false;
            loadDataForRole();
            loadDataDepartmentList();
            loadDataPositionList();
            isLoaded = true;
        }

        private void btnHaveRole_Click(object sender, EventArgs e)
        {
            setStateButton(btnHaveRole);
            loadDataForRole();
            showByPositionIdAndDepartmentId();
        }

        private void btnRoleless_Click(object sender, EventArgs e)
        {
            setStateButton(btnRoleless);
            loadDataForRoleLess();
            showByPositionIdAndDepartmentId();

        }

        private void cbDepartment_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                var selectedId = ((KeyValuePair<string, string>)cbDepartment.SelectedItem).Key;
                this.selectedDepartmentId = selectedId;
                showByPositionIdAndDepartmentId();
            }
        }

        private void cbPosition_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                var selectedId = ((KeyValuePair<string, string>)cbPosition.SelectedItem).Key;
                this.selectedPositionId = selectedId;
                showByPositionIdAndDepartmentId();
            }
        }

        private void showByPositionIdAndDepartmentId()
        {
            switch (this.stateCurrentList)
            {
                case "Role":
                    if (selectedDepartmentId != null && selectedPositionId != null)
                    {
                        List<AccountInfo> accountInfo = decentralizationBLL.getListByDepartmentIdAndPositionId(this.selectedDepartmentId, this.selectedPositionId);
                        LoadDataPersonnel(accountInfo);
                    } else if (selectedDepartmentId != null && selectedPositionId == null)
                    {
                        List<AccountInfo> accountInfo = decentralizationBLL.getDepartmentListwithAllPosition(this.selectedDepartmentId);
                        LoadDataPersonnel(accountInfo);
                    } else if (selectedDepartmentId == null && selectedPositionId != null)
                    {
                        List<AccountInfo> accountInfo = decentralizationBLL.getPositionListwithAllDepartment(this.selectedPositionId);
                        LoadDataPersonnel(accountInfo);
                    } else
                    {
                        List<AccountInfo> accountInfoPersonnel = decentralizationBLL.getAllAccountInfo();
                        LoadDataPersonnel(accountInfoPersonnel);
                    }
                        break;
                case "Roleless":
                    if (selectedDepartmentId != null && selectedPositionId != null)
                    {
                        List<AccountInfo> accountInfoRoleless = decentralizationBLL.getListByDepartmentIdAndPositionIdRoleLess(this.selectedDepartmentId, this.selectedPositionId);
                        LoadDataPersonnel(accountInfoRoleless);
                    }
                    else if (selectedDepartmentId != null && selectedPositionId == null)
                    {
                        List<AccountInfo> accountInfoRoleless = decentralizationBLL.getDepartmentListwithAllPositionRoleLess(this.selectedDepartmentId);
                        LoadDataPersonnel(accountInfoRoleless);
                    }
                    else if (selectedDepartmentId == null && selectedPositionId != null)
                    {
                        List<AccountInfo> accountInfoRoleless = decentralizationBLL.getPositionListwithAllDepartmentRoleLess(this.selectedPositionId);
                        LoadDataPersonnel(accountInfoRoleless);
                    }
                    else
                    {
                        List<AccountInfo> accountInfoRoleless = decentralizationBLL.getAllPersonnelRoleLess();
                        LoadDataPersonnel(accountInfoRoleless);
                    }
                    break;
                default:
                    break;
            }
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            switch (this.stateCurrentList)
            {
                case "Role":
                    if (searchValue == "")
                    {
                        loadDataForRole();
                    }
                    else
                    {
                        List<AccountInfo> accountInfoPersonnel = decentralizationBLL.TimKiemNhanSuCoQuyen(searchValue);
                        this.stateCurrentList = "Role";
                        LoadDataPersonnel(accountInfoPersonnel);
                    }
                    break;
                case "Roleless":
                    if (searchValue == "")
                    {
                        loadDataForRoleLess();
                    }
                    else
                    {
                        List<AccountInfo> accountInfoPersonnel = decentralizationBLL.TimKiemNhanSuChuaCoQuyen(searchValue);
                        this.stateCurrentList = "Roleless";
                        LoadDataPersonnel(accountInfoPersonnel);
                    }
                    break;
            }
        }
    }
}
