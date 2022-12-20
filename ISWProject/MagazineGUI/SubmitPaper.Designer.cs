namespace MagazineGUI
{
    partial class SubmitPaper
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
            this.areaLabel = new System.Windows.Forms.Label();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.passwordInfoButton = new System.Windows.Forms.Button();
            this.coauthorsButton = new System.Windows.Forms.Button();
            this.coauthorsBox = new System.Windows.Forms.TextBox();
            this.coauthorsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaLabel.Location = new System.Drawing.Point(31, 27);
            this.areaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(63, 29);
            this.areaLabel.TabIndex = 0;
            this.areaLabel.Text = "Area";
            // 
            // areaBox
            // 
            this.areaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaBox.Location = new System.Drawing.Point(36, 62);
            this.areaBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(316, 30);
            this.areaBox.TabIndex = 1;
            this.areaBox.TextChanged += new System.EventHandler(this.AreaTextChanged);
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(36, 145);
            this.titleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(316, 30);
            this.titleBox.TabIndex = 3;
            this.titleBox.TextChanged += new System.EventHandler(this.TitleTextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(31, 111);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(61, 29);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(239, 364);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 46);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelClick);
            // 
            // acceptButton
            // 
            this.acceptButton.Enabled = false;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.Location = new System.Drawing.Point(116, 364);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(115, 46);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Submit";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptClick);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(35, 297);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(123, 20);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "texto de error";
            this.errorLabel.Visible = false;
            // 
            // passwordInfoButton
            // 
            this.passwordInfoButton.Location = new System.Drawing.Point(361, 63);
            this.passwordInfoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordInfoButton.Name = "passwordInfoButton";
            this.passwordInfoButton.Size = new System.Drawing.Size(33, 32);
            this.passwordInfoButton.TabIndex = 21;
            this.passwordInfoButton.Text = "?";
            this.passwordInfoButton.UseVisualStyleBackColor = true;
            this.passwordInfoButton.Click += new System.EventHandler(this.AreaButton_Clicked);
            // 
            // coauthorsButton
            // 
            this.coauthorsButton.Location = new System.Drawing.Point(361, 224);
            this.coauthorsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coauthorsButton.Name = "coauthorsButton";
            this.coauthorsButton.Size = new System.Drawing.Size(33, 32);
            this.coauthorsButton.TabIndex = 24;
            this.coauthorsButton.Text = "+";
            this.coauthorsButton.UseVisualStyleBackColor = true;
            this.coauthorsButton.Click += new System.EventHandler(this.CoauthorsButton_Click);
            // 
            // coauthorsBox
            // 
            this.coauthorsBox.Enabled = false;
            this.coauthorsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coauthorsBox.Location = new System.Drawing.Point(36, 223);
            this.coauthorsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coauthorsBox.Multiline = true;
            this.coauthorsBox.Name = "coauthorsBox";
            this.coauthorsBox.Size = new System.Drawing.Size(316, 122);
            this.coauthorsBox.TabIndex = 23;
            this.coauthorsBox.TextChanged += new System.EventHandler(this.CoauthorsBoxTextChanged);
            // 
            // coauthorsLabel
            // 
            this.coauthorsLabel.AutoSize = true;
            this.coauthorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coauthorsLabel.Location = new System.Drawing.Point(31, 188);
            this.coauthorsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coauthorsLabel.Name = "coauthorsLabel";
            this.coauthorsLabel.Size = new System.Drawing.Size(123, 29);
            this.coauthorsLabel.TabIndex = 22;
            this.coauthorsLabel.Text = "Coauthors";
            // 
            // SubmitPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 425);
            this.Controls.Add(this.coauthorsButton);
            this.Controls.Add(this.coauthorsBox);
            this.Controls.Add(this.coauthorsLabel);
            this.Controls.Add(this.passwordInfoButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.areaLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SubmitPaper";
            this.Text = "Submit Paper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button passwordInfoButton;
        private System.Windows.Forms.Button coauthorsButton;
        private System.Windows.Forms.TextBox coauthorsBox;
        private System.Windows.Forms.Label coauthorsLabel;
    }
}