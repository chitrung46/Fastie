using DTO;
using Fastie.Components.LayoutAccount;
using Fastie.Components.LayoutDecentralization;
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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void loadDataAccount()
        {
            for (int i = 0; i < 10; i++)
            {
                var layoutAccountForm = new LayoutAccountForm(this)
                {
                    PersonnelName = "Nhật Toàn",
                    PositionName = "Quản lý",
                    DepartmentName = "Kế toán",
                    StatusAccount = "Hoạt động",
                    HasAccount = "Đã có",
                    IdAccount = "ACC" + i
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
