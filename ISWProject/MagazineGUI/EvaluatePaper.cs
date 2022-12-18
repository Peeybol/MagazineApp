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
    public partial class EvaluatePaper : Form
    {
        private IMagazineISWService service;
        private User CurrentUser;

        public EvaluatePaper(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            CurrentUser = service.GetCurrentUser();

            //Area a = CurrentUser.Area;

            foreach (Paper p in CurrentUser.Area.EvaluationPending)
            {
                ListViewItem item = new ListViewItem(p.Id  + "");
                listView1.Items.Add(item);
            }
        }
    }
}
