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
        private List<Person> Data;
        private TextBox coauthors;
        private List<string> ids;
        public ListPerson(IMagazineISWService service, TextBox coauthors, List<string> ids)
        {
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.coauthors = coauthors;
            this.ids = ids;
            InitializeComponent();
            Data = service.ListAllPersons();
            InitializeData(Data);
        }

        public void InitializeData(List<Person> Data)
        {
            listView.Items.Clear();
            listView.Items.AddRange(Data.Select(p =>
            {
                ListViewItem item = new ListViewItem(p.Name);
                item.SubItems.Add(p.Surname);
                return item;
            }).ToArray());
        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPerson registerPerson = new RegisterPerson(service);
            registerPerson.FormClosed += (s, args) => this.Close();
            registerPerson.Show();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            string selectedName = listView.SelectedItems[0].SubItems[0].Text + " " +
                listView.SelectedItems[0].SubItems[1].Text + "\r\n";
            coauthors.Text += selectedName;

            ids.Add(Data[listView.SelectedItems[0].Index].Id);
            this.Close();
        }
    }
}
