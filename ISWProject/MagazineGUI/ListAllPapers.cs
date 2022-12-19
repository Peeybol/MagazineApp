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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MagazineGUI
{
    public partial class ListAllPapers : Form
    {
        private IMagazineISWService service;
        private List<Paper> Data;


        //CONSTANTS in order to access the subitems in each listviewitem
        private const int TITLE = 0,
                            DATE = 1,
                            AUTHORS = 2,
                            STATUS = 3,
                            AREA = 4,
                            ISSUE = 5;
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
            listView1.Clear();
            listView1.Items.AddRange(Data.Select(p =>
            {
                StringBuilder sb = new StringBuilder(p.Responsible.Name + p.Responsible.Surname);
                foreach (Person ca in p.CoAuthors.Skip(1)) sb.Append(", " + ca.Name + " " + ca.Surname);
                ListViewItem item = new ListViewItem(p.Id + "");
                item.SubItems.Add(p.Title);
                item.SubItems.Add(p.UploadDate.ToString());
                item.SubItems.Add(sb.ToString());
                item.SubItems.Add(
                    p.PublicationPendingArea != null ? "pending publication" :
                    p.EvaluationPendingArea != null ? "pending evaluation" :
                    p.BelongingArea.Papers.Contains(p) ? "published" :
                    p.Evaluation.Accepted ? "" : "rejected"
                    );
                item.SubItems.Add(p.BelongingArea.Name);
                item.SubItems.Add(p.Issue == null ? "none" : p.Issue.Number + "");
                return item;
            }).ToArray());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem i in listView1.SelectedItems)
            {
                try
                {
                    Console.Write(Int32.Parse(i.Text) + "\n");
                    service.RemovePaper(Int32.Parse(i.Text));
                    listView1.Items.Remove(i);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"{ex.InnerException.Message}");
                }
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            initializeData(Data);
            if (filterTextbox.Text == "" || filterTextbox.Text == null || filterTextbox.Text.Replace("[^0-9]", "").Length == 0) return;
            foreach(ListViewItem i in listView1.Items)
            {
                if (i.SubItems[ISSUE].Text != filterTextbox.Text) listView1.Items.Remove(i);
            }
        }

        private void unpublishButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView1.SelectedItems)
            {
                try
                {
                    Console.Write(Int32.Parse(i.Text) + "\n");
                    service.UnPublishPaper(Int32.Parse(i.Text));
                    i.SubItems[3].Text = "pending publication"; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.InnerException.Message}");
                }
            }
        }
    }
}
