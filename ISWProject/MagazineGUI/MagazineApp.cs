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
    public partial class MagazineApp : Form
    {
        private IMagazineISWService service;
        public MagazineApp(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                service.Login(usernameBox.Text, passwordBox.Text);
            }
            catch(Exception) 
            {
                errorLabel.Text = "Login Failed: Username or password incorrect";
                errorLabel.Visible = true;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUp = new SignUpForm(service);
            signUp.FormClosed += (s, args) => this.Show();
            signUp.Show();
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordBox.Text.Length > 0 && usernameBox.Text.Length > 0)
            {
                loginButton.Enabled = true;
            }
            else loginButton.Enabled = false;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if(passwordBox.Text.Length > 0 && usernameBox.Text.Length > 0) 
            {
                loginButton.Enabled = true;
            }
            else loginButton.Enabled = false;
        }
    }
}
