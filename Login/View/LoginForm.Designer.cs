namespace Login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bttnLogin = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.linkRegistration = new System.Windows.Forms.LinkLabel();
            this.linkForgottenPassword = new System.Windows.Forms.LinkLabel();
            this.groupUserData = new System.Windows.Forms.GroupBox();
            this.pictureWikipedia = new System.Windows.Forms.PictureBox();
            this.groupUserData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWikipedia)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnLogin
            // 
            this.bttnLogin.Location = new System.Drawing.Point(113, 106);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(75, 23);
            this.bttnLogin.TabIndex = 0;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = true;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(28, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Username:";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(88, 24);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUserName.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(88, 60);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPassword.TabIndex = 4;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(28, 63);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // linkRegistration
            // 
            this.linkRegistration.AutoSize = true;
            this.linkRegistration.Location = new System.Drawing.Point(298, 207);
            this.linkRegistration.Name = "linkRegistration";
            this.linkRegistration.Size = new System.Drawing.Size(63, 13);
            this.linkRegistration.TabIndex = 7;
            this.linkRegistration.TabStop = true;
            this.linkRegistration.Text = "Registration";
            this.linkRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistration_LinkClicked);
            // 
            // linkForgottenPassword
            // 
            this.linkForgottenPassword.AutoSize = true;
            this.linkForgottenPassword.Location = new System.Drawing.Point(297, 179);
            this.linkForgottenPassword.Name = "linkForgottenPassword";
            this.linkForgottenPassword.Size = new System.Drawing.Size(101, 13);
            this.linkForgottenPassword.TabIndex = 8;
            this.linkForgottenPassword.TabStop = true;
            this.linkForgottenPassword.Text = "Forgotten Password";
            this.linkForgottenPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgottenPassword_LinkClicked);
            // 
            // groupUserData
            // 
            this.groupUserData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupUserData.Controls.Add(this.txtBoxUserName);
            this.groupUserData.Controls.Add(this.lblUserName);
            this.groupUserData.Controls.Add(this.txtBoxPassword);
            this.groupUserData.Controls.Add(this.lblPassword);
            this.groupUserData.Controls.Add(this.bttnLogin);
            this.groupUserData.Location = new System.Drawing.Point(269, 25);
            this.groupUserData.Name = "groupUserData";
            this.groupUserData.Size = new System.Drawing.Size(211, 142);
            this.groupUserData.TabIndex = 9;
            this.groupUserData.TabStop = false;
            this.groupUserData.Text = "Login";
            this.groupUserData.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // pictureWikipedia
            // 
            this.pictureWikipedia.Image = ((System.Drawing.Image)(resources.GetObject("pictureWikipedia.Image")));
            this.pictureWikipedia.Location = new System.Drawing.Point(-1, -1);
            this.pictureWikipedia.Name = "pictureWikipedia";
            this.pictureWikipedia.Size = new System.Drawing.Size(264, 254);
            this.pictureWikipedia.TabIndex = 10;
            this.pictureWikipedia.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 252);
            this.Controls.Add(this.pictureWikipedia);
            this.Controls.Add(this.groupUserData);
            this.Controls.Add(this.linkForgottenPassword);
            this.Controls.Add(this.linkRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.groupUserData.ResumeLayout(false);
            this.groupUserData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWikipedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel linkRegistration;
        private System.Windows.Forms.LinkLabel linkForgottenPassword;
        private System.Windows.Forms.GroupBox groupUserData;
        private System.Windows.Forms.PictureBox pictureWikipedia;
    }
}

