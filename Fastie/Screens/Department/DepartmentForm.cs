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
using DAL;
using DTO;
using Fastie.Components.LayoutDepartmen;
using Fastie.Components.LayoutDepartment;
using GUI.TruniControls;
namespace Fastie
{
    public partial class DepartmentForm : Form
    {
        DepartmentBLL departmentBLL = new DepartmentBLL();
        public DepartmentForm()
        {
            InitializeComponent();

        }
        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            loadDataDepartment();
        }
        public void LoadDataDepartment()
        {
            loadDataDepartment();
        }

        private void loadDataDepartment()
        {
            flowLayoutPanelDepartment.Controls.Clear();
            List<Department> departmentList = departmentBLL.GetDepartmentList();
            int i = 0;
            foreach (Department department in departmentList)
            {
                var layoutDepartmentForm = new LayoutDepartmentForm(this)
                {
                    Number = (i + 1).ToString(),
                    NameDepartment = department.Ten,
                    Description = department.MoTa,
                    IdDepartment = department.Id
                };
                flowLayoutPanelDepartment.Controls.Add(layoutDepartmentForm);
                i++;
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            CreateDepartmentForm createDepartmentForm = new CreateDepartmentForm(this);
            createDepartmentForm.Show();
        }
    }
}
