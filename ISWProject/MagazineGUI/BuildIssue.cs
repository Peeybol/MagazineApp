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
    public partial class BuildIssue : Form
    {
        private IMagazineISWService service;
        private Area area;
        public BuildIssue(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            try { LoadData(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void LoadData()
        {
            listview_pendingPapers.Items.Clear();
            listview_publicatedPapers.Items.Clear();
            //dateTime.MinDate = DateTime.Now;
            Issue lastIssue = service.GetLastIssue();
            if (lastIssue == null) { service.AddIssue(1); issue_number.Text = "1"; }
            else if (lastIssue.PublicationDate != null) 
            { 
                service.AddIssue(lastIssue.Number + 1); 
                issue_number.Text = (lastIssue.Number + 1) + "";

            } else { issue_number.Text = lastIssue.Number.ToString(); }

            ICollection<Area> areas = service.GetAllAreas();
            areas_comboBox.Items.Clear();
            if(areas != null)
            {
                foreach (Area a in areas)
                    areas_comboBox.Items.Add(a.Name);
                areas_comboBox.SelectedIndex = -1;
                areas_comboBox.ResetText();
                areas_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            listview_pendingPapers.Scrollable = false;
            listview_publicatedPapers.Scrollable = false;
        }

        private void Areas_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string areaName = (string) areas_comboBox.SelectedItem;
            area = service.GetAreaByName(areaName);

            ICollection<Paper> pendingPapers = area.PublicationPending;
            ICollection<Paper> EvaluationPendingPapers = area.EvaluationPending;
            ICollection<Paper> publicatedPapers = area.Papers.Except(EvaluationPendingPapers).ToList();
            publicatedPapers = publicatedPapers.Except(pendingPapers).ToList();
            InitializeData(pendingPapers, publicatedPapers);
        }

        public void InitializeData(ICollection<Paper> pendingPapers, ICollection<Paper> publicatedPapers)
        {
            listview_pendingPapers.Items.Clear();
            listview_publicatedPapers.Items.Clear();

            listview_publicatedPapers.Items.AddRange(publicatedPapers.Select(p =>
            {
                ListViewItem item = new ListViewItem(p.Id + "");
                item.SubItems.Add(p.Title);
                return item;
            }).ToArray());

            listview_pendingPapers.Items.AddRange(pendingPapers.Select(p =>
            {
                ListViewItem item = new ListViewItem(p.Id + "");
                item.SubItems.Add(p.Title);
                return item;
            }).ToArray());
        }

        private void PendingToPublicated_button_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listview_pendingPapers.SelectedItems)
            {
                listview_pendingPapers.Items.Remove(item);
                listview_publicatedPapers.Items.Add(item);
                item.Selected = false;
            }
        }

        private void MoveToPending_button_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in listview_publicatedPapers.SelectedItems)
            {
                listview_publicatedPapers.Items.Remove(item);
                listview_pendingPapers.Items.Add(item);
                item.Selected = false;
            }
        }

        private void BuildIssue_button_Click(object sender, EventArgs e)
        {
            ICollection<Paper> pendingPapers = new List<Paper>(); 

            foreach(ListViewItem item in listview_pendingPapers.Items)
            {
                pendingPapers.Add(service.GetPaperById(Int32.Parse(item.Text)));
            }

            area.PublicationPending = pendingPapers;

            try
            {
                Issue issue = service.GetLastIssue();
                foreach(ListViewItem item in listview_publicatedPapers.Items)
                {
                    issue.PublishedPapers.Add(service.GetPaperById(Int32.Parse(item.Text)));
                }
                service.ModifyIssue(issue.Id, dateTime.Value);

                DialogResult answer = MessageBox.Show(this, "The Issue has been built",
                                    "Issue Built",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                LoadData();


            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
