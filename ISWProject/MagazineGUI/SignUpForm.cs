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
        public SignUpForm(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            String id = id_txt.Text; String name = name_txt.Text; String surname = surname_txt.Text;
            String email = email_txt.Text; String user = username_txt.Text; String password = pass_txt.Text;
            String repPass = repPass_txt.Text;
            String areasOfInterest = aof_txt.Text; Boolean alerted = spam_checkbox.Checked;

            /*if(!repPass.Equals(password)) { signUp_button.Enabled = false; }
            else { signUp_button.Enabled = true; }*/

            service.RegisterUser(id, name, surname, alerted, areasOfInterest, email, user, password);
        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {
            if(id_txt.Text.Length < 1 ) { signUp_button.Enabled = false; } 
            else { signUp_button.Enabled=true; }
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            if (name_txt.Text.Length < 1) { signUp_button.Enabled = false; }
            else { signUp_button.Enabled = true; }
        }

        private void surname_txt_TextChanged(object sender, EventArgs e)
        {
            if (surname_txt.Text.Length < 1) { signUp_button.Enabled = false; }
            else { signUp_button.Enabled = true; }
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {
            if (username_txt.Text.Length < 1) { signUp_button.Enabled = false; }
            else { signUp_button.Enabled = true; }
        }

        private void pass_txt_TextChanged(object sender, EventArgs e)
        {
            if (pass_txt.Text.Length < 1) { signUp_button.Enabled = false; }
            else { signUp_button.Enabled = true; }
        }

        private void repPass_txt_TextChanged(object sender, EventArgs e)
        {
            if (repPass_txt.Text.Length < 1) { signUp_button.Enabled = false; }
            else { signUp_button.Enabled = true; }
        }

        private void email_txt_TextChanged(object sender, EventArgs e)
        {
            if (email_txt.Text.Length < 1) { signUp_button.Enabled = false; }
            else { signUp_button.Enabled = true; }
        }

        private void aof_txt_TextChanged(object sender, EventArgs e)
        {
            if (aof_txt.Text.Length < 1) { signUp_button.Enabled = false; }
            else { signUp_button.Enabled = true; }
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
