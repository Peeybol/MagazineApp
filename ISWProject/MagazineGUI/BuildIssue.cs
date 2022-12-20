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
            buildIssue_button.Enabled = false;
            listview_pendingPapers.Items.Clear();
            listview_publicatedPapers.Items.Clear();
            dateTime.MinDate = DateTime.Now;
            int lastIssue = service.GetLastIssueNumberAndAddANewOne();
            issue_number.Text = lastIssue + "";
            
            ICollection<string> areas = service.GetAllAreasNames();
            
            areas_comboBox.Items.Clear();
            if(areas != null)
            {
                foreach (string a in areas)
                    areas_comboBox.Items.Add(a);
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
            ICollection<Paper> pendingPapers = service.GetAllPendingPapersInAnArea(areaName);
            ICollection<Paper> publishedPapers = service.GetAllPublishedPapersInTheLastIssue();
            InitializeData(pendingPapers, publishedPapers);
        }

        public void InitializeData(ICollection<Paper> pendingPapers, ICollection<Paper> publishedPapers)
        {
            listview_pendingPapers.Items.Clear();
            listview_publicatedPapers.Items.Clear();

            listview_pendingPapers.Items.AddRange(pendingPapers.Select(p =>
            {
                ListViewItem item = new ListViewItem(p.Id + "");
                item.SubItems.Add(p.Title);
                return item;
            }).ToArray());

            listview_publicatedPapers.Items.AddRange(publishedPapers.Select(p =>
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
                service.PublishPaper(Int32.Parse(item.Text));
                listview_pendingPapers.Items.Remove(item);
                listview_publicatedPapers.Items.Add(item);
                item.Selected = false;
            }
            if (listview_publicatedPapers.Items.Count > 0) buildIssue_button.Enabled = true;
        }

        private void MoveToPending_button_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in listview_publicatedPapers.SelectedItems)
            {
                service.UnPublishPaper(Int32.Parse(item.Text));
                listview_publicatedPapers.Items.Remove(item);
            }

            listview_pendingPapers.Items.Clear();
            string areaName = (string)areas_comboBox.SelectedItem;
            ICollection<Paper> pendingPapers = service.GetAllPendingPapersInAnArea(areaName);
            listview_pendingPapers.Items.AddRange(pendingPapers.Select(p =>
            {
                ListViewItem item = new ListViewItem(p.Id + "");
                item.SubItems.Add(p.Title);
                return item;
            }).ToArray());
            if (listview_publicatedPapers.Items.Count <= 0) buildIssue_button.Enabled = false;
        }

        private void BuildIssue_button_Click(object sender, EventArgs e)
        {
            try { service.BuildAnIssue(dateTime.Value); } 
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            DialogResult answer = MessageBox.Show(this, "The Issue has been built",
                                "Issue Built",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            LoadData();
        }

        private void BuildIssue_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
