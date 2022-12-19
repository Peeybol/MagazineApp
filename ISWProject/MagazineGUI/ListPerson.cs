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
    public partial class ListPerson : Form
    {
        private IMagazineISWService service;
        List<Person> Data; 
        public ListPerson(IMagazineISWService service)
        {
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();
            Data = service.ListAllPersons();
            initializeData(Data);
        }

        public void initializeData(List<Person> Data)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(Data.Select(p =>
            {
                ListViewItem item = new ListViewItem(p.Name);
                item.SubItems.Add(p.Surname);
                return item;
            }).ToArray());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
