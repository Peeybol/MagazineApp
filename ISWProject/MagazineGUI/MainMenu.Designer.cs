namespace MagazineGUI
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitPaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluateAPaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listPapersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildAnIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.issueToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitPaperToolStripMenuItem,
            this.evaluateAPaperToolStripMenuItem,
            this.listPapersToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenuItem1.Text = "Paper";
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildAnIssueToolStripMenuItem});
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.issueToolStripMenuItem.Text = "Issue";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // submitPaperToolStripMenuItem
            // 
            this.submitPaperToolStripMenuItem.Name = "submitPaperToolStripMenuItem";
            this.submitPaperToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.submitPaperToolStripMenuItem.Text = "Submit Paper";
            this.submitPaperToolStripMenuItem.Click += new System.EventHandler(this.submitPaperToolStripMenuItem_Click);
            // 
            // evaluateAPaperToolStripMenuItem
            // 
            this.evaluateAPaperToolStripMenuItem.Name = "evaluateAPaperToolStripMenuItem";
            this.evaluateAPaperToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.evaluateAPaperToolStripMenuItem.Text = "Evaluate a Paper";
            this.evaluateAPaperToolStripMenuItem.Click += new System.EventHandler(this.evaluateAPaperToolStripMenuItem_Click);
            // 
            // listPapersToolStripMenuItem
            // 
            this.listPapersToolStripMenuItem.Name = "listPapersToolStripMenuItem";
            this.listPapersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listPapersToolStripMenuItem.Text = "List Papers";
            this.listPapersToolStripMenuItem.Click += new System.EventHandler(this.listPapersToolStripMenuItem_Click);
            // 
            // buildAnIssueToolStripMenuItem
            // 
            this.buildAnIssueToolStripMenuItem.Name = "buildAnIssueToolStripMenuItem";
            this.buildAnIssueToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.buildAnIssueToolStripMenuItem.Text = "Build an Issue";
            this.buildAnIssueToolStripMenuItem.Click += new System.EventHandler(this.buildAnIssueToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem submitPaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluateAPaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listPapersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildAnIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}