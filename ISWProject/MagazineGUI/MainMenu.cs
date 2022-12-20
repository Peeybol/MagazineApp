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
    public partial class MainMenu : Form
    {
        private IMagazineISWService service;

        public MainMenu(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            User currentUser = service.GetCurrentUser();
            if(service.IsChiefEditor(currentUser))
            {
                ListPapersToolStripMenuItem.Visible = true;
                IssueToolStripMenuItem.Visible = true;
            }
            else if(service.IsAreaEditor(currentUser, out _))
            {
                EvaluateAPaperToolStripMenuItem.Visible = true;
            }
        }

        private void SubmitPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubmitPaper submitPaper = new SubmitPaper(service);
            submitPaper.FormClosed += (s, args) => this.Show();
            submitPaper.Show();
        }

        private void EvaluateAPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvaluatePaper evPaper = new EvaluatePaper(service);
            evPaper.FormClosed += (s, args) => this.Show();
            evPaper.Show();
        }

        private void ListPapersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListAllPapers listPapers = new ListAllPapers(service);
            listPapers.FormClosed += (s, args) => this.Show();
            listPapers.Show();
        }

        private void BuildAnIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuildIssue buildIssue = new BuildIssue(service);
            buildIssue.FormClosed += (s, args) => this.Show();
            buildIssue.Show();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(this, "Are you sure you want to log out?",
                                    "Logout Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (answer == DialogResult.OK)
            {
                service.Logout();
                this.Hide();
                new MagazineApp(service).Show();
            }
        }

        private void XClicked(object sender, FormClosingEventArgs e)
        {
            service.Logout();
            Application.Exit();
        }

        private void RegisterPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPerson registerPerson = new RegisterPerson(service);
            registerPerson.FormClosed += (s, args) => this.Show();
            registerPerson.Show();
        }
    }
}
