using Magazine.Entities;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazineGUI
{
    public partial class SubmitPaper : Form
    {
        private IMagazineISWService service;
        private bool areaOk = false, titleOk = false;
        private List<string> ids;
        private User currentUser;
        public SubmitPaper(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            ids = new List<string>();
            currentUser = service.GetCurrentUser();
            coauthorsBox.Text = currentUser.Name + " " + currentUser.Surname + "\r\n";
        }

        private void AcceptClick(object sender, EventArgs e)
        {
            try
            {
                int areaId = service.GetIdByAreaName(areaBox.Text);
                int paperId = service.SubmitPaper(areaId, titleBox.Text, DateTime.Now);
                foreach (string authorId in ids)
                {
                    service.AddCoauthor(paperId, authorId);
                }
                MessageBox.Show(this, "Paper submitted succesfully!",
                                    "Paper submitted",
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

        private void EnableAcceptButton ()
        {
            if (areaOk && titleOk) acceptButton.Enabled = true;
            else acceptButton.Enabled = false;
        }

        private void AreaTextChanged(object sender, EventArgs e)
        {
            if (areaBox.Text.Length == 0) areaOk = false;
            else areaOk = true;
            EnableAcceptButton();
        }

        private void AreaButton_Clicked(object sender, EventArgs e)
        {
            StringBuilder areas = new StringBuilder();
            service.ListAllAreas().ForEach(a => areas.Append(a.Name + "\n"));
            MessageBox.Show(this, "Introduce the area you want to submit your paper to from this list:\n" +
                                                        areas.ToString(), "AreasInfo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        private void CoauthorsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            int numCoauthors = coauthorsBox.Text.Split('\n').Length - 1;
            ListPerson listPerson = new ListPerson(service, coauthorsBox, ids, currentUser.Id, numCoauthors);
            listPerson.FormClosed += (s, args) => this.Show();
            listPerson.Show();
        }

        private void CoauthorsBoxTextChanged(object sender, EventArgs e)
        {
            if (coauthorsBox.Text.Split('\n').Length - 1 >= 4)
                coauthorsButton.Enabled = false;
        }

        private void TitleTextChanged(object sender, EventArgs e)
        {
            if (titleBox.Text.Length == 0) titleOk = false;
            else titleOk = true;
            EnableAcceptButton();
        }
    }
}
