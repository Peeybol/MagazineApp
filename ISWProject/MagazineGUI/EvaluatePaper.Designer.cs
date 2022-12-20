namespace MagazineGUI
{
    partial class EvaluatePaper
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
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublicationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EvaluateButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Title,
            this.Author,
            this.PublicationDate});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 10);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(658, 374);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.IndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 61;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 248;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 221;
            // 
            // PublicationDate
            // 
            this.PublicationDate.Text = "Publication Date";
            this.PublicationDate.Width = 115;
            // 
            // EvaluateButton
            // 
            this.EvaluateButton.Enabled = false;
            this.EvaluateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EvaluateButton.Location = new System.Drawing.Point(580, 388);
            this.EvaluateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EvaluateButton.Name = "EvaluateButton";
            this.EvaluateButton.Size = new System.Drawing.Size(86, 32);
            this.EvaluateButton.TabIndex = 1;
            this.EvaluateButton.Text = "Evaluate";
            this.EvaluateButton.UseVisualStyleBackColor = true;
            this.EvaluateButton.Click += new System.EventHandler(this.EvaluateButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(10, 388);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(76, 32);
            this.GoBackButton.TabIndex = 2;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // EvaluatePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 427);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.EvaluateButton);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EvaluatePaper";
            this.Text = "Evaluate a Paper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader PublicationDate;
        private System.Windows.Forms.Button EvaluateButton;
        private System.Windows.Forms.Button GoBackButton;
    }
}