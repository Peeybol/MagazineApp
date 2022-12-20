using Magazine.Entities;
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
    public partial class RegisterPerson : Form
    {
        IMagazineISWService service;
        private Boolean idOk = false, nameOk = false, surnameOk = false;
        public RegisterPerson(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                service.RegisterPerson(idBox.Text, nameBox.Text, surnameBox.Text);
                MessageBox.Show(this, "Person registered succesfully!",
                                    "Person Registered",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                errorLabel.Visible = false;
            } 
            catch (Exception ex) 
            {
                errorLabel.Text = ex.Message;
                errorLabel.Visible = true;
            }
        }
        private void CancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnableAcceptButton()
        {
            if (idOk && nameOk && surnameOk) registerButton.Enabled = true;
            else registerButton.Enabled = false;
        }

        private void IdTextChanged(object sender, EventArgs e)
        {
            if (idBox.Text.Length == 0) idOk = false;
            else idOk = true;
            EnableAcceptButton();
        }

        private void NameTextChanged(object sender, EventArgs e)
        {
            if (nameBox.Text.Length == 0) nameOk = false;
            else nameOk = true;
            EnableAcceptButton();
        }

        private void SurnameTextChanged(object sender, EventArgs e)
        {
            if (surnameBox.Text.Length == 0) surnameOk = false;
            else surnameOk = true;
            EnableAcceptButton();
        }
    }
}
