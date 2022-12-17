namespace MagazineGUI
{
    partial class CheckLogout
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label1.Location = new System.Drawing.Point(30, 47);
            this.Label1.Name = "label1";
            this.Label1.Size = new System.Drawing.Size(301, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Are you sure you want to log out?";
            // 
            // button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Button1.Location = new System.Drawing.Point(182, 100);
            this.Button1.Name = "button1";
            this.Button1.Size = new System.Drawing.Size(100, 30);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Accept";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Accept_Click);
            // 
            // button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Button2.Location = new System.Drawing.Point(294, 100);
            this.Button2.Name = "button2";
            this.Button2.Size = new System.Drawing.Size(100, 30);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Cancel";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CheckLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 142);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Name = "CheckLogout";
            this.Text = "CheckLogout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
    }
}