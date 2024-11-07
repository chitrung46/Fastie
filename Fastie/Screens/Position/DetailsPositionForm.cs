using Fastie.Components.LayoutDepartment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Screens.Position
{
    public partial class DetailsPositionForm : Form
    {
        private LayoutPositionForm layoutPositionForm;
        public DetailsPositionForm(LayoutPositionForm layoutPosition)
        {
            InitializeComponent();
            this.layoutPositionForm = layoutPosition;
        }

        private void DetailsPositionForm_Load(object sender, EventArgs e)
        {
            lblPositionName.Text = layoutPositionForm.NamePosition;
            lblPositionContent.Text = layoutPositionForm.DecriptionPosition;
        }
    }
}
