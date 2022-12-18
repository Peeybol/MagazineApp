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
        public ListAllPapers(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            Console.WriteLine(service.ListAllPapers().Count);
            foreach (Paper p in service.ListAllPapers())
            {
                ListViewItem item = new ListViewItem(p.Id + "");
                item.SubItems.Add(p.Title);
                item.SubItems.Add(p.UploadDate.ToString());
                listView1.Items.Add(item);
            }
            //Magazine.Entities.User chiefEditor = new User("1234", "Pepe", "TheBoss", false, "ninguna", "pgarcia@gmail.com", "theboss", "1234");
            //Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista Universitaria", chiefEditor);
            //chiefEditor.Magazine = m;
            //Magazine.Entities.User editorOfArea = new Magazine.Entities.User("0001", "Pablo", "Perez", false, "el furbo", "pablito@gmail.com", "theEditor", "contraseña");
            //Magazine.Entities.User paperResponsible = new Magazine.Entities.User("0002", "Ivan", "Haro", false, "los coche", "ivanote@gmail.com", "ivanyvienen", "12345ab");
            //Magazine.Entities.Area area = new Magazine.Entities.Area("area", editorOfArea, m);
            //Magazine.Entities.Paper paper = new Magazine.Entities.Paper("Paper1", new DateTime(2022, 10, 27), area, paperResponsible);
            //ListViewItem item = new ListViewItem(paper.Id + "");
            //item.SubItems.Add(paper.Title);
            //item.SubItems.Add(paper.UploadDate.ToString());
            //listView1.Items.Add(item);
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
                
            }
        }
    }
}
