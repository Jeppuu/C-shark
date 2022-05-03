using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudyPoint
{
    public partial class StudyPointForm : Form
    {
        // connect to USER class
        USER user = new USER(); 
        public StudyPointForm()
        {
            InitializeComponent();
        }
        //
        // REGISTER PANEL
        //
        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ProfilepicTxb.Text = openFileDialog1.SafeFileName;
            }
        }
        //
        // Empty the textboxes on focus if they have default value (haven't been filled out)
        // And keep the default value on unfocus if the text wasn't changed
        //
        private void FirstnameTxb_Enter(object sender, EventArgs e)
        {
            if(FirstnameTxb.Text == "First name")
            {
                FirstnameTxb.Text = "";
            }
        }

        private void FirstnameTxb_Leave(object sender, EventArgs e)
        {
            if(FirstnameTxb.Text == "")
            {
                FirstnameTxb.Text = "First name";
            }
        }

        private void LastNameTxb_Enter(object sender, EventArgs e)
        {
            if (LastNameTxb.Text == "Last name")
            {
                LastNameTxb.Text = "";
            }
        }

        private void LastNameTxb_Leave(object sender, EventArgs e)
        {
            if (LastNameTxb.Text == "")
            {
                LastNameTxb.Text = "Last name";
            }
        }

        private void OccupationTxb_Enter(object sender, EventArgs e)
        {
            if (OccupationTxb.Text == "Occupation")
            {
                OccupationTxb.Text = "";
            }
        }

        private void OccupationTxb_Leave(object sender, EventArgs e)
        {
            if (OccupationTxb.Text == "")
            {
                OccupationTxb.Text = "Occupation";
            }
        }

        private void MobileTxb_Enter(object sender, EventArgs e)
        {
            if (MobileTxb.Text == "Mobile number")
            {
                MobileTxb.Text = "";
            }
        }

        private void MobileTxb_Leave(object sender, EventArgs e)
        {
            if (MobileTxb.Text == "")
            {
                MobileTxb.Text = "Mobile number";
            }
        }

        private void EmailRegisterTxb_Enter(object sender, EventArgs e)
        {
            if (EmailRegisterTxb.Text == "Email")
            {
                EmailRegisterTxb.Text = "";
            }
        }

        private void EmailRegisterTxb_Leave(object sender, EventArgs e)
        {
            if (EmailRegisterTxb.Text == "")
            {
                EmailRegisterTxb.Text = "Email";
            }
        }

        private void PasswordRegTxb_Enter(object sender, EventArgs e)
        {
            if (PasswordRegTxb.Text == "Password")
            {
                PasswordRegTxb.Text = "";
            }
        }

        private void PasswordRegTxb_Leave(object sender, EventArgs e)
        {
            if (PasswordRegTxb.Text == "")
            {
                PasswordRegTxb.Text = "Password";
            }
        }

        private void ConfirmPswdTxb_Enter(object sender, EventArgs e)
        {
            if (ConfirmPswdTxb.Text == "Confirm password")
            {
                ConfirmPswdTxb.Text = "";
            }
        }

        private void ConfirmPswdTxb_Leave(object sender, EventArgs e)
        {
            if (ConfirmPswdTxb.Text == "")
            {
                ConfirmPswdTxb.Text = "Password";
            }
        }
        //
        // Register a new user to MySql database
        //
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            String fname = FirstnameTxb.Text;
            String lname = LastNameTxb.Text;
            String occupation = OccupationTxb.Text;
            String mobile = MobileTxb.Text;
            String email = EmailRegisterTxb.Text;
            String password = PasswordRegTxb.Text;
            String confirmPswd = ConfirmPswdTxb.Text;
            String profilePic = openFileDialog1.FileName;

            if (fname.Trim().Equals("") || fname.Trim().Equals("First name") || lname.Trim().Equals("") || lname.Trim().Equals("Last name") 
                || occupation.Trim().Equals("") || occupation.Trim().Equals("Occupation") || mobile.Trim().Equals("") || mobile.Trim().Equals("Mobile number") 
                || email.Trim().Equals("") || email.Trim().Equals("Email") || password.Trim().Equals("") || password.Trim().Equals("Password"))
            {
                ErrorLbl.Visible = true;

            }
            else if (confirmPswd != password)
            {
                ErrorLbl.Visible = true;
                ErrorLbl.Text = "Passwords do not match!";
            }
            else
            {
                Boolean registerUser = user.RegisterUser(fname, lname, occupation, mobile, email, password, profilePic);
                if (registerUser)
                {
                    MessageBox.Show("Register successfull! Proceed to log in.", "Registration successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginPanel.Visible = true;
                    RegisterPanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Failed to register! Please try again!", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //
        // LOGIN PANEL
        //
        private void RegisterHereLbl_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = true;
            LoginPanel.Visible = false;
        }
    }
}
