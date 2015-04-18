namespace Login.View
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.grpBoxRegistrationData = new System.Windows.Forms.GroupBox();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.errProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderAge = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderMatchingPasswords = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxRegistrationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderMatchingPasswords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistration
            // 
            this.btnRegistration.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnRegistration.Location = new System.Drawing.Point(141, 175);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(75, 23);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "Register";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // grpBoxRegistrationData
            // 
            this.grpBoxRegistrationData.Controls.Add(this.lblRepeatPassword);
            this.grpBoxRegistrationData.Controls.Add(this.btnRegistration);
            this.grpBoxRegistrationData.Controls.Add(this.lblPassword);
            this.grpBoxRegistrationData.Controls.Add(this.lblEmail);
            this.grpBoxRegistrationData.Controls.Add(this.lblUsername);
            this.grpBoxRegistrationData.Controls.Add(this.lblYears);
            this.grpBoxRegistrationData.Controls.Add(this.lblNames);
            this.grpBoxRegistrationData.Controls.Add(this.txtRepeatPassword);
            this.grpBoxRegistrationData.Controls.Add(this.txtPassword);
            this.grpBoxRegistrationData.Controls.Add(this.txtUsername);
            this.grpBoxRegistrationData.Controls.Add(this.txtEmail);
            this.grpBoxRegistrationData.Controls.Add(this.txtYears);
            this.grpBoxRegistrationData.Controls.Add(this.txtName);
            this.grpBoxRegistrationData.Location = new System.Drawing.Point(12, 23);
            this.grpBoxRegistrationData.Name = "grpBoxRegistrationData";
            this.grpBoxRegistrationData.Size = new System.Drawing.Size(230, 215);
            this.grpBoxRegistrationData.TabIndex = 1;
            this.grpBoxRegistrationData.TabStop = false;
//            this.grpBoxRegistrationData.Enter += new System.EventHandler(this.grpBoxRegistrationData_Enter);
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRepeatPassword.Location = new System.Drawing.Point(16, 153);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(93, 13);
            this.lblRepeatPassword.TabIndex = 11;
            this.lblRepeatPassword.Text = "Repeat password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPassword.Location = new System.Drawing.Point(16, 131);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblEmail.Location = new System.Drawing.Point(16, 79);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblUsername.Location = new System.Drawing.Point(16, 105);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username:";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblYears.Location = new System.Drawing.Point(16, 53);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(37, 13);
            this.lblYears.TabIndex = 7;
            this.lblYears.Text = "Years:";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNames.Location = new System.Drawing.Point(16, 26);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(38, 13);
            this.lblNames.TabIndex = 6;
            this.lblNames.Text = "Name:";
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(116, 149);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.PasswordChar = '•';
            this.txtRepeatPassword.Size = new System.Drawing.Size(100, 20);
            this.txtRepeatPassword.TabIndex = 5;
            this.txtRepeatPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtRepeatPassword_Validating);
            this.txtRepeatPassword.Validated += new System.EventHandler(this.txtRepeatPassword_Validated);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            this.txtPassword.Validated += new System.EventHandler(this.txtPassword_Validated);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(116, 97);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            this.txtUsername.Validated += new System.EventHandler(this.txtUsername_Validated);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 71);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(116, 45);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(100, 20);
            this.txtYears.TabIndex = 1;
            this.txtYears.Validating += new System.ComponentModel.CancelEventHandler(this.txtYears_Validating);
            this.txtYears.Validated += new System.EventHandler(this.txtYears_Validated);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // errProviderName
            // 
            this.errProviderName.ContainerControl = this;
            this.errProviderName.RightToLeftChanged += new System.EventHandler(this.txtName_Validated);
            // 
            // errProviderAge
            // 
            this.errProviderAge.ContainerControl = this;
            // 
            // errProviderEmail
            // 
            this.errProviderEmail.ContainerControl = this;
            // 
            // errProviderUsername
            // 
            this.errProviderUsername.ContainerControl = this;
            // 
            // errProviderPassword
            // 
            this.errProviderPassword.ContainerControl = this;
            // 
            // errProviderMatchingPasswords
            // 
            this.errProviderMatchingPasswords.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(253, 257);
            this.Controls.Add(this.grpBoxRegistrationData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.grpBoxRegistrationData.ResumeLayout(false);
            this.grpBoxRegistrationData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderMatchingPasswords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.GroupBox grpBoxRegistrationData;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ErrorProvider errProviderName;
        private System.Windows.Forms.ErrorProvider errProviderAge;
        private System.Windows.Forms.ErrorProvider errProviderEmail;
        private System.Windows.Forms.ErrorProvider errProviderUsername;
        private System.Windows.Forms.ErrorProvider errProviderPassword;
        private System.Windows.Forms.ErrorProvider errProviderMatchingPasswords;
    }
}