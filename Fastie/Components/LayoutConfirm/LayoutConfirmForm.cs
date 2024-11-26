using Fastie.Screens.Login;
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
using Fastie.Components.LayoutDecentralization;
using Fastie.Components.LayoutDepartment;
using Fastie.Components.LayoutDepartmen;
using Fastie.Components.LayoutPersonnel;
using BLL.DepartmentBLL;
using Fastie.Components.LayoutAccount;
using Fastie.Components.Toastify;

namespace Fastie
{
    public partial class LayoutConfirmForm : Form
    {
        private string accountName;
        private LayoutDecentralizationForm decentralizationForm;
        private LayoutPositionForm layoutPositionForm;
        private LayoutDepartmentForm layoutDepartmentForm;
        private LayoutPersonnelForm layoutPersonnelForm;
        private LayoutAccountForm layoutAccountForm;
        private AccountForm AccountForm;
        private HomeForm homeForm;

        PositionBLL positionBLL = new PositionBLL();
        PersonnelBLL personnelBLL = new PersonnelBLL();
        DepartmentBLL departmentBLL = new DepartmentBLL();
        DecentralizationBLL decentralizationBLL = new DecentralizationBLL();
        AccountBLL accountBll = new AccountBLL();

        public LayoutConfirmForm()
        {
            InitializeComponent();
        }
        public LayoutConfirmForm(HomeForm homeFomm)
        {
            InitializeComponent();
            this.homeForm = homeFomm;

        }
        public LayoutConfirmForm(LayoutDecentralizationForm decentralization ,string accountName) //DecentralizationForm decentralization ,string accountName
        {
            InitializeComponent();
            this.accountName = accountName;
            this.decentralizationForm = decentralization;   
        }

        public LayoutConfirmForm(LayoutPositionForm layoutPositionForm, string accountName) 
        {
            InitializeComponent();
            this.accountName = accountName;
            this.layoutPositionForm = layoutPositionForm;
        }
        public LayoutConfirmForm(LayoutDepartmentForm layoutDepartment, string accountName)
        {
            InitializeComponent();
            this.accountName = accountName;
            this.layoutDepartmentForm = layoutDepartment;
        }

        public LayoutConfirmForm(LayoutPersonnelForm layoutPersonnelForm, string accountName)
        {
            InitializeComponent();
            this.accountName = accountName;
            this.layoutPersonnelForm = layoutPersonnelForm;
        }
        public LayoutConfirmForm(LayoutAccountForm layoutAccountForm, string accountName)
        {
            InitializeComponent();
            this.accountName = accountName;
            this.layoutAccountForm = layoutAccountForm;
        }
        public LayoutConfirmForm(AccountForm accountForm, string accountName)
        {
            InitializeComponent();
            this.AccountForm  = accountForm;
            this.accountName = accountName;
        }

        public string AccountName { get => accountName; set => accountName = value; }   
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public string Content { get => lblContent.Text; set => lblContent.Text = value; }
        public string btnConfirmText { get => btnConfirm.Text; set => btnConfirm.Text = value; }


        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LayoutConfirm_Load(object sender, EventArgs e)
        {
            lblContent.Text = Content;
            lblTitle.Text = Title;
            btnConfirm.Text = btnConfirmText;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            switch (btnConfirm.Text)
            {
                case "Xóa quyền":
                    bool result = decentralizationBLL.deleteAllRoles(this.accountName);
                    if (result)
                    {
                        showMessage("Xóa quyền thành công", "success");
                        decentralizationForm.loadDataFromDecentralization();
                    }
                    else
                    {
                        showMessage("Xóa quyền thất bại", "error");
                    }
                    this.Close();
                    break;
                case "Xóa chức vụ":
                    bool xoaChucVu = positionBLL.DeletePosition(layoutPositionForm.IdPosition);
                    if (xoaChucVu)
                    {
                        showMessage("Xóa chức vụ thành công", "success");
                        layoutPositionForm.LoadPositionData();
                    }
                    else
                    {
                        showMessage("Xóa chức vụ thất bại", "error");
                    }
                    this.Close();
                    break;
                case "Xóa bộ phận":
                    bool xoaBoPhan = departmentBLL.DeleteDepartment(layoutDepartmentForm.IdDepartment);
                    if (xoaBoPhan)
                    {
                        showMessage("Xóa bộ phận thành công", "success");
                        layoutDepartmentForm.loadDataDepartment();
                    }
                    else
                    {
                        showMessage("Xóa bộ phận thất bại", "error");
                    }
                    this.Close();
                    break;
                case "Xóa nhân sự":
                    bool xoaNhanSu = personnelBLL.DeletePersonnel(layoutPersonnelForm.IdPersonnel);
                    if (xoaNhanSu)
                    {
                        showMessage("Xóa nhân sự thành công", "success");
                        layoutPersonnelForm.loadDataPersonnel();
                    }
                    else
                    {
                        showMessage("Xóa nhân sự thất bại", "error");
                    }
                    this.Close();
                    break;
                case "Cập nhật":
                    MessageBox.Show("Cập nhật thành công", "success");
                    break;
                case "Thêm":
                    MessageBox.Show("Thêm thành công", "success");
                    break;
                case "Đăng xuất":
                    foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                    {
                        if(form.Name != "LoginForm")
                        {
                            form.Close();
                        }
                    }
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    break;
                case "Vô hiệu hóa":
                    try { 
                        int checkDisable = accountBll.VoHieuHoaTaiKhoan(accountName);
                        AccountForm.LoadDataAccount();
                        if(checkDisable == 0)
                        {
                            showMessage("Vô hiệu hóa tài khoản thành công", "success");
                        } else if(checkDisable == -1)
                        {

                           showMessage("Tài khoản không tồn tại", "error");
                        } else
                        {
                            showMessage("Vô hiệu hóa tài khoản thất bại", "error");
                        }

                    } catch(Exception ex)
                    {
                        showMessage("Vô hiệu hóa tài khoản thất bại", "error");
                    }
                    this.Close();
                    break;
                case "Kích hoạt":
                    try
                    {
                        int checkDisable = accountBll.CapNhatTrangThaiTaiKhoan(accountName);
                        AccountForm.LoadDataAccount();
                        if (checkDisable == 0)
                        {
                            showMessage("Kích hoạt tài khoản thành công", "success");
                        }
                        else if (checkDisable == -1)
                        {

                            showMessage("Tài khoản không tồn tại", "error");
                        }
                        else
                        {
                            showMessage("Kích hoạt tài khoản thất bại", "error");
                        }

                    }
                    catch (Exception ex)
                    {
                        showMessage("Vô hiệu hóa tài khoản thất bại", "error");
                    }
                    this.Close();
                    break;
                case "Xóa việc":
                    showMessage("Xóa việc thành công", "success");
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
