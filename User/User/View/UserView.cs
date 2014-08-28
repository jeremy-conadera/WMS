using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace User
{
    public partial class UserForm : Form, User.Controller.IUserView
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

        public string FirstName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string LastName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        internal User.Controller.UserController UserController
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
