using BLL.DecentralizationBLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fastie.Components.Toastify;
using BLL.DepartmentBLL;
using Fastie.Components.LayoutPersonnel;
using System.ComponentModel.DataAnnotations;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Fastie
{
    public partial class CreateAccount : Form
    {
        DecentralizationBLL decentralizationBLL = new DecentralizationBLL();
        AccountBLL accountBLL = new AccountBLL();
        private string stateCurrentList;
        private bool isLoaded = false;
        private string selectedDepartmentId;
        private string selectedPositionId;
        private LayoutPersonnelForm layoutPersonnelForm;
        public CreateAccount(LayoutPersonnelForm layoutPersonnelForm)
        {
            InitializeComponent();
            this.layoutPersonnelForm = layoutPersonnelForm;
        }
        private void loadDataPositionList()
        {
            List<PositionInfo> positionInfos = decentralizationBLL.getPositionList();

            if (positionInfos != null)
            {
                cbPosition.Items.Clear();
                

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
                

                foreach (DepartmentInfo department in departmentInfos)
                {
                    cbDepartment.Items.Add(new KeyValuePair<string, string>(department.IdBoPhan, department.TenBoPhan));
                }

                cbDepartment.DisplayMember = "Value";
                cbDepartment.ValueMember = "Key";

                cbDepartment.SelectedIndex = 0;
            }
        }
        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            isLoaded = false;
            loadDataDepartmentList();
            loadDataPositionList();
            isLoaded = true;
        }

        private void cbDepartment_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                var selectedId = ((KeyValuePair<string, string>)cbDepartment.SelectedItem).Key;
                this.selectedDepartmentId = selectedId;                
            }
        }

        private void cbPosition_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                var selectedId = ((KeyValuePair<string, string>)cbPosition.SelectedItem).Key;
                this.selectedPositionId = selectedId;                
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cTBName.Text)
                || string.IsNullOrWhiteSpace(customTextBox1.Text)
                || customTextBox1.Text.Length < 6
                || selectedDepartmentId == null
                || selectedPositionId == null)
            {
                showMessage("Vui lòng nhập đầy đủ thông tin", "error");
                return;
            }
            try
            {
                Account taoTaiKhoanMoi = new Account
                {
                    TenDangNhap = cTBName.Text,
                    MatKhau = customTextBox1.Text,
                    IdNhanSu = layoutPersonnelForm.IdPersonnel,
                    IdChucVu = this.selectedPositionId,
                    IdBoPhan = this.selectedDepartmentId
                };
                accountBLL.ThemTaiKhoan(taoTaiKhoanMoi);
                showMessage("Thêm Tài khoản mới thành công!", "success");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //departmentForm.LoadDataDepartment();
            this.Close();
        }
    }
}
