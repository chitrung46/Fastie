﻿using System;
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
    public partial class CreatePersonnelForm : Form
    {
        public CreatePersonnelForm()
        {
            InitializeComponent();
            // Thiết lập định dạng cho DateTimePicker trong form
            dTPBirthday.Format = DateTimePickerFormat.Custom;
            dTPBirthday.CustomFormat = "dd/MM/yyyy";
            // Thiết lập định dạng cho DateTimePicker trong form
            dTPDayOfWork.Format = DateTimePickerFormat.Custom;
            dTPDayOfWork.CustomFormat = "dd/MM/yyyy";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreatePersonnel_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customComboBox1_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void customTextBox2_Load(object sender, EventArgs e)
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void customComboBox1_OnSelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void dTPBirtday_ValueChanged(object sender, EventArgs e)
        {
           
        }

    }
}
