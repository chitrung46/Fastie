using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Components.LayoutPersonnel
{
    public partial class LayoutPersonnelForm : UserControl
    {
        private string number;
        private string personnelName;
        private string email;
        private string gender;
        private string dateOfBirth;
        private string dateOfWork;
        private string idPersonnel;
        private string numberPhone;
        private PersonnelForm personnelForm;
        public LayoutPersonnelForm()
        {
            InitializeComponent();
        }
        public LayoutPersonnelForm(PersonnelForm personnelForm)
        {
            InitializeComponent();
            this.personnelForm = personnelForm;
        }
        public string Number
        {
            get { return number; }
            set { number = value; lblNumber.Text = number; }
        }

        public string PersonnelName
        {
            get { return personnelName; }
            set { personnelName = value; lblPersonnelName.Text = personnelName; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; lblEmail.Text = email; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; lblGender.Text = gender; }
        }
        public string DateOfBirth
            {
            get { return dateOfBirth; }
            set { dateOfBirth = value; lblDateOfBirth.Text = dateOfBirth; }
        }
        public string DateOfWork
        {
            get { return dateOfWork; }
            set { dateOfWork = value; lblDateOfWork.Text = dateOfWork; }
        }
        public string IdPersonnel
        {
            get { return idPersonnel; }
            set { idPersonnel = value; }
        }
        public string NumberPhone
        {
            get { return numberPhone; }
            set { numberPhone = value; lblNumberPhone.Text = numberPhone; }
        }
    }
}
