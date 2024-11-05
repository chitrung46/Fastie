using BLL;
using BLL.PermissionBLL;
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

namespace Fastie.Components.LayoutDepartment
{
    public partial class LayoutPositionForm : UserControl
    {
        private string number;
        private string namePosition;
        private string decriptionPosition;
        private string idPosition;
        private PositionForm positionForm;
        PermissionBLL permissionBLL = new PermissionBLL();  
        public LayoutPositionForm()
        {
            InitializeComponent();
        }

        public LayoutPositionForm(PositionForm positionForm)
        {
            InitializeComponent();
            this.positionForm = positionForm;
        }

        public string NamePosition
        {
            get { return namePosition; }
            set { namePosition = value; lblPositionName.Text = namePosition; }
        }
        public string DecriptionPosition
            {
            get { return decriptionPosition; }
            set { decriptionPosition = value; lblDescription.Text = decriptionPosition; }
        }
        public string IdPosition
        {
            get { return idPosition; }
            set { idPosition = value; }
        }
        public string Number
        {
            get { return number; }
            set { number = value; lblNumber.Text = number; }
        }


        public void LoadPositionData()
        {
            positionForm.LoadDataPosition();
        }

        private void btnEditPosition_Click(object sender, EventArgs e)
        {
            bool checkPermission = permissionBLL.checkPermission(positionForm.IdTaiKhoan, "Q0012");
            if(checkPermission)
            {
                var updatePosition = new Position
                {
                    Id = this.idPosition,
                    Ten = this.namePosition,
                    MoTa = this.decriptionPosition

                };
                UpdatePositionForm updatePositionForm = new UpdatePositionForm(this, updatePosition);
                updatePositionForm.Show();
            } else
            {
                MessageBox.Show("Bạn không có quyền sửa chức vụ", "Thông báo"); 
            }
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            bool checkPermission = permissionBLL.checkPermission(positionForm.IdTaiKhoan, "Q0013");
            if(checkPermission)
            {
                string[] information = { "Bạn có chắc chắn xóa chức vụ này?", $"{this.namePosition} sẽ mất toàn bộ quyền trong hệ thống", "Xóa chức vụ" };
                LayoutConfirmForm deleteLayoutConfirm = new LayoutConfirmForm(this, this.idPosition);
                deleteLayoutConfirm.Title = information[0];
                deleteLayoutConfirm.Content = information[1];
                deleteLayoutConfirm.btnConfirmText = information[2];
                deleteLayoutConfirm.Show();
            } else
            {
                MessageBox.Show("Bạn không có quyền xóa chức vụ", "Thông báo");
            }
        }
    }
}
