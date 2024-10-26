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
    public partial class Decentralization : Form
    {
        public Decentralization()
        {
            InitializeComponent();
        }

        private void Decentralization_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateDecentralization createDecentralization = new CreateDecentralization();
            createDecentralization.Show();
                
        }
    }
}
