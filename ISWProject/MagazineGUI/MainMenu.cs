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
        private CheckLogout CheckLogout;
        //private SubmitPaper SubmitPaper;

        public MainMenu(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            //We initialize the windows that we may open later:
            CheckLogout = new CheckLogout(service);
        }

        private void SubmitPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void EvaluateAPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListPapersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BuildAnIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckLogout.FormClosed += (s, args) => this.Close();
            CheckLogout.ShowDialog();
        }
    }
}
