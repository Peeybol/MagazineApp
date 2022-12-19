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
            LoadData();
        }

        public void LoadData()
        {
            issue_number.Text = service.LastIssueNumber().ToString();
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
        }

        private void areas_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string areaName = (string) areas_comboBox.SelectedItem;
            Area area = service.GetAreaByName(areaName);

            ICollection<Paper> pendingPapers = area.PublicationPending;
            ICollection<Paper> EvaluationPendingPapers = area.EvaluationPending;
            ICollection<Paper> publicatedPapers = area.Papers.Except(EvaluationPendingPapers).ToList();
            publicatedPapers = publicatedPapers.Except(pendingPapers).ToList();


            

        }
    }
}
