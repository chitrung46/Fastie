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
namespace Fastie
{
    public partial class PersonnelForm : Form
    {
        CRUDPersonnelBLL nhanSuBLL = new CRUDPersonnelBLL();
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

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            CreatePersonnelForm createPersonnelForm = new CreatePersonnelForm();
            createPersonnelForm.Show();
        }
    }
}
