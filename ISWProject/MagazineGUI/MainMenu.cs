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

        public MainMenu(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            //We initialize the windows that we may open later:
            CheckLogout = new CheckLogout(service);

        }

        private void submitPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void evaluateAPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listPapersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buildAnIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckLogout.ShowDialog();
        }
    }
}
