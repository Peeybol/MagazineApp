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
    public partial class PaperEvaluation : Form
    {
        private IMagazineISWService service;
        private int Id;
        public PaperEvaluation(IMagazineISWService service, int Id)
        {
            InitializeComponent();
            this.service = service;
            this.Id = Id;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                service.EvaluatePaper(true, CommentsTextBox.Text, DateTime.Now, Id);
                MessageBox.Show(this, "Paper accepted succesfully!",
                                        "Paper Accepted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show(this, "Please enter some comments!",
                                        "Comments field empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void RejectButton_Click(object sender, EventArgs e)
        {
            try
            {
                service.EvaluatePaper(false, CommentsTextBox.Text, DateTime.Now, Id);
                MessageBox.Show(this, "Paper rejected succesfully!",
                                        "Paper Rejecteds",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            
            catch (Exception)
            {
                MessageBox.Show(this, "Please enter some comments!",
                                        "Comments field empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
