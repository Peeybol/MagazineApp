using Magazine.Entities;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MagazineGUI
{
    public partial class ListAllPapers : Form
    {
        private IMagazineISWService service;
        private List<Paper> Data;


        //CONSTANTS in order to access the subitems in each listviewitem
        private const int ISSUE = 6;
        public ListAllPapers(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            User currentUser = service.GetCurrentUser();
            Area a;
            if (service.IsChiefEditor(currentUser))
            {
                Data = service.ListAllPapers();
            }
            else if (service.IsAreaEditor(currentUser, out a))
            {
                Data = service.ListPapersByArea(a);
            }
            else return;
            initializeData(Data);

        }

        public void initializeData(List<Paper> Data)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(Data.Select(p =>
            {
                StringBuilder sb = new StringBuilder(p.Responsible.Name + " " + p.Responsible.Surname);
                foreach (Person ca in p.CoAuthors.Skip(1)) sb.Append(", " + ca.Name + " " + ca.Surname);
                ListViewItem item = new ListViewItem(p.Id + "");
                item.SubItems.Add(p.Title);
                item.SubItems.Add(p.UploadDate.ToString());
                item.SubItems.Add(sb.ToString());
                item.SubItems.Add(
                    p.PublicationPendingArea != null ? "pending publication" :
                    p.EvaluationPendingArea != null ? "pending evaluation" :
                    p.Issue != null ? "published" :
                    p.Evaluation.Accepted ? "" : "rejected"
                    );
                item.SubItems.Add(p.BelongingArea.Name);
                item.SubItems.Add(p.Issue == null ? "none" : p.Issue.Number + "");
                return item;
            }).ToArray());
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            initializeData(Data);
            if (filterTextbox.Text == "" || filterTextbox.Text == null || Regex.Match(filterTextbox.Text, "[^0-9]").Success) return;
            foreach(ListViewItem i in listView1.Items)
            {
                if (i.SubItems[ISSUE].Text != filterTextbox.Text) listView1.Items.Remove(i);
            }
        }
    }
}
