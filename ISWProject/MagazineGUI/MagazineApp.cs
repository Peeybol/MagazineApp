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

        private void login_Click(object sender, EventArgs e)
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

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUp = new SignUpForm(service);
            signUp.FormClosed += (s, args) => this.Close();
            signUp.Show();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordBox.Text.Length > 0 && usernameBox.Text.Length > 0)
            {
                loginButton.Enabled = true;
            }
            else loginButton.Enabled = false;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if(passwordBox.Text.Length > 0 && usernameBox.Text.Length > 0) 
            {
                loginButton.Enabled = true;
            }
            else loginButton.Enabled = false;
        }
    }
}
