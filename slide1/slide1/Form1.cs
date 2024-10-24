using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum;
            sum = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            lblOutput.Text = txtA.Text + " + " + txtB.Text + " = " + sum.ToString();
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            int minus;
            minus = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            lblOutput.Text = txtA.Text + " - " + txtB.Text + " = " + minus.ToString();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if(txtA.Text != null)
            {
                txtA.Text = "";
            }if (txtB.Text != null)
            {
                txtB.Text = "";
            }
             txtA.Text = txtB.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
