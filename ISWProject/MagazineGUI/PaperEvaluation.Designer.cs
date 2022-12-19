namespace MagazineGUI
{
    partial class PaperEvaluation
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.CommentsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(241, 280);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(74, 32);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // RejectButton
            // 
            this.RejectButton.Location = new System.Drawing.Point(324, 280);
            this.RejectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(70, 32);
            this.RejectButton.TabIndex = 1;
            this.RejectButton.Text = "Reject";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(16, 280);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(82, 32);
            this.GoBackButton.TabIndex = 2;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // CommentsTextBox
            // 
            this.CommentsTextBox.Location = new System.Drawing.Point(16, 55);
            this.CommentsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CommentsTextBox.Multiline = true;
            this.CommentsTextBox.Name = "CommentsTextBox";
            this.CommentsTextBox.Size = new System.Drawing.Size(379, 200);
            this.CommentsTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comments";
            // 
            // PaperEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommentsTextBox);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.AcceptButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PaperEvaluation";
            this.Text = "Evaluate a Paper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.TextBox CommentsTextBox;
        private System.Windows.Forms.Label label1;
    }
}