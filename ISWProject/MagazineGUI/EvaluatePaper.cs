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
        private List<Paper> Data;

        public EvaluatePaper(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            CurrentUser = service.GetCurrentUser();

            string area;
            if (service.IsAreaEditor(CurrentUser, out area))
            {
                Data = service.GetAllEvaluationPendingPapersInAnArea(area);
                InitializeData(Data);
            }
        }

        public void InitializeData(List<Paper> Data)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(Data.Select(p =>
            {
                string s = p.Responsible.Name + " " + p.Responsible.Surname;
                ListViewItem item = new ListViewItem(p.Id + "");
                item.SubItems.Add(p.Title);
                item.SubItems.Add(s);
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
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            PaperEvaluation PaperEvaluation = new PaperEvaluation(service, id);
            PaperEvaluation.FormClosed += (s, args) =>
            {
                this.Show();
                InitializeData(Data);
            };
            PaperEvaluation.Show();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
