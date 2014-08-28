using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMSwithRFID.Domain_Classes;
using WMSwithRFID.Add_Forms;
using WMSwithRFID.UpdateDeleteForms;

namespace WMSwithRFID
{
    public partial class AddUserForm : Form
    {
        private User user;
        public AddUserForm()
        {
            InitializeComponent();
            user = new User();
        }
        public void ClearFields()
        {
            this.usernameTB.Clear();
            this.passwordTB.Clear();
            this.firstNameTB.Clear();
            this.middleNameTB.Clear();
            this.lastNameTB.Clear();
            this.accountTypeCB.SelectedIndex = -1;
            this.companyPositionTB.Clear();
            this.contactNumberTB.Clear();
            this.eMailTB.Clear();
            this.suffixTB.Clear();
            this.addressTB.Clear();
        }

        private void addUserBackBtn_Click(object sender, EventArgs e)
        {
            UserUpdateDeleteForm update = new UserUpdateDeleteForm();
            update.getUserDetails();
            Close();
        }

        private void addUserAddBtn_Click(object sender, EventArgs e)
        {
            WMScontext ctx = WMScontext.Instance;
            
            
                user.Username = usernameTB.Text;
                user.Password = new User().passwordMD5(passwordTB.Text);
                user.AccountType = (AccountType)Enum.Parse(typeof(AccountType), accountTypeCB.SelectedItem.ToString());
                user.CompanyPosition = companyPositionTB.Text;
                user.FirstName = firstNameTB.Text;
                user.MiddleName = middleNameTB.Text;
                user.LastName = lastNameTB.Text;
                user.Suffix = suffixTB.Text;
                user.Email = eMailTB.Text;
                user.ContactNumber = contactNumberTB.Text;
                user.Address = addressTB.Text;
           
            ctx.Users.Add(user);
            ctx.SaveChanges();
            ClearFields();
            MessageBox.Show("You have successfully added " + firstNameTB.Text + " to the list of users.", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
