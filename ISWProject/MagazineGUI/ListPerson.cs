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
        private const int NAME = 0, SURNAME = 1;
        private IMagazineISWService service;
        private List<Person> Data;
        private TextBox coauthors;
        private List<string> ids;
        private string userId;
        private int numCoauthors;
        public ListPerson(IMagazineISWService service, TextBox coauthors, List<string> ids, string userId, int numCoauthors)
        {
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.coauthors = coauthors;
            this.ids = ids;
            this.userId = userId;
            this.numCoauthors = numCoauthors;
            InitializeComponent();
            Data = service.ListAllPersons();
            InitializeData(Data);
        }

        public void InitializeData(List<Person> Data)
        {
            listView.Items.Clear();
            listView.Items.AddRange(Data.Where(p => p.Id != userId).Select(p =>
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
            if (listView.SelectedItems.Count > 4 - numCoauthors)
            {
                DialogResult answer = MessageBox.Show(this, "Maximum number of coauthors exceeded!",
                                    "Maximum Coauthors",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (ListViewItem item in listView.SelectedItems)
                {
                    sb.Append(item.SubItems[NAME].Text + " " +
                        item.SubItems[SURNAME].Text + "\r\n");
                    ids.Add(Data[item.Index].Id);
                }

                coauthors.Text += sb.ToString();
                this.Close();
            }
        }
    }
}
