namespace Login.View
{
    partial class UpdateAccount
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
            this.grpBoxNewData = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtRepeatNewPassword = new System.Windows.Forms.TextBox();
            this.errProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderYears = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderCorrectPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderMatchingPasswords = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderNewPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxNewData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderCorrectPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderMatchingPasswords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderNewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxNewData
            // 
            this.grpBoxNewData.Controls.Add(this.label3);
            this.grpBoxNewData.Controls.Add(this.label2);
            this.grpBoxNewData.Controls.Add(this.label1);
            this.grpBoxNewData.Controls.Add(this.lblUsername);
            this.grpBoxNewData.Controls.Add(this.txtYears);
            this.grpBoxNewData.Controls.Add(this.txtEmail);
            this.grpBoxNewData.Controls.Add(this.txtName);
            this.grpBoxNewData.Controls.Add(this.txtUsername);
            this.grpBoxNewData.Location = new System.Drawing.Point(34, 25);
            this.grpBoxNewData.Name = "grpBoxNewData";
            this.grpBoxNewData.Size = new System.Drawing.Size(239, 163);
            this.grpBoxNewData.TabIndex = 0;
            this.grpBoxNewData.TabStop = false;
            this.grpBoxNewData.Text = "Change account`s details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Years: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(42, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username: ";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(133, 111);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(100, 20);
            this.txtYears.TabIndex = 4;
            this.txtYears.Validating += new System.ComponentModel.CancelEventHandler(this.txtYears_Validating);
            this.txtYears.Validated += new System.EventHandler(this.txtYears_Validated);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(133, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(133, 33);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(228, 229);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(125, 23);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Controls.Add(this.txtCurrentPassword);
            this.groupBox1.Controls.Add(this.txtRepeatNewPassword);
            this.groupBox1.Location = new System.Drawing.Point(304, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change password:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "New password: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Repeat new password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Current password: ";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(193, 59);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '•';
            this.txtNewPassword.Size = new System.Drawing.Size(100, 20);
            this.txtNewPassword.TabIndex = 15;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            this.txtNewPassword.Validated += new System.EventHandler(this.txtNewPassword_Validated);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(193, 33);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '•';
            this.txtCurrentPassword.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentPassword.TabIndex = 13;
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            this.txtCurrentPassword.Validated += new System.EventHandler(this.txtCurrentPassword_Validated);
            // 
            // txtRepeatNewPassword
            // 
            this.txtRepeatNewPassword.Location = new System.Drawing.Point(193, 85);
            this.txtRepeatNewPassword.Name = "txtRepeatNewPassword";
            this.txtRepeatNewPassword.PasswordChar = '•';
            this.txtRepeatNewPassword.Size = new System.Drawing.Size(100, 20);
            this.txtRepeatNewPassword.TabIndex = 14;
            this.txtRepeatNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtRepeatNewPassword_Validating);
            this.txtRepeatNewPassword.Validated += new System.EventHandler(this.txtRepeatNewPassword_Validated);
            // 
            // errProviderName
            // 
            this.errProviderName.ContainerControl = this;
            // 
            // errProviderYears
            // 
            this.errProviderYears.ContainerControl = this;
            // 
            // errProviderCorrectPassword
            // 
            this.errProviderCorrectPassword.ContainerControl = this;
            // 
            // errProviderMatchingPasswords
            // 
            this.errProviderMatchingPasswords.ContainerControl = this;
            // 
            // errProviderNewPassword
            // 
            this.errProviderNewPassword.ContainerControl = this;
            // 
            // UpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxNewData);
            this.Controls.Add(this.btnSaveChanges);
            this.Name = "UpdateAccount";
            this.Text = "UpdateAccount";
            this.grpBoxNewData.ResumeLayout(false);
            this.grpBoxNewData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderCorrectPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderMatchingPasswords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderNewPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxNewData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtRepeatNewPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errProviderName;
        private System.Windows.Forms.ErrorProvider errProviderYears;
        private System.Windows.Forms.ErrorProvider errProviderCorrectPassword;
        private System.Windows.Forms.ErrorProvider errProviderMatchingPasswords;
        private System.Windows.Forms.ErrorProvider errProviderNewPassword;
    }
}