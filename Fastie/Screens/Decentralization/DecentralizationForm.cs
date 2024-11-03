using BLL;
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

namespace Fastie
{
    public partial class DecentralizationForm : Form
    {
        DecentralizationBLL decentralizationBLL = new DecentralizationBLL();
        private string accountName;
        private string tenNhanSu;
        private bool isLoaded = false;

        private string selectedDepartmentId;
        private string selectedPositionId;

        public DecentralizationForm()
        {
            InitializeComponent();
        }

        public DecentralizationForm(string accountName)
        {
            InitializeComponent();
            this.accountName = accountName;
        }
        private void Decentralization_Load(object sender, EventArgs e)
        {
            isLoaded = false;

            //loadData();
            loadDataDepartmentList();
            loadDataPositionList();
            showByPositionIdAndDepartmentId();

            isLoaded = true;
        }

        public string AccountName { get => accountName; set => accountName = value; }
        public string TenNhanSu { get => tenNhanSu; set => tenNhanSu = value; }

        public void loadData()
        {
            showByPositionIdAndDepartmentId();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*UpdateDecentralizationForm createDecentralization = new UpdateDecentralizationForm(this, this.accountName);
            createDecentralization.OnFormClosing += () =>
            {
                Unable decentralization
                btnAdd.Enabled = false;
                btnAdd.Image = Properties.Resources.icons8_pencil_23_black;
                btnAdd.ForeColor = Color.FromArgb(0, 0, 0);

                Unable delete
                btnDelete.Enabled = false;
                btnDelete.Image = Properties.Resources.icons8_delete_23_black;
                btnDelete.ForeColor = Color.FromArgb(0, 0, 0);

            };
            createDecentralization.Show();
            */

        } //Đang test lại

        //Disable button Delete and Add after deleting
        public void DisableDeleteAndAdd()
        {

           disableDeleteAndAdd();
        }
        private void disableDeleteAndAdd()
        {

           //Unable decentralization
            btnAdd.Enabled = false;
            btnAdd.Image = Properties.Resources.icons8_pencil_23_black;
            btnAdd.ForeColor = Color.FromArgb(0, 0, 0);

            //Unable delete
            btnDelete.Enabled = false;
            btnDelete.Image = Properties.Resources.icons8_delete_23_black;
            btnDelete.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*string[] information = { "Bạn có chắc chắn xóa toàn bộ quyền?", $"{this.tenNhanSu} sẽ mất toàn bộ quyền trong hệ thống", "Xóa quyền" };
            LayoutConfirmForm deleteLayoutConfirm = new LayoutConfirmForm(this, this.accountName);
            deleteLayoutConfirm.Title = information[0];
            deleteLayoutConfirm.Content = information[1];
            deleteLayoutConfirm.btnConfirmText = information[2];
            deleteLayoutConfirm.Show();*/
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //UpdateDecentralizationForm updateDecentralization = new UpdateDecentralizationForm(this, this.accountName);
            //updateDecentralization.Show();

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
        private void cbDepartment_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(isLoaded)
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

        private void loadDataFormat(DataGridView dataGridView, List<AccountInfo> accountInfo)
        {

            dataGridView.Rows.Clear();
            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add("soThuTu", "STT");
                dataGridView.Columns.Add("tenNhanSu", "Tên Nhân Sự");
                dataGridView.Columns.Add("tenBoPhan", "Tên Bộ Phận");
                dataGridView.Columns.Add("tenChucVu", "Tên Chức Vụ");
            }
            if (accountInfo != null)
            {
                int count = 1;
                foreach (AccountInfo account in accountInfo)
                {
                    DataGridViewRow rows = new DataGridViewRow();
                    rows.CreateCells(dataGridView);
                    rows.Cells[0].Value = count++;
                    rows.Cells[1].Value = account.TenNhanSu;
                    rows.Cells[2].Value = account.TenBoPhan;
                    rows.Cells[3].Value = account.TenChucVu;
                    rows.Tag = account.TenDangNhap;
                    dataGridView.Rows.Add(rows);
                }
            }
        }

        private void showByPositionIdAndDepartmentId()
        {
            if(selectedDepartmentId != null && selectedPositionId != null)
            {
                List<AccountInfo> accountInfo = decentralizationBLL.getListByDepartmentIdAndPositionId(this.selectedDepartmentId, this.selectedPositionId);
                loadDataFormat(dataGridViewPersonnel, accountInfo);

                List<AccountInfo> accountInfoRoleless = decentralizationBLL.getListByDepartmentIdAndPositionIdRoleLess(this.selectedDepartmentId, this.selectedPositionId);
                loadDataFormat(dataGridViewRoleless, accountInfoRoleless);

            }
            else if(selectedDepartmentId != null && selectedPositionId == null)
            {
                List <AccountInfo> accountInfo = decentralizationBLL.getDepartmentListwithAllPosition(this.selectedDepartmentId);
                loadDataFormat(dataGridViewPersonnel, accountInfo);

                List<AccountInfo> accountInfoRoleless = decentralizationBLL.getDepartmentListwithAllPositionRoleLess(this.selectedDepartmentId);
                loadDataFormat(dataGridViewRoleless, accountInfoRoleless);

            } else if (selectedDepartmentId == null && selectedPositionId != null)
            {
                List<AccountInfo> accountInfo = decentralizationBLL.getPositionListwithAllDepartment(this.selectedPositionId);
                loadDataFormat(dataGridViewPersonnel, accountInfo);

                List<AccountInfo> accountInfoRoleless = decentralizationBLL.getPositionListwithAllDepartmentRoleLess(this.selectedPositionId);
                loadDataFormat(dataGridViewRoleless, accountInfoRoleless);
            } else
            {
                List<AccountInfo> accountInfoPersonnel = decentralizationBLL.getAllAccountInfo();
                loadDataFormat(dataGridViewPersonnel, accountInfoPersonnel);

                List<AccountInfo> accountInfoRoleless = decentralizationBLL.getAllPersonnelRoleLess();
                loadDataFormat(dataGridViewRoleless, accountInfoRoleless);
            }
        }
    }
}
