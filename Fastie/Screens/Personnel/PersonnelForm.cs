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
using DTO;
using Fastie.Components.LayoutDepartment;
using Fastie.Components.LayoutPersonnel;
namespace Fastie
{
    public partial class PersonnelForm : Form
    {
        PersonnelBLL personnelBLL = new PersonnelBLL();
        public PersonnelForm()
        {
            InitializeComponent();
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

        private void PersonnelForm_Load(object sender, EventArgs e)
        {
            LoadDataPersonnel();
        }

        public void LoadDataPersonnel() 
        {
            loadDataPersonnel();
        }
        private void loadDataPersonnel ()
        {
            flowLayoutPanelPersonnel.Controls.Clear();
            List<Personnel> personnelList = personnelBLL.GetPersonnelList();
            int i = 0;
            foreach (Personnel personnel in personnelList)
            {
                var layoutPersonnelForm = new LayoutPersonnelForm(this)
                {
                    Number = (i + 1).ToString(),
                    PersonnelName = personnel.Ten,
                    Email = personnel.Email,
                    Gender = personnel.GioiTinh,
                    DateOfBirth = personnel.NgaySinh,
                    DateOfWork = personnel.NgayVaoLam,
                    IdPersonnel = personnel.Id,
                    NumberPhone = personnel.Sdt
                };
                flowLayoutPanelPersonnel.Controls.Add(layoutPersonnelForm);
                i++;
            }
        }

        private void btnAddPersonnel_Click(object sender, EventArgs e)
        {
            CreatePersonnelForm createPersonnelForm = new CreatePersonnelForm(this);
            createPersonnelForm.Show();
        }
    }
}
