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
            this.IssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubmitPaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EvaluateAPaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListPapersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildAnIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.IssueToolStripMenuItem,
            this.AccountToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "menuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(800, 28);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmitPaperToolStripMenuItem,
            this.EvaluateAPaperToolStripMenuItem,
            this.ListPapersToolStripMenuItem});
            this.ToolStripMenuItem1.Name = "toolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.ToolStripMenuItem1.Text = "Paper";
            // 
            // issueToolStripMenuItem
            // 
            this.IssueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuildAnIssueToolStripMenuItem});
            this.IssueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.IssueToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.IssueToolStripMenuItem.Text = "Issue";
            // 
            // accountToolStripMenuItem
            // 
            this.AccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogOutToolStripMenuItem});
            this.AccountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.AccountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.AccountToolStripMenuItem.Text = "Account";
            // 
            // submitPaperToolStripMenuItem
            // 
            this.SubmitPaperToolStripMenuItem.Name = "submitPaperToolStripMenuItem";
            this.SubmitPaperToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SubmitPaperToolStripMenuItem.Text = "Submit Paper";
            this.SubmitPaperToolStripMenuItem.Click += new System.EventHandler(this.SubmitPaperToolStripMenuItem_Click);
            // 
            // evaluateAPaperToolStripMenuItem
            // 
            this.EvaluateAPaperToolStripMenuItem.Name = "evaluateAPaperToolStripMenuItem";
            this.EvaluateAPaperToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.EvaluateAPaperToolStripMenuItem.Text = "Evaluate a Paper";
            this.EvaluateAPaperToolStripMenuItem.Click += new System.EventHandler(this.EvaluateAPaperToolStripMenuItem_Click);
            // 
            // listPapersToolStripMenuItem
            // 
            this.ListPapersToolStripMenuItem.Name = "listPapersToolStripMenuItem";
            this.ListPapersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ListPapersToolStripMenuItem.Text = "List Papers";
            this.ListPapersToolStripMenuItem.Click += new System.EventHandler(this.ListPapersToolStripMenuItem_Click);
            // 
            // buildAnIssueToolStripMenuItem
            // 
            this.BuildAnIssueToolStripMenuItem.Name = "buildAnIssueToolStripMenuItem";
            this.BuildAnIssueToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.BuildAnIssueToolStripMenuItem.Text = "Build an Issue";
            this.BuildAnIssueToolStripMenuItem.Click += new System.EventHandler(this.BuildAnIssueToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.LogOutToolStripMenuItem.Text = "Log Out";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
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