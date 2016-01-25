namespace LibrarySystem
{
    partial class Login
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
            this.loginBtn = new MetroFramework.Controls.MetroButton();
            this.usernameLbl = new MetroFramework.Controls.MetroLabel();
            this.usernameBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordLbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(101, 213);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(106, 43);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseSelectable = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(64, 81);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(68, 19);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username";
            // 
            // usernameBox
            // 
            // 
            // 
            // 
            this.usernameBox.CustomButton.Image = null;
            this.usernameBox.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.usernameBox.CustomButton.Name = "";
            this.usernameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameBox.CustomButton.TabIndex = 1;
            this.usernameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameBox.CustomButton.UseSelectable = true;
            this.usernameBox.CustomButton.Visible = false;
            this.usernameBox.Lines = new string[0];
            this.usernameBox.Location = new System.Drawing.Point(64, 109);
            this.usernameBox.MaxLength = 32767;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameBox.SelectedText = "";
            this.usernameBox.SelectionLength = 0;
            this.usernameBox.SelectionStart = 0;
            this.usernameBox.Size = new System.Drawing.Size(172, 23);
            this.usernameBox.TabIndex = 2;
            this.usernameBox.UseSelectable = true;
            this.usernameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordBox
            // 
            // 
            // 
            // 
            this.passwordBox.CustomButton.Image = null;
            this.passwordBox.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.passwordBox.CustomButton.Name = "";
            this.passwordBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordBox.CustomButton.TabIndex = 1;
            this.passwordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordBox.CustomButton.UseSelectable = true;
            this.passwordBox.CustomButton.Visible = false;
            this.passwordBox.Lines = new string[0];
            this.passwordBox.Location = new System.Drawing.Point(64, 168);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '●';
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.Size = new System.Drawing.Size(172, 23);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.UseSelectable = true;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(64, 141);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(64, 19);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.loginBtn);
            this.Name = "Login";
            this.Resizable = false;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton loginBtn;
        private MetroFramework.Controls.MetroLabel usernameLbl;
        private MetroFramework.Controls.MetroTextBox usernameBox;
        private MetroFramework.Controls.MetroTextBox passwordBox;
        private MetroFramework.Controls.MetroLabel passwordLbl;
    }
}

