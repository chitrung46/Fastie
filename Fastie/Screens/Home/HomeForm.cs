using BLL.PermissionBLL;
using DTO;
using Fastie.Components.NoPermissionAccessForm;
using Fastie.Components.Toastify;
using Fastie.Screens.ContactInformation;
using Fastie.Screens.Decentralization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie
{
    public partial class HomeForm : Form
    {
        private string idTaiKhoan;
        private string idNhanSu;
        private string idChucVu;
        private string idBoPhan;
        private string tenNhanSu;
        private string tenBoPhan;

        AccountId accountId  = new AccountId();
        PermissionBLL permissionBLL = new PermissionBLL();

        public HomeForm()
        {
            InitializeComponent();
            if(UserAccountSession.Instance.UserInfo.Count == 0)
            {
                MessageBox.Show("Bạn chưa đăng nhập! bạn đang trong chế độ phát triển phần mềm. Tài khoản mặc định là TK0000000001. Nhấn OK để tiếp tục");
                //Create temporary account TK0000000001 - CV001 - NS0000000001 - BP001
                this.idTaiKhoan = "TK0000000001";
                this.idChucVu = "CV001";
                this.idBoPhan = "BP001";
                this.idNhanSu = "NS0000000001";
                this.tenNhanSu = "Lương Chí Trung";
                this.TenBoPhan = "Giám đốc";
            } else
            {
                var user = UserAccountSession.Instance.UserInfo[0];
                if (user.IdTaiKhoan != null && user.IdChucVu != null && user.IdNhanSu != null && user.IdBoPhan != null)
                {
                    this.idTaiKhoan = user.IdTaiKhoan;
                    this.idChucVu = user.IdChucVu;
                    this.idNhanSu = user.IdNhanSu;
                    this.idBoPhan = user.IdBoPhan;
                    this.tenNhanSu = user.TenNhanSu;
                    this.tenBoPhan = user.TenBoPhan;
                }
                Console.WriteLine(this.IdTaiKhoan + " - " + this.idChucVu + " - " + this.idNhanSu + " - " + this.idBoPhan + " - " + this.tenNhanSu + " - " + this.tenBoPhan);
            }

        }

        public string IdTaiKhoan
        {
            get { return idTaiKhoan; }
            set { idTaiKhoan = value; }
        }
        
        public string IdChucVu
        {
            get { return idChucVu; }
            set { idChucVu = value; }
        }

        public string TenNhanSu
        {
            get { return tenNhanSu; }
            set { tenNhanSu = value; }
        }
        public string TenBoPhan
        {
            get { return tenBoPhan; }
            set { tenBoPhan = value; }
        }
        private void FormLayout_Load(object sender, EventArgs e)
        {
            lblPersonnelName.Text = this.tenNhanSu;
            lblDepartmentName.Text = this.tenBoPhan;
            bool checkPermission = permissionBLL.checkPermission(idTaiKhoan, "Q0001"); //Q0001 is permission to access DecentralizationForm
            if (idChucVu == "CV001" || checkPermission)
            {
                DecentralizationForm decentralization = new DecentralizationForm();
                addFormInMainLayout(decentralization);
            } else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
        }

        //Add form in main layout
        private void addFormInMainLayout(Form userControl)
        {
            mainLayout.Controls.Clear();
            userControl.TopLevel = false;
            mainLayout.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();

        }

        //Check other panel is not click
        private void setStatePanel(Panel statePanel)
        {
            Panel[] panel = { stateDecentralization, statePart, statePosition, statePersonnel, stateWork, stateAnalytics, stateAccount };
            for (int i = 0; i < panel.Length; i++)
            {
                if (panel[i] != statePanel)
                {
                    panel[i].BackColor = Color.Transparent;
                }
            }
            statePanel.BackColor = Color.FromArgb(59, 171, 201);
        }

        //Set Click panel

        private void btnDecentralization_Click(object sender, EventArgs e)
        {
            bool checkPermission = permissionBLL.checkPermission(idTaiKhoan, "Q0001");
            if (idChucVu == "CV001" || checkPermission)
            {
                DecentralizationForm decentralization = new DecentralizationForm();
                addFormInMainLayout(decentralization);
            }
            else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
            setStatePanel(stateDecentralization);
        }

        private void btnPart_Click(object sender, EventArgs e)
        {
            string permissionId = "Q0006,Q0007,Q0008,Q0009";
            bool checkPermission = permissionBLL.checkPermission(idTaiKhoan, permissionId);
            if (checkPermission)
            {
                DepartmentForm departmentForm = new DepartmentForm(this.idTaiKhoan, this.idChucVu);
                addFormInMainLayout(departmentForm);
            }
            else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
            setStatePanel(statePart);
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            string permissionId = "Q0010,Q0011,Q0012,Q0013";
            bool checkPermission = permissionBLL.checkPermission(idTaiKhoan, permissionId);
            if (checkPermission)
            {
                PositionForm position = new PositionForm(this.idTaiKhoan, this.idChucVu);
                addFormInMainLayout(position);
            }
            else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
            setStatePanel(statePosition);
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            string permissionId = "Q0014,Q0015,Q0016,Q0017";
            bool checkPermission = permissionBLL.checkPermission(idTaiKhoan, permissionId);
            if (checkPermission)
            {
                PersonnelForm personnel = new PersonnelForm(this.idTaiKhoan, this.idChucVu);
                addFormInMainLayout(personnel);
            }
            else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
            setStatePanel(statePersonnel);
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            string permissionId = "Q0018,Q0019,Q0020,Q0021,Q0022,Q0023,Q0024";
            bool checkPermission = permissionBLL.checkPermission(idTaiKhoan, permissionId);
            if (checkPermission)
            {
                TaskForm work = new TaskForm(this.idTaiKhoan, this.idBoPhan, this.idChucVu);
                addFormInMainLayout(work);
            }
            else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm); 
            }
            setStatePanel(stateWork);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics();
            addFormInMainLayout(analytics);
            setStatePanel(stateAnalytics);

        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            string permissionId = "Q0002,Q0003,Q0004,Q0005";
            bool checkPermission = permissionBLL.checkPermission(idTaiKhoan, permissionId);
            if (checkPermission)
            {
                AccountForm account = new AccountForm(this);
                addFormInMainLayout(account);
            }
            else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
            setStatePanel(stateAccount);
        }


        //Set hover
        private void pnlDecentralization_MouseLeave(object sender, EventArgs e)
        {
            btnDecentralization.BackColor = Color.Transparent;
        }

        private void pnlDecentralization_MouseEnter(object sender, EventArgs e)
        {
            btnDecentralization.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlPart_MouseEnter(object sender, EventArgs e)
        {
            btnPart.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlPart_MouseLeave(object sender, EventArgs e)
        {
            btnPart.BackColor = Color.Transparent;  
        }

        private void pnlPosition_MouseEnter(object sender, EventArgs e)
        {
            btnPosition.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlPosition_MouseLeave(object sender, EventArgs e)
        {
            btnPosition.BackColor = Color.Transparent;
        }

        private void pnlPersonnel_MouseEnter(object sender, EventArgs e)
        {
            btnPersonnel.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlPersonnel_MouseLeave(object sender, EventArgs e)
        {
            btnPersonnel.BackColor = Color.Transparent;
        }

        private void pnlWork_MouseEnter(object sender, EventArgs e)
        {
            btnWork.BackColor = Color.FromArgb(91, 91, 92); 
        }

        private void pnlWork_MouseLeave(object sender, EventArgs e)
        {
            btnWork.BackColor = Color.Transparent;
        }

        private void pnlAnalytics_MouseEnter(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlAnalytics_MouseLeave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.Transparent;
        }

        private void pnlLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(91, 91, 92);
        }

        private void pnlLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Transparent;
        }
        private void pnlAccount_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(91, 91, 92);

        }

        private void pnlAccount_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Transparent;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string[] information = { "Bạn có chắc chắn muốn đăng xuất?", "Bạn sẽ không thể thực hiện các chức năng hệ thống", "Đăng xuất" };
            
            LayoutConfirmForm layoutConfirmForm = new LayoutConfirmForm(this);
            layoutConfirmForm.Title = information[0];
            layoutConfirmForm.Content = information[1];
            layoutConfirmForm.btnConfirmText = information[2];
            layoutConfirmForm.Show();
        }

        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            ContactInformationForm contactInformationForm = new ContactInformationForm();
            contactInformationForm.Show();
        }
    }
}
