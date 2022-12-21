namespace MagazineGUI
{
    partial class ListAllPapers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Paper_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Upload_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Authors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Paper_state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Area = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Issue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filterTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Paper_id,
            this.Title,
            this.Upload_date,
            this.Authors,
            this.Paper_state,
            this.Area,
            this.Issue});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(-2, -2);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1159, 499);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Paper_id
            // 
            this.Paper_id.Text = "Paper id";
            this.Paper_id.Width = 80;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 180;
            // 
            // Upload_date
            // 
            this.Upload_date.Text = "Upload date";
            this.Upload_date.Width = 140;
            // 
            // Authors
            // 
            this.Authors.Text = "Authors";
            this.Authors.Width = 300;
            // 
            // Paper_state
            // 
            this.Paper_state.Text = "Paper State";
            this.Paper_state.Width = 220;
            // 
            // Area
            // 
            this.Area.Text = "Area";
            this.Area.Width = 143;
            // 
            // Issue
            // 
            this.Issue.Text = "Issue";
            this.Issue.Width = 65;
            // 
            // filterTextbox
            // 
            this.filterTextbox.Location = new System.Drawing.Point(104, 519);
            this.filterTextbox.Name = "filterTextbox";
            this.filterTextbox.Size = new System.Drawing.Size(100, 20);
            this.filterTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter by issue:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Filter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // ListAllPapers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 560);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterTextbox);
            this.Controls.Add(this.listView1);
            this.Name = "ListAllPapers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paper List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Paper_id;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Upload_date;
        private System.Windows.Forms.ColumnHeader Authors;
        private System.Windows.Forms.ColumnHeader Paper_state;
        private System.Windows.Forms.ColumnHeader Area;
        private System.Windows.Forms.ColumnHeader Issue;
        private System.Windows.Forms.TextBox filterTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}