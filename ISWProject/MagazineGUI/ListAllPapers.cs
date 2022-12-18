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

            Console.WriteLine(service.ListAllPapers().Count);

            listView1.Items.AddRange(Data.Select(p =>
            {
                ListViewItem item = new ListViewItem(p.Id + "");
                item.SubItems.Add(p.Title);
                item.SubItems.Add(p.UploadDate.ToString());
                item.SubItems.Add(p.Responsible.Name + " " + p.Responsible.Surname);
                item.SubItems.AddRange(p.CoAuthors.Skip(1).Select(ca =>
                { 
                    return ", " + ca.Name + " " + ca.Surname;
                }).ToArray());
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
            
            
            //foreach (Paper p in service.ListAllPapers())
            //{
            //    ListViewItem item = new ListViewItem(p.Id + "");
            //    item.SubItems.Add(p.Title);
            //    item.SubItems.Add(p.UploadDate.ToString());
            //    listView1.Items.Add(item);
            //}
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
                    service.RemovePaper(Int32.Parse(i.Text));
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {

        }

        private void unpublishButton_Click(object sender, EventArgs e)
        {

        }
    }
}
