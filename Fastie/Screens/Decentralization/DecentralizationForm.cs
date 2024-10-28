using BLL;
using DTO;
using Fastie.Screen.Decentralization;
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
    public partial class DecentralizationForm : Form
    {
        AccountBLL accountBll = new AccountBLL();
        private string accountName;
        private string tenNhanSu;

        public DecentralizationForm()
        {
            InitializeComponent();
        }
        public DecentralizationForm(string accountName)
        {
            InitializeComponent();
            this.accountName = accountName;
        }

        public string AccountName { get => accountName; set => accountName = value; }
        public string TenNhanSu { get => tenNhanSu; set => tenNhanSu = value; }

        public void loadData()
        {
            loadDataPersonnel();
            loadDataPersonnelRoleless();
        }
        private void Decentralization_Load(object sender, EventArgs e)
        {
            loadDataPersonnel();
            loadDataPersonnelRoleless();
            
        }

        private void loadDataPersonnel()
        {
            List<AccountInfo> accountInfo = accountBll.getAllAccountInfo();
            dataGridViewPersonnel.Rows.Clear(); 
            if(dataGridViewPersonnel.Columns.Count == 0)
            {
                dataGridViewPersonnel.Columns.Add("soThuTu", "STT");
                dataGridViewPersonnel.Columns.Add("tenNhanSu", "Tên Nhân Sự");
                dataGridViewPersonnel.Columns.Add("tenBoPhan", "Tên Bộ Phận");
                dataGridViewPersonnel.Columns.Add("tenChucVu", "Tên Chức Vụ");
            }
            if (accountInfo != null)
            {
                int count = 1;
                foreach (AccountInfo account in accountInfo)
                {
                    DataGridViewRow rows = new DataGridViewRow();
                    rows.CreateCells(dataGridViewPersonnel);
                    rows.Cells[0].Value = count++;
                    rows.Cells[1].Value = account.TenNhanSu;
                    rows.Cells[2].Value = account.TenBoPhan;
                    rows.Cells[3].Value = account.TenChucVu;
                    rows.Tag = account.TenDangNhap;
                    dataGridViewPersonnel.Rows.Add(rows);
                }
            }
        }

        private void loadDataPersonnelRoleless()
        {
            dataGridViewRoleless.Rows.Clear();
            if(dataGridViewRoleless.Columns.Count == 0)
            {
                dataGridViewRoleless.Columns.Add("soThuTu", "STT");
                dataGridViewRoleless.Columns.Add("tenNhanSu", "Tên Nhân Sự");
                dataGridViewRoleless.Columns.Add("tenBoPhan", "Tên Bộ Phận");
                dataGridViewRoleless.Columns.Add("tenChucVu", "Tên Chức Vụ");
            }
            List<AccountInfo> accountInfo = accountBll.getAllPersonnelRoleLess();
            if (accountInfo != null)
            {
                int count = 1;
                foreach (AccountInfo account in accountInfo)
                {
                    DataGridViewRow rows = new DataGridViewRow();
                    rows.CreateCells(dataGridViewRoleless);
                    rows.Cells[0].Value = count++;
                    rows.Cells[1].Value = account.TenNhanSu;
                    rows.Cells[2].Value = account.TenBoPhan;
                    rows.Cells[3].Value = account.TenChucVu;
                    rows.Tag = account.TenDangNhap;
                    dataGridViewRoleless.Rows.Add(rows);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateDecentralizationForm createDecentralization = new CreateDecentralizationForm(this ,this.accountName);
            createDecentralization.OnFormClosing += () =>
            {
                //Unable decentralization
                btnAdd.Enabled = false;
                btnAdd.Image = Properties.Resources.icons8_pencil_23_black;
                btnAdd.ForeColor = Color.FromArgb(0, 0, 0);

                //Unable delete
                btnDelete.Enabled = false;
                btnDelete.Image = Properties.Resources.icons8_delete_23_black;
                btnDelete.ForeColor = Color.FromArgb(0, 0, 0);

            };
            createDecentralization.Show();
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] information = { "Bạn có chắc chắn xóa toàn bộ quyền?", $"{this.tenNhanSu} sẽ mất toàn bộ quyền trong hệ thống", "Xóa quyền" };
            LayoutConfirmForm deleteLayoutConfirm = new LayoutConfirmForm(this, this.accountName);
            deleteLayoutConfirm.Title = information[0];
            deleteLayoutConfirm.Content = information[1];
            deleteLayoutConfirm.btnConfirmText = information[2];
            deleteLayoutConfirm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDecentralizationForm updateDecentralization = new UpdateDecentralizationForm();
            updateDecentralization.Show();

        }

        private void dataGridViewPersonnel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPersonnel.Rows[e.RowIndex];
                string accountName = row.Tag.ToString();
                string tenNhanSu = row.Cells[1].Value.ToString();
                if(accountName!=null)
                {
                    //enale decentralization
                    btnAdd.Enabled = true;
                    btnAdd.Image = Properties.Resources.icons8_pencil_23;
                    btnAdd.ForeColor = Color.FromArgb(255,255,255);

                    //enable delete
                    btnDelete.Enabled = true;
                    btnDelete.Image = Properties.Resources.icons8_delete_23;
                    btnDelete.ForeColor = Color.FromArgb(255,255,255);

                    this.accountName = accountName;
                    this.tenNhanSu = tenNhanSu;
                }
            }
        }

        private void dataGridViewRoleless_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRoleless.Rows[e.RowIndex];
                string accountName = row.Tag.ToString();
                string tenNhanSu = row.Cells[1].Value.ToString();
                if (accountName != null)
                {
                    //enale decentralization
                    btnAdd.Enabled = true;
                    btnAdd.Image = Properties.Resources.icons8_pencil_23;
                    btnAdd.ForeColor = Color.FromArgb(255, 255, 255);

                    this.accountName = accountName;
                    this.tenNhanSu = tenNhanSu;
                }
            }
        }
    }
}
