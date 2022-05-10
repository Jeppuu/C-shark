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

        private void StudyPointForm_Load(object sender, EventArgs e)
        {
            // FOR TESTING PURPOSES
            HomePanel.Visible = true;
            //

            // load data to discussion board
            DiscussionPostsDgv.DataSource = user.FetchQuestions();
            DiscussionPostsDgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 150;
            //adjust the column width
            DataGridViewColumn column = DiscussionPostsDgv.Columns[0];
            column.Width = 420;
            DataGridViewColumn column2 = DiscussionPostsDgv.Columns[1];
            column2.Width = 150;
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
            if (FirstnameTxb.Text == "First name")
            {
                FirstnameTxb.Text = "";
            }
        }

        private void FirstnameTxb_Leave(object sender, EventArgs e)
        {
            if (FirstnameTxb.Text == "")
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

        //open register panel from the clicking the label
        private void RegisterHereLbl_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = true;
            LoginPanel.Visible = false;
        }
        // check if email and password match with MySQL database
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String email = EmailTxb.Text;
            String password = PasswordTxb.Text;

            ValidateLogin(email, password);
        }
        // function for validating the log in creditentials
        public void ValidateLogin(string email, string password)
        {

            YHDISTA yhteys = new YHDISTA();
            string str;

            str = ("SELECT * FROM register_user WHERE email ='" + email + "' And Password='" + password + "'");
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = str;
            cmd.Connection = yhteys.OtaYhteys();

            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);

            if (dt.Rows.Count > 0) //log in succeeded, open home panel
            {
                HomePanel.Visible = true;
                LoginPanel.Visible = false;
            }
            else //log in failed, show error message
            {
                LoginErrorLbl.Visible = true;
            }

        }

        //
        // HOME PANEL
        //

        //Log out button
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            //logged out successfully, open login panel
            MessageBox.Show("You have logged out successfully!", "Log out successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginPanel.Visible = true;
            HomePanel.Visible = false;
        }

        

        // show about us -page on button click
        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutPanel.Visible = true;
            HomePanel.Visible = false;
        }

        // show discussion board on button click
        private void DiscussionBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            DiscussionBoardPanel.Visible = true;
        }

        //
        // ABOUT US PANEL
        //

        // return to home page from about us -page
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            AboutPanel.Visible = false;
            HomePanel.Visible = true;
        }

        // return to about us -page from contact us -page
        private void ReturnFromContactBtn_Click(object sender, EventArgs e)
        {
            ContactUsPanel.Visible = false;
            AboutPanel.Visible = true;
        }

        // return to about us -page from our department -page
        private void ReturnFromDepartmentBtn_Click(object sender, EventArgs e)
        {
            OurDepartmentPanel.Visible = false;
            AboutPanel.Visible = true;
        }

        //contac us label takes to contact us -page
        private void label14_Click(object sender, EventArgs e)
        {
            AboutPanel.Visible = false;
            ContactUsPanel.Visible = true;

        }

        // more info of our department label takes to our department -page
        private void label15_Click(object sender, EventArgs e)
        {
            AboutPanel.Visible = false;
            OurDepartmentPanel.Visible = true;
        }

        //
        // DISCUSSION FORUM
        //

        // clear the post textbox on focus
        private void NewPostTxb_Enter(object sender, EventArgs e)
        {
            if (NewPostTxb.Text == "Write a post...")
            {
                NewPostTxb.Text = "";
            }
        }
        //write the instructions again if nothing was written
        private void NewPostTxb_Leave(object sender, EventArgs e)
        {
            if (NewPostTxb.Text == "")
            {
                NewPostTxb.Text = "Write a post...";
            }
        }

        // post the question to database
        private void MakePostBtn_Click(object sender, EventArgs e)
        {
            String question = NewPostTxb.Text;
            DateTime date = System.DateTime.Now;


            if (question.Trim().Equals(""))
            {
                PostErrorLbl.Visible = true;

            }

            else
            {
                Boolean PostQuestion = user.PostQuestion(question,date);
                if (PostQuestion)
                {
                    MessageBox.Show("Question posted!", "Post successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to post question! Please try again!", "Posting failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // load new posted data to discussion board
            DiscussionPostsDgv.DataSource = user.FetchQuestions();
            DiscussionPostsDgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 150;
            //adjust the column width
            DataGridViewColumn column = DiscussionPostsDgv.Columns[0];
            column.Width = 420;
            DataGridViewColumn column2 = DiscussionPostsDgv.Columns[1];
            column2.Width = 150;
        }
        // return to home page from discussion board
        private void ReturnFromDiscussion_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = true;
            DiscussionBoardPanel.Visible = false;
        }

       
    }
}
