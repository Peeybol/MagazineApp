namespace MagazineGUI
{
    partial class SignUpForm
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
            this.signUp_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.repeatePas_label = new System.Windows.Forms.Label();
            this.repPass_txt = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.aof_label = new System.Windows.Forms.Label();
            this.aof_txt = new System.Windows.Forms.TextBox();
            this.spam_checkbox = new System.Windows.Forms.CheckBox();
            this.signUp_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.passwordError_label = new System.Windows.Forms.Label();
            this.emailError_label = new System.Windows.Forms.Label();
            this.passwordInfoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signUp_label
            // 
            this.signUp_label.AutoSize = true;
            this.signUp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_label.Location = new System.Drawing.Point(163, 32);
            this.signUp_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signUp_label.Name = "signUp_label";
            this.signUp_label.Size = new System.Drawing.Size(130, 36);
            this.signUp_label.TabIndex = 0;
            this.signUp_label.Text = "Sign Up";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(40, 95);
            this.id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(205, 24);
            this.id_label.TabIndex = 1;
            this.id_label.Text = "Identification Document";
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.Location = new System.Drawing.Point(44, 121);
            this.id_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(382, 26);
            this.id_txt.TabIndex = 2;
            this.id_txt.TextChanged += new System.EventHandler(this.Id_txt_TextChanged);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(40, 159);
            this.name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(61, 24);
            this.name_label.TabIndex = 3;
            this.name_label.Text = "Name";
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_label.Location = new System.Drawing.Point(40, 225);
            this.surname_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(87, 24);
            this.surname_label.TabIndex = 4;
            this.surname_label.Text = "Surname";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(44, 185);
            this.name_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(382, 26);
            this.name_txt.TabIndex = 5;
            this.name_txt.TextChanged += new System.EventHandler(this.Name_txt_TextChanged);
            // 
            // surname_txt
            // 
            this.surname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_txt.Location = new System.Drawing.Point(44, 251);
            this.surname_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(382, 26);
            this.surname_txt.TabIndex = 6;
            this.surname_txt.TextChanged += new System.EventHandler(this.Surname_txt_TextChanged);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(40, 291);
            this.username_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(97, 24);
            this.username_label.TabIndex = 7;
            this.username_label.Text = "Username";
            // 
            // username_txt
            // 
            this.username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.Location = new System.Drawing.Point(44, 317);
            this.username_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(382, 26);
            this.username_txt.TabIndex = 8;
            this.username_txt.TextChanged += new System.EventHandler(this.Username_txt_TextChanged);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(40, 358);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(92, 24);
            this.password_label.TabIndex = 9;
            this.password_label.Text = "Password";
            // 
            // pass_txt
            // 
            this.pass_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.Location = new System.Drawing.Point(44, 384);
            this.pass_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '♡';
            this.pass_txt.Size = new System.Drawing.Size(382, 26);
            this.pass_txt.TabIndex = 10;
            this.pass_txt.TextChanged += new System.EventHandler(this.Pass_txt_TextChanged);
            // 
            // repeatePas_label
            // 
            this.repeatePas_label.AutoSize = true;
            this.repeatePas_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatePas_label.Location = new System.Drawing.Point(40, 422);
            this.repeatePas_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.repeatePas_label.Name = "repeatePas_label";
            this.repeatePas_label.Size = new System.Drawing.Size(157, 24);
            this.repeatePas_label.TabIndex = 11;
            this.repeatePas_label.Text = "Repeat Password";
            // 
            // repPass_txt
            // 
            this.repPass_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repPass_txt.Location = new System.Drawing.Point(44, 448);
            this.repPass_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.repPass_txt.Name = "repPass_txt";
            this.repPass_txt.PasswordChar = '♡';
            this.repPass_txt.Size = new System.Drawing.Size(382, 26);
            this.repPass_txt.TabIndex = 12;
            this.repPass_txt.Leave += new System.EventHandler(this.RepPass_txt_Leave);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(40, 493);
            this.email_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(57, 24);
            this.email_label.TabIndex = 13;
            this.email_label.Text = "Email";
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(44, 519);
            this.email_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(382, 26);
            this.email_txt.TabIndex = 14;
            this.email_txt.Leave += new System.EventHandler(this.Email_txt_Leave);
            // 
            // aof_label
            // 
            this.aof_label.AutoSize = true;
            this.aof_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aof_label.Location = new System.Drawing.Point(40, 570);
            this.aof_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aof_label.Name = "aof_label";
            this.aof_label.Size = new System.Drawing.Size(158, 24);
            this.aof_label.TabIndex = 15;
            this.aof_label.Text = " Areas of Interests";
            // 
            // aof_txt
            // 
            this.aof_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aof_txt.Location = new System.Drawing.Point(44, 596);
            this.aof_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aof_txt.Name = "aof_txt";
            this.aof_txt.Size = new System.Drawing.Size(382, 26);
            this.aof_txt.TabIndex = 16;
            this.aof_txt.TextChanged += new System.EventHandler(this.Aof_txt_TextChanged);
            // 
            // spam_checkbox
            // 
            this.spam_checkbox.AutoSize = true;
            this.spam_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spam_checkbox.Location = new System.Drawing.Point(65, 648);
            this.spam_checkbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spam_checkbox.Name = "spam_checkbox";
            this.spam_checkbox.Size = new System.Drawing.Size(367, 21);
            this.spam_checkbox.TabIndex = 17;
            this.spam_checkbox.Text = "I would like to recieve emails according to my interests";
            this.spam_checkbox.UseVisualStyleBackColor = true;
            // 
            // signUp_button
            // 
            this.signUp_button.Enabled = false;
            this.signUp_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_button.Location = new System.Drawing.Point(232, 690);
            this.signUp_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 16);
            this.signUp_button.Name = "signUp_button";
            this.signUp_button.Size = new System.Drawing.Size(93, 32);
            this.signUp_button.TabIndex = 18;
            this.signUp_button.Text = "Sign Up";
            this.signUp_button.UseVisualStyleBackColor = true;
            this.signUp_button.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(329, 690);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 16);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(95, 32);
            this.cancel_button.TabIndex = 19;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // passwordError_label
            // 
            this.passwordError_label.AutoSize = true;
            this.passwordError_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordError_label.ForeColor = System.Drawing.Color.Red;
            this.passwordError_label.Location = new System.Drawing.Point(40, 474);
            this.passwordError_label.Name = "passwordError_label";
            this.passwordError_label.Size = new System.Drawing.Size(162, 17);
            this.passwordError_label.TabIndex = 20;
            this.passwordError_label.Text = "Passwords do not match";
            this.passwordError_label.Visible = false;
            // 
            // emailError_label
            // 
            this.emailError_label.AutoSize = true;
            this.emailError_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailError_label.ForeColor = System.Drawing.Color.Red;
            this.emailError_label.Location = new System.Drawing.Point(45, 546);
            this.emailError_label.Name = "emailError_label";
            this.emailError_label.Size = new System.Drawing.Size(163, 17);
            this.emailError_label.TabIndex = 21;
            this.emailError_label.Text = "Email format is incorrect.";
            this.emailError_label.Visible = false;
            // 
            // passwordInfoButton
            // 
            this.passwordInfoButton.Location = new System.Drawing.Point(431, 384);
            this.passwordInfoButton.Name = "passwordInfoButton";
            this.passwordInfoButton.Size = new System.Drawing.Size(25, 26);
            this.passwordInfoButton.TabIndex = 20;
            this.passwordInfoButton.Text = "?";
            this.passwordInfoButton.UseVisualStyleBackColor = true;
            this.passwordInfoButton.Click += new System.EventHandler(this.PasswordInfoButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 26);
            this.button1.TabIndex = 21;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AreasInterestButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 757);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordInfoButton);
            this.Controls.Add(this.emailError_label);
            this.Controls.Add(this.passwordError_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.signUp_button);
            this.Controls.Add(this.spam_checkbox);
            this.Controls.Add(this.aof_txt);
            this.Controls.Add(this.aof_label);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.repPass_txt);
            this.Controls.Add(this.repeatePas_label);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.surname_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.surname_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.signUp_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signUp_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label surname_label;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox surname_txt;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label repeatePas_label;
        private System.Windows.Forms.TextBox repPass_txt;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label aof_label;
        private System.Windows.Forms.TextBox aof_txt;
        private System.Windows.Forms.CheckBox spam_checkbox;
        private System.Windows.Forms.Button signUp_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button passwordInfoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label passwordError_label;
        private System.Windows.Forms.Label emailError_label;
    }
}