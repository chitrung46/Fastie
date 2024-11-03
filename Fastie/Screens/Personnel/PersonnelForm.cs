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
using BLL.DepartmentBLL;
using DTO;
using Fastie.Components.LayoutDepartmen;
using Fastie.Components.LayoutPersonnel;
namespace Fastie
{
    public partial class PersonnelForm : Form
    {
        PersonnelBLL personnelBLL = new PersonnelBLL();
        public PersonnelForm()
        {
            InitializeComponent();
            LoadPersonnelData();
        }
        public void LoadPersonnelData()
        {
            List<Personnel> personnelList = personnelBLL.GetPersonnelList();
            dgvPosition.Rows.Clear();
            foreach (Personnel personnel in personnelList)
            {
                dgvPosition.Rows.Add(personnel.Id, personnel.Ten, personnel.Email, personnel.GioiTinh, personnel.NgaySinh, personnel.NgayVaoLam, personnel.Sdt);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            CreatePersonnelForm createPersonnelForm = new CreatePersonnelForm();
            createPersonnelForm.Show();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            if (dgvPosition.SelectedRows.Count > 0) // Ensure a row is selected
            {
                // Get the selected row
                var selectedRow = dgvPosition.SelectedRows[0];
                if (selectedRow.Cells["id"].Value == null || string.IsNullOrWhiteSpace(selectedRow.Cells["id"].Value.ToString()))
                {
                    MessageBox.Show("Ô dữ liệu này trống. Vui lòng chọn một chức vụ có dữ liệu hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var updatePersonnel = new Personnel
                    {
                        Id = selectedRow.Cells["iD"].Value.ToString(),
                        Ten = selectedRow.Cells["tenNhanSu"].Value.ToString(),
                        Email = selectedRow.Cells["email"].Value.ToString(),
                        GioiTinh = selectedRow.Cells["gioiTinh"].Value.ToString(),
                        NgaySinh = ((DateTime)selectedRow.Cells["ngaySinh"].Value).Date,
                        NgayVaoLam = ((DateTime)selectedRow.Cells["ngayVaoLam"].Value).Date,
                        Sdt = selectedRow.Cells["sdt"].Value.ToString()

                    };
                    UpdatePersonnelForm updatePersonnelForm = new UpdatePersonnelForm(this, updatePersonnel);
                    updatePersonnelForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức vụ để cập nhật");
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (dgvPosition.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPosition.SelectedRows[0];
                if (selectedRow.Cells["ID"].Value == null || string.IsNullOrWhiteSpace(selectedRow.Cells["ID"].Value.ToString()))
                {
                    MessageBox.Show("Ô dữ liệu này trống. Vui lòng chọn một chức vụ có dữ liệu hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string id = selectedRow.Cells["ID"].Value.ToString();
                        personnelBLL.DeletePersonnel(id);
                        dgvPosition.Rows.RemoveAt(selectedRow.Index);
                        MessageBox.Show("Xóa nhân sự thành công!", "Success");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chức vụ để xóa.");
            }
        }

        private void PersonnelForm_Load(object sender, EventArgs e)
        {
            loadDataPersonnel();
        }

        private void loadDataPersonnel ()
        {
            flowLayoutPanelPersonnel.Controls.Clear();
            List<Personnel> departmentList = personnelBLL.GetPersonnelList();
            int i = 0;
            foreach (Personnel department in departmentList)
            {
                var layoutPersonnelForm = new LayoutPersonnelForm(this)
                {
                    Number = (i + 1).ToString(),
                    PersonnelName = department.Ten,
                    Email = department.Email,
                    Gender = department.GioiTinh,
                    DateOfBirth = department.NgaySinh.ToString(),
                    DateOfWork = department.NgayVaoLam.ToString(),
                    IdPersonnel = department.Id,
                    NumberPhone = department.Sdt
                };
                flowLayoutPanelPersonnel.Controls.Add(layoutPersonnelForm);
                i++;
            }
        }

        private void btnAddPersonnel_Click(object sender, EventArgs e)
        {
            CreatePersonnelForm createPersonnelForm = new CreatePersonnelForm();
            createPersonnelForm.Show();
        }
    }
}
