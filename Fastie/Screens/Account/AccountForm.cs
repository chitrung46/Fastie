using BLL;
using DTO;
using Fastie.Components.LayoutAccount;
using Fastie.Components.LayoutDecentralization;
using Fastie.Components.LayoutTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie
{
    public partial class AccountForm : Form
    {
        private HomeForm homeForm;
        AccountBLL accountBLL = new AccountBLL();
        public AccountForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
        }

        private void loadDataAccount()
        {
            flowLayoutPanelAcoount.Controls.Clear();
            List<Account> account = accountBLL.LayDanhSachTaiKhoan();

            foreach (Account taikhoan in account)
            {
                LayoutAccountForm layoutAccountForm = new LayoutAccountForm(this, homeForm)
                {

                    PersonnelName = taikhoan.TenNhanSu,
                    PositionName = taikhoan.TenChucVu,
                    DepartmentName = taikhoan.TenBoPhan,
                    StatusAccount = taikhoan.TrangThai,
                    HasAccount = "Đã có",
                    IdAccount = "ACC"
                };
                flowLayoutPanelAcoount.Controls.Add(layoutAccountForm);
            }
        }


        private void AccountForm_Load(object sender, EventArgs e)
        {
            loadDataAccount();
        }
    }
}
