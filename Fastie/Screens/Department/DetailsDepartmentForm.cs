using Fastie.Components.LayoutDepartmen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Screens.Department
{
    public partial class DetailsDepartmentForm : Form
    {
        private LayoutDepartmentForm layoutDepartment;
        public DetailsDepartmentForm(LayoutDepartmentForm layoutDepartment)
        {
            InitializeComponent();
            this.layoutDepartment = layoutDepartment;
        }

        private void DetailsDepartmentForm_Load(object sender, EventArgs e)
        {
            lblDepartmentName.Text = layoutDepartment.NameDepartment;
            lblDepartmentContent.Text = layoutDepartment.Description;
        }
    }
}
