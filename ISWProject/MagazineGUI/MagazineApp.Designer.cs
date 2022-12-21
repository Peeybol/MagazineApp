namespace MagazineGUI
{
    partial class MagazineApp
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.noaccountLabel = new System.Windows.Forms.Label();
            this.signupLink = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(257, 92);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(78, 29);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Login";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(56, 34);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(491, 33);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Welcome to The Dudes Magazine!";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(58, 146);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(97, 24);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(62, 174);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(485, 26);
            this.usernameBox.TabIndex = 6;
            this.usernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(58, 215);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(92, 24);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(62, 242);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '♡';
            this.passwordBox.Size = new System.Drawing.Size(485, 26);
            this.passwordBox.TabIndex = 8;
            this.passwordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // noaccountLabel
            // 
            this.noaccountLabel.AutoSize = true;
            this.noaccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noaccountLabel.Location = new System.Drawing.Point(136, 292);
            this.noaccountLabel.Name = "noaccountLabel";
            this.noaccountLabel.Size = new System.Drawing.Size(244, 24);
            this.noaccountLabel.TabIndex = 9;
            this.noaccountLabel.Text = "You don\'t have an account?";
            // 
            // signupLink
            // 
            this.signupLink.AutoSize = true;
            this.signupLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLink.LinkColor = System.Drawing.Color.Black;
            this.signupLink.Location = new System.Drawing.Point(378, 292);
            this.signupLink.Name = "signupLink";
            this.signupLink.Size = new System.Drawing.Size(75, 24);
            this.signupLink.TabIndex = 10;
            this.signupLink.TabStop = true;
            this.signupLink.Text = "Sign up";
            this.signupLink.VisitedLinkColor = System.Drawing.Color.Gray;
            this.signupLink.Click += new System.EventHandler(this.Signup_Click);
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Enabled = false;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(223, 406);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(142, 33);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(382, 406);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(142, 33);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(59, 360);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(50, 16);
            this.errorLabel.TabIndex = 13;
            this.errorLabel.Text = "label1";
            this.errorLabel.Visible = false;
            // 
            // MagazineApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 478);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.signupLink);
            this.Controls.Add(this.noaccountLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MagazineApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Dudes Magazine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label noaccountLabel;
        private System.Windows.Forms.LinkLabel signupLink;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

