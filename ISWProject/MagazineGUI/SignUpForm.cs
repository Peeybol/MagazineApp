using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazineGUI
{
    public partial class SignUpForm : Form
    {
        private IMagazineISWService service;
        private bool[] areChecked = new bool[8];
        public SignUpForm(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            String id = id_txt.Text; String name = name_txt.Text; String surname = surname_txt.Text;
            String email = email_txt.Text; String user = username_txt.Text; String password = pass_txt.Text;
            String repPass = repPass_txt.Text;
            String areasOfInterest = aof_txt.Text; bool alerted = spam_checkbox.Checked;
            
            try { service.RegisterUser(id, name, surname, alerted, areasOfInterest, email, user, password); this.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Id_txt_TextChanged(object sender, EventArgs e)
        {
            if(id_txt.Text.Length < 1 )
            {
                areChecked[0] = false;
                signUp_button.Enabled = false; 
            } 
            else {
                areChecked[0] = true;
                signUp_button.Enabled = AreAllTrue();
            }
        }

        private void Name_txt_TextChanged(object sender, EventArgs e)
        {
            if (name_txt.Text.Length < 1)
            {
                areChecked[1] = false;
                signUp_button.Enabled = false;
            }
            else
            {
                areChecked[1] = true;
                signUp_button.Enabled = AreAllTrue();
            }
        }

        private void Surname_txt_TextChanged(object sender, EventArgs e)
        {
            if (surname_txt.Text.Length < 1)
            {
                areChecked[2] = false;
                signUp_button.Enabled = false;
            }
            else
            {
                areChecked[2] = true;
                signUp_button.Enabled = AreAllTrue();
            }
        }

        private void Username_txt_TextChanged(object sender, EventArgs e)
        {
            if (username_txt.Text.Length < 1)
            {
                areChecked[3] = false;
                signUp_button.Enabled = false;
            }
            else
            {
                areChecked[3] = true;
                signUp_button.Enabled = AreAllTrue();
            }
        }

        private void Pass_txt_TextChanged(object sender, EventArgs e)
        {
            if (pass_txt.Text.Length < 1)
            {
                areChecked[4] = false;
                signUp_button.Enabled = false;
            }
            else
            {
                areChecked[4] = true;
                signUp_button.Enabled = AreAllTrue();
            }
        }

        private void Aof_txt_TextChanged(object sender, EventArgs e)
        {
            if (aof_txt.Text.Length < 1)
            {
                areChecked[7] = false;
                signUp_button.Enabled = false;
            }
            else
            {
                areChecked[7] = true;
                signUp_button.Enabled = AreAllTrue();

            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool AreAllTrue()
        {
            return !areChecked.Contains(false);
        }

        private void Email_txt_Leave(object sender, EventArgs e)
        {
            if (email_txt.Text.Length < 1 || !service.IsValidEmail(email_txt.Text))
            {
                areChecked[6] = false;
                signUp_button.Enabled = false;
                emailError_label.Visible = true;

            }
            else
            {
                areChecked[6] = true;
                signUp_button.Enabled = AreAllTrue();
                emailError_label.Visible = false;
            }
        }

        private void RepPass_txt_Leave(object sender, EventArgs e)
        {
            if (repPass_txt.Text.Length < 1 || !repPass_txt.Text.Equals(pass_txt.Text))
            {
                areChecked[5] = false;
                signUp_button.Enabled = false;
                passwordError_label.Visible = true;

            }
            else
            {
                areChecked[5] = true;
                signUp_button.Enabled = AreAllTrue();
                passwordError_label.Visible = false;    
            }
        }

        private void PasswordInfoButton_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(this, "- Password must be between 8 and 32 characters\n" +
                                    "- Password must have atleast 1 lowercase letter and 1 uppercase letter\n" +
                                    "- Password must have at least 1 number\n" +
                                    "- Password must have one special character from the set\n{'?', '-', '+', '=', '_', '@', '#', '!', '&','$'}",
                                    "Password info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        private void AreasInterestButton_Click(object sender, EventArgs e)
        {
            StringBuilder areas = new StringBuilder();
            service.ListAllAreas().ForEach(a => areas.Append(a.Name+"\n"));
            DialogResult answer = MessageBox.Show(this, "Introduce your areas of interest, separated by comas (,) from this list:\n" +
                                                        areas.ToString(), "AreasInfo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

    }
}
