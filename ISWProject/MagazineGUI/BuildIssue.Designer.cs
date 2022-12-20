namespace MagazineGUI
{
    partial class BuildIssue
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
            this.issue_label = new System.Windows.Forms.Label();
            this.areas_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listview_publicatedPapers = new System.Windows.Forms.ListView();
            this.col_publicatedId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_publicatedTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_pendingPapers = new System.Windows.Forms.ListView();
            this.col_pendingId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_pendingTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pending_label = new System.Windows.Forms.Label();
            this.publicated_label = new System.Windows.Forms.Label();
            this.pendingToPublicated_button = new System.Windows.Forms.Button();
            this.moveToPending_button = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.buildIssue_button = new System.Windows.Forms.Button();
            this.issue_number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // issue_label
            // 
            this.issue_label.AutoSize = true;
            this.issue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_label.Location = new System.Drawing.Point(287, 21);
            this.issue_label.Name = "issue_label";
            this.issue_label.Size = new System.Drawing.Size(282, 46);
            this.issue_label.TabIndex = 0;
            this.issue_label.Text = "Current Issue:";
            // 
            // areas_comboBox
            // 
            this.areas_comboBox.Location = new System.Drawing.Point(170, 120);
            this.areas_comboBox.Name = "areas_comboBox";
            this.areas_comboBox.Size = new System.Drawing.Size(225, 24);
            this.areas_comboBox.TabIndex = 1;
            this.areas_comboBox.SelectedIndexChanged += new System.EventHandler(this.Areas_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Area:";
            // 
            // listview_publicatedPapers
            // 
            this.listview_publicatedPapers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_publicatedId,
            this.col_publicatedTitle});
            this.listview_publicatedPapers.FullRowSelect = true;
            this.listview_publicatedPapers.HideSelection = false;
            this.listview_publicatedPapers.Location = new System.Drawing.Point(531, 192);
            this.listview_publicatedPapers.Name = "listview_publicatedPapers";
            this.listview_publicatedPapers.Size = new System.Drawing.Size(346, 378);
            this.listview_publicatedPapers.TabIndex = 4;
            this.listview_publicatedPapers.UseCompatibleStateImageBehavior = false;
            this.listview_publicatedPapers.View = System.Windows.Forms.View.Details;
            // 
            // col_publicatedId
            // 
            this.col_publicatedId.Text = "ID";
            this.col_publicatedId.Width = 125;
            // 
            // col_publicatedTitle
            // 
            this.col_publicatedTitle.Text = "Title";
            this.col_publicatedTitle.Width = 215;
            // 
            // listview_pendingPapers
            // 
            this.listview_pendingPapers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_pendingId,
            this.col_pendingTitle});
            this.listview_pendingPapers.FullRowSelect = true;
            this.listview_pendingPapers.HideSelection = false;
            this.listview_pendingPapers.Location = new System.Drawing.Point(49, 192);
            this.listview_pendingPapers.Name = "listview_pendingPapers";
            this.listview_pendingPapers.Size = new System.Drawing.Size(346, 378);
            this.listview_pendingPapers.TabIndex = 5;
            this.listview_pendingPapers.UseCompatibleStateImageBehavior = false;
            this.listview_pendingPapers.View = System.Windows.Forms.View.Details;
            // 
            // col_pendingId
            // 
            this.col_pendingId.Text = "ID";
            this.col_pendingId.Width = 125;
            // 
            // col_pendingTitle
            // 
            this.col_pendingTitle.Text = "Title";
            this.col_pendingTitle.Width = 215;
            // 
            // pending_label
            // 
            this.pending_label.AutoSize = true;
            this.pending_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pending_label.Location = new System.Drawing.Point(124, 169);
            this.pending_label.Name = "pending_label";
            this.pending_label.Size = new System.Drawing.Size(205, 20);
            this.pending_label.TabIndex = 6;
            this.pending_label.Text = "Pending Publication Paper";
            // 
            // publicated_label
            // 
            this.publicated_label.AutoSize = true;
            this.publicated_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicated_label.Location = new System.Drawing.Point(635, 169);
            this.publicated_label.Name = "publicated_label";
            this.publicated_label.Size = new System.Drawing.Size(145, 20);
            this.publicated_label.TabIndex = 7;
            this.publicated_label.Text = "Publicated Papers";
            // 
            // pendingToPublicated_button
            // 
            this.pendingToPublicated_button.Location = new System.Drawing.Point(113, 576);
            this.pendingToPublicated_button.Name = "pendingToPublicated_button";
            this.pendingToPublicated_button.Size = new System.Drawing.Size(207, 31);
            this.pendingToPublicated_button.TabIndex = 8;
            this.pendingToPublicated_button.Text = "Move to Publicated Papers";
            this.pendingToPublicated_button.UseVisualStyleBackColor = true;
            this.pendingToPublicated_button.Click += new System.EventHandler(this.PendingToPublicated_button_Click);
            // 
            // moveToPending_button
            // 
            this.moveToPending_button.Location = new System.Drawing.Point(581, 576);
            this.moveToPending_button.Name = "moveToPending_button";
            this.moveToPending_button.Size = new System.Drawing.Size(258, 31);
            this.moveToPending_button.TabIndex = 9;
            this.moveToPending_button.Text = "Move to Pending Publication Papers";
            this.moveToPending_button.UseVisualStyleBackColor = true;
            this.moveToPending_button.Click += new System.EventHandler(this.MoveToPending_button_Click);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(531, 122);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(346, 22);
            this.dateTime.TabIndex = 10;
            // 
            // buildIssue_button
            // 
            this.buildIssue_button.Enabled = false;
            this.buildIssue_button.Location = new System.Drawing.Point(395, 631);
            this.buildIssue_button.Name = "buildIssue_button";
            this.buildIssue_button.Size = new System.Drawing.Size(137, 31);
            this.buildIssue_button.TabIndex = 11;
            this.buildIssue_button.Text = "Build a new Issue";
            this.buildIssue_button.UseVisualStyleBackColor = true;
            this.buildIssue_button.Click += new System.EventHandler(this.BuildIssue_button_Click);
            // 
            // issue_number
            // 
            this.issue_number.AutoSize = true;
            this.issue_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_number.Location = new System.Drawing.Point(585, 21);
            this.issue_number.Name = "issue_number";
            this.issue_number.Size = new System.Drawing.Size(108, 46);
            this.issue_number.TabIndex = 2;
            this.issue_number.Text = "xxxx";
            // 
            // BuildIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 684);
            this.Controls.Add(this.buildIssue_button);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.moveToPending_button);
            this.Controls.Add(this.pendingToPublicated_button);
            this.Controls.Add(this.publicated_label);
            this.Controls.Add(this.pending_label);
            this.Controls.Add(this.listview_pendingPapers);
            this.Controls.Add(this.listview_publicatedPapers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.issue_number);
            this.Controls.Add(this.areas_comboBox);
            this.Controls.Add(this.issue_label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuildIssue";
            this.Text = "Build an Issue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuildIssue_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label issue_label;
        private System.Windows.Forms.ComboBox areas_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listview_publicatedPapers;
        private System.Windows.Forms.ColumnHeader col_publicatedId;
        private System.Windows.Forms.ColumnHeader col_publicatedTitle;
        private System.Windows.Forms.ListView listview_pendingPapers;
        private System.Windows.Forms.ColumnHeader col_pendingId;
        private System.Windows.Forms.ColumnHeader col_pendingTitle;
        private System.Windows.Forms.Label pending_label;
        private System.Windows.Forms.Label publicated_label;
        private System.Windows.Forms.Button pendingToPublicated_button;
        private System.Windows.Forms.Button moveToPending_button;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button buildIssue_button;
        private System.Windows.Forms.Label issue_number;
    }
}