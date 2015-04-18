namespace Login.View
{
    partial class ForgottenPassword
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
            this.btnSendPassword = new System.Windows.Forms.Button();
            this.lblEmailFP = new System.Windows.Forms.Label();
            this.txtEmailFP = new System.Windows.Forms.TextBox();
            this.grpBoxForgottenPassword = new System.Windows.Forms.GroupBox();
            this.grpBoxForgottenPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendPassword
            // 
            this.btnSendPassword.Location = new System.Drawing.Point(71, 51);
            this.btnSendPassword.Name = "btnSendPassword";
            this.btnSendPassword.Size = new System.Drawing.Size(121, 23);
            this.btnSendPassword.TabIndex = 0;
            this.btnSendPassword.Text = "Send password";
            this.btnSendPassword.UseVisualStyleBackColor = true;
            this.btnSendPassword.Click += new System.EventHandler(this.btnSendPassword_Click);
            // 
            // lblEmailFP
            // 
            this.lblEmailFP.AutoSize = true;
            this.lblEmailFP.Location = new System.Drawing.Point(15, 16);
            this.lblEmailFP.Name = "lblEmailFP";
            this.lblEmailFP.Size = new System.Drawing.Size(38, 13);
            this.lblEmailFP.TabIndex = 1;
            this.lblEmailFP.Text = "Email: ";
            // 
            // txtEmailFP
            // 
            this.txtEmailFP.Location = new System.Drawing.Point(71, 16);
            this.txtEmailFP.Name = "txtEmailFP";
            this.txtEmailFP.Size = new System.Drawing.Size(132, 20);
            this.txtEmailFP.TabIndex = 2;
            // 
            // grpBoxForgottenPassword
            // 
            this.grpBoxForgottenPassword.Controls.Add(this.lblEmailFP);
            this.grpBoxForgottenPassword.Controls.Add(this.txtEmailFP);
            this.grpBoxForgottenPassword.Controls.Add(this.btnSendPassword);
            this.grpBoxForgottenPassword.Location = new System.Drawing.Point(12, 24);
            this.grpBoxForgottenPassword.Name = "grpBoxForgottenPassword";
            this.grpBoxForgottenPassword.Size = new System.Drawing.Size(222, 103);
            this.grpBoxForgottenPassword.TabIndex = 3;
            this.grpBoxForgottenPassword.TabStop = false;
            // 
            // ForgottenPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(257, 151);
            this.Controls.Add(this.grpBoxForgottenPassword);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ForgottenPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgottenPassword";
            this.grpBoxForgottenPassword.ResumeLayout(false);
            this.grpBoxForgottenPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendPassword;
        private System.Windows.Forms.Label lblEmailFP;
        private System.Windows.Forms.TextBox txtEmailFP;
        private System.Windows.Forms.GroupBox grpBoxForgottenPassword;
    }
}