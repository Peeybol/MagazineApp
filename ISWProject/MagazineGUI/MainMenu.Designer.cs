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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SubmitPaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EvaluateAPaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListPapersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildAnIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.IssueToolStripMenuItem,
            this.AccountToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(600, 24);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmitPaperToolStripMenuItem,
            this.EvaluateAPaperToolStripMenuItem,
            this.ListPapersToolStripMenuItem});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.ToolStripMenuItem1.Text = "Paper";
            // 
            // SubmitPaperToolStripMenuItem
            // 
            this.SubmitPaperToolStripMenuItem.Name = "SubmitPaperToolStripMenuItem";
            this.SubmitPaperToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.SubmitPaperToolStripMenuItem.Text = "Submit Paper";
            this.SubmitPaperToolStripMenuItem.Click += new System.EventHandler(this.SubmitPaperToolStripMenuItem_Click);
            // 
            // EvaluateAPaperToolStripMenuItem
            // 
            this.EvaluateAPaperToolStripMenuItem.Name = "EvaluateAPaperToolStripMenuItem";
            this.EvaluateAPaperToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.EvaluateAPaperToolStripMenuItem.Text = "Evaluate a Paper";
            this.EvaluateAPaperToolStripMenuItem.Click += new System.EventHandler(this.EvaluateAPaperToolStripMenuItem_Click);
            // 
            // ListPapersToolStripMenuItem
            // 
            this.ListPapersToolStripMenuItem.Name = "ListPapersToolStripMenuItem";
            this.ListPapersToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ListPapersToolStripMenuItem.Text = "List Papers";
            this.ListPapersToolStripMenuItem.Click += new System.EventHandler(this.ListPapersToolStripMenuItem_Click);
            // 
            // IssueToolStripMenuItem
            // 
            this.IssueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuildAnIssueToolStripMenuItem});
            this.IssueToolStripMenuItem.Name = "IssueToolStripMenuItem";
            this.IssueToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.IssueToolStripMenuItem.Text = "Issue";
            // 
            // BuildAnIssueToolStripMenuItem
            // 
            this.BuildAnIssueToolStripMenuItem.Name = "BuildAnIssueToolStripMenuItem";
            this.BuildAnIssueToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.BuildAnIssueToolStripMenuItem.Text = "Build an Issue";
            this.BuildAnIssueToolStripMenuItem.Click += new System.EventHandler(this.BuildAnIssueToolStripMenuItem_Click);
            // 
            // AccountToolStripMenuItem
            // 
            this.AccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogOutToolStripMenuItem});
            this.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem";
            this.AccountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.AccountToolStripMenuItem.Text = "Account";
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.LogOutToolStripMenuItem.Text = "Log Out";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XClicked);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SubmitPaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EvaluateAPaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListPapersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuildAnIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
    }
}