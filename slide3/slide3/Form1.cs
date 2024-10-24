using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_me_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Chào em, anh đứng đợi nãy dờ",
                "Tin nhắn",
                MessageBoxButtons.YesNo
            );
            {
                Close();
            } else
            {
                MessageBox.Show(
                    "Nói yêu đi",
                    "hehe"

           
                );
            }
        }
    }
}
