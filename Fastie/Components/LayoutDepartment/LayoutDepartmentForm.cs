﻿using BLL.DepartmentBLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Components.LayoutDepartmen
{
    public partial class LayoutDepartmentForm : UserControl
    {
        private string number;
        private string nameDepartment;
        private string description;
        private string idDepartment;
        private DepartmentForm departmentForm;
        public LayoutDepartmentForm()
        {
            InitializeComponent();
        }
        public LayoutDepartmentForm(DepartmentForm departmentForm)
        {
            InitializeComponent();
            this.departmentForm = departmentForm;
        }
        public string Number
        {
            get { return number; }
            set { number = value; lblNumber.Text = number; }
        }
        public string NameDepartment
            {
            get { return nameDepartment; }
            set { nameDepartment = value; lblDepartmentName.Text = nameDepartment; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; lblDescription.Text = description; }
        }
        public string IdDepartment
        {
            get { return idDepartment; }
            set { idDepartment = value; }
        }

        public void loadDataDepartment()
        {
            departmentForm.LoadDataDepartment();
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            var updateDepartment = new Department
            {
                Id = this.idDepartment,
                Ten = this.nameDepartment,
                MoTa = this.description
            };
            UpdateDepartmentForm updateDepartmentForm = new UpdateDepartmentForm(this, updateDepartment);
            updateDepartmentForm.Show();
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            string[] information = { "Bạn có chắc chắn xóa bộ phận này?", $"{this.nameDepartment} sẽ được xóa khỏi hệ thống", "Xóa bộ phận" };
            LayoutConfirmForm deleteLayoutConfirm = new LayoutConfirmForm(this, this.idDepartment);
            deleteLayoutConfirm.Title = information[0];
            deleteLayoutConfirm.Content = information[1];
            deleteLayoutConfirm.btnConfirmText = information[2];
            deleteLayoutConfirm.Show();
        }
    }
}
