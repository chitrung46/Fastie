﻿using DTO;
using BLL;
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
    public partial class CreateDepartmentForm : Form
    {
        DepartmentBLL departmentBLL = new DepartmentBLL();
        DepartmentForm departmentForm ;

        public CreateDepartmentForm(DepartmentForm departmentForm)
        {
            InitializeComponent();
            this.departmentForm= departmentForm;    
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Department newBoPhan = new Department
                {
                    Ten = cTBName.Text,
                    MoTa = cTBDescribe.Text
                };
                departmentBLL.InsertDepartmentBLL(newBoPhan);
                MessageBox.Show("Thêm Bộ phận mới thành công!", "Success");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            departmentForm.LoadDepartmentData();
            this.Close();
            
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
