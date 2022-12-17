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
    public partial class CheckLogout : Form
    {
        private IMagazineISWService service;
        private MagazineApp MagazineApp;

        public CheckLogout(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void accept_Click(object sender, EventArgs e)
        {
            service.Logout();
            this.Hide();
            MagazineApp = new MagazineApp(service);
            MagazineApp.FormClosed += (s, args) => this.Close();
            MagazineApp.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
