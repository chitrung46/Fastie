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
using Fastie.Components.LayoutPersonnel;
namespace Fastie
{
    public partial class LayoutConfirmForm : Form
    {
        private string accountName;
        //private DecentralizationForm decentralizationForm;
        private LayoutDecentralizationForm decentralizationForm;
        private LayoutPositionForm layoutPositionForm;
        private LayoutDepartmentForm layoutDepartmentForm;
        private LayoutPersonnelForm layoutPersonnelForm;

        PositionBLL positionBLL = new PositionBLL();
        PersonnelBLL personnelBLL = new PersonnelBLL();
        DepartmentBLL departmentBLL = new DepartmentBLL();
        DecentralizationBLL decentralizationBLL = new DecentralizationBLL();

        public LayoutConfirmForm()
        {
            InitializeComponent();
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
<<<<<<< HEAD
        public LayoutConfirmForm(LayoutPersonnelForm layoutPersonnel, string accountName)
        {
            InitializeComponent();
            this.accountName = accountName;
            this.layoutPersonnelForm = layoutPersonnel;
=======
        public LayoutConfirmForm(LayoutPersonnelForm layoutPersonnelForm, string accountName)
        {
            InitializeComponent();
            this.accountName = accountName;
            this.layoutPersonnelForm = layoutPersonnelForm;
>>>>>>> origin/Toan
        }

        public string AccountName { get => accountName; set => accountName = value; }   
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public string Content { get => lblContent.Text; set => lblContent.Text = value; }
        public string btnConfirmText { get => btnConfirm.Text; set => btnConfirm.Text = value; }

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
                    if(result)
                    {
                        MessageBox.Show("Xóa quyền thành công");
                        decentralizationForm.loadDataFromDecentralization();
                    }
                    else
                    {
                        MessageBox.Show("Xóa quyền thất bại");
                    }
                    this.Close();
                    break;
                case "Xóa chức vụ":
                    positionBLL.DeletePosition(layoutPositionForm.IdPosition);
                    layoutPositionForm.LoadPositionData();
                    MessageBox.Show("Xóa chức vụ thành công");
                    this.Close();
                    break;
                case "Xóa bộ phận":
                    departmentBLL.DeleteDepartment(layoutDepartmentForm.IdDepartment);
                    layoutDepartmentForm.loadDataDepartment();
                    MessageBox.Show("Xóa bộ phận thành công");
                    this.Close();
                    break;
                case "Xóa nhân sự":
<<<<<<< HEAD
                    personnelBLL.DeletePersonnel(layoutPersonnelForm.IdPersonnel);
                    layoutPersonnelForm.loadDataPersonnel();
                    MessageBox.Show("Xóa nhân sự thành công");
=======
                    MessageBox.Show("Xóa nhân sự thành công", layoutPersonnelForm.IdPersonnel);
                    personnelBLL.DeletePersonnel(layoutPersonnelForm.IdPersonnel);
                    layoutPersonnelForm.loadDataPersonnel();
>>>>>>> origin/Toan
                    this.Close();
                    break;
                case "Cập nhật":
                    MessageBox.Show("Cập nhật thành công");
                    break;
                case "Thêm":
                    MessageBox.Show("Thêm thành công");
                    break;
                case "Đăng xuất":
                    this.Close();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
