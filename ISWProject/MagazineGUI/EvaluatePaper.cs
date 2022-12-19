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

            if (service.IsChiefEditor(CurrentUser))
            {
                InitializeData(service.ListAllEvaluationPendingPapers());
            }
            else
            {
                InitializeData(CurrentUser.Area.EvaluationPending.ToList()); //Revisar
            }
        }

        public void InitializeData(List<Paper> Data)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(Data.Select(p =>
            {
                StringBuilder sb = new StringBuilder(p.Responsible.Name + " " + p.Responsible.Surname);
                ListViewItem item = new ListViewItem(p.Id + "");
                item.SubItems.Add(p.Title);
                item.SubItems.Add(sb.ToString());
                item.SubItems.Add(p.UploadDate.ToString());
                return item;
            }).ToArray());
        }

        private void IndexChanged(object sender, EventArgs e)
        {
            EvaluateButton.Enabled = listView1.SelectedItems.Count > 0 ? true : false;
        }

        private void EvaluateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaperEvaluation PaperEvaluation = new PaperEvaluation(service);
            PaperEvaluation.FormClosed += (s, args) => this.Show();
            PaperEvaluation.Show();
        }
    }
}
