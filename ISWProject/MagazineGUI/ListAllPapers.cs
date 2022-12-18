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

            if(currentUser == service.)

            Console.WriteLine(service.ListAllPapers().Count);
            foreach (Paper p in service.ListAllPapers())
            {
                ListViewItem item = new ListViewItem(p.Id + "");
                item.SubItems.Add(p.Title);
                item.SubItems.Add(p.UploadDate.ToString());
                listView1.Items.Add(item);
            }
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
