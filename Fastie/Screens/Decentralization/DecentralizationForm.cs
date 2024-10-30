using Fastie.Screen.Decentralization;
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
        public DecentralizationForm()
        {
            InitializeComponent();
        }

        private void Decentralization_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateDecentralizationForm createDecentralization = new CreateDecentralizationForm();
            createDecentralization.Show();
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] information = { "Bạn có chắc chắn xóa mục này không?", "Xóa mục này sẽ không thể khôi phục lại dữ liệu", "Xóa" };
            LayoutConfirmForm deleteLayoutConfirm = new LayoutConfirmForm();
            deleteLayoutConfirm.Title = information[0];
            deleteLayoutConfirm.Content = information[1];
            deleteLayoutConfirm.btnConfirmText = information[2];
            deleteLayoutConfirm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDecentralizationForm updateDecentralization = new UpdateDecentralizationForm();
            updateDecentralization.Show();

        }
    }
}
