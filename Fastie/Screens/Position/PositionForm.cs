﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.PermissionBLL;
using DTO;
using Fastie.Components.LayoutDecentralization;
using Fastie.Components.LayoutDepartment;
using Fastie.Components.LayoutRole;
namespace Fastie
{
    public partial class PositionForm : Form
    {
        PositionBLL positionBLL = new PositionBLL();
        PermissionBLL permissionBLL = new PermissionBLL();
        private string idTaiKhoan;
        private string idChucVu;
        public PositionForm(string idTaiKhoan, string idChucVu)
        {
            InitializeComponent();
            this.idTaiKhoan = idTaiKhoan;
            this.idChucVu = idChucVu;
        }

        public string IdTaiKhoan { get => idTaiKhoan; set => idTaiKhoan = value; }
        public string IdChucVu { get => idChucVu; set => idChucVu = value; }

        private void customButton3_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            CreatePositionForm createPositionForm = new CreatePositionForm(this);
            createPositionForm.Show();
        }


        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            loadDataPosition();
        }

        public void LoadDataPosition()
        {
            loadDataPosition();
        }

        private void loadDataPosition() 
        {
            flowLayoutPanelPosition.Controls.Clear();
            List<Position> positionList = positionBLL.GetPositionList();
            int i = 0;
            foreach (Position position in positionList)
            {
                var layoutPositionForms = new LayoutPositionForm(this)
                {
                    Number = (i + 1).ToString(),
                    NamePosition = position.Ten,
                    DecriptionPosition = position.MoTa + "Mô tả",
                    IdPosition = position.Id
                };
                flowLayoutPanelPosition.Controls.Add(layoutPositionForms);
                i++;
            }
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            bool checckPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0011"); 
            if(checckPermission)
            {
                CreatePositionForm createPositionForm = new CreatePositionForm(this);
                createPositionForm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thêm chức vụ", "Thông báo");
            }
        }
    }
}


