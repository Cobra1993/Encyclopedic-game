namespace Login.View
{
    partial class Statistics
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
            this.richtxtExamName = new System.Windows.Forms.RichTextBox();
            this.lblTopTenPlayears = new System.Windows.Forms.Label();
            this.lblMostPopularExams = new System.Windows.Forms.Label();
            this.richTxtBoxPlayerScores = new System.Windows.Forms.RichTextBox();
            this.richTxtTopTenPlayers = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTxtBoxArticleName = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richtxtExamName
            // 
            this.richtxtExamName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtxtExamName.Enabled = false;
            this.richtxtExamName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richtxtExamName.Location = new System.Drawing.Point(0, 0);
            this.richtxtExamName.Name = "richtxtExamName";
            this.richtxtExamName.Size = new System.Drawing.Size(105, 180);
            this.richtxtExamName.TabIndex = 2;
            this.richtxtExamName.Text = "";
            this.richtxtExamName.TextChanged += new System.EventHandler(this.richtxtExamName_TextChanged);
            // 
            // lblTopTenPlayears
            // 
            this.lblTopTenPlayears.AutoSize = true;
            this.lblTopTenPlayears.Location = new System.Drawing.Point(13, 34);
            this.lblTopTenPlayears.Name = "lblTopTenPlayears";
            this.lblTopTenPlayears.Size = new System.Drawing.Size(80, 13);
            this.lblTopTenPlayears.TabIndex = 3;
            this.lblTopTenPlayears.Text = "Top ten players";
            // 
            // lblMostPopularExams
            // 
            this.lblMostPopularExams.AutoSize = true;
            this.lblMostPopularExams.Location = new System.Drawing.Point(235, 34);
            this.lblMostPopularExams.Name = "lblMostPopularExams";
            this.lblMostPopularExams.Size = new System.Drawing.Size(101, 13);
            this.lblMostPopularExams.TabIndex = 5;
            this.lblMostPopularExams.Text = "Most popular exams";
            // 
            // richTxtBoxPlayerScores
            // 
            this.richTxtBoxPlayerScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBoxPlayerScores.Enabled = false;
            this.richTxtBoxPlayerScores.Location = new System.Drawing.Point(0, 0);
            this.richTxtBoxPlayerScores.Name = "richTxtBoxPlayerScores";
            this.richTxtBoxPlayerScores.Size = new System.Drawing.Size(74, 180);
            this.richTxtBoxPlayerScores.TabIndex = 0;
            this.richTxtBoxPlayerScores.Text = "";
            // 
            // richTxtTopTenPlayers
            // 
            this.richTxtTopTenPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtTopTenPlayers.Enabled = false;
            this.richTxtTopTenPlayers.Location = new System.Drawing.Point(0, 0);
            this.richTxtTopTenPlayers.Name = "richTxtTopTenPlayers";
            this.richTxtTopTenPlayers.Size = new System.Drawing.Size(74, 180);
            this.richTxtTopTenPlayers.TabIndex = 6;
            this.richTxtTopTenPlayers.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Enabled = false;
            this.splitContainer1.Location = new System.Drawing.Point(12, 64);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTxtTopTenPlayers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTxtBoxPlayerScores);
            this.splitContainer1.Size = new System.Drawing.Size(152, 180);
            this.splitContainer1.SplitterDistance = 74;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Enabled = false;
            this.splitContainer2.Location = new System.Drawing.Point(192, 64);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.richTxtBoxArticleName);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richtxtExamName);
            this.splitContainer2.Size = new System.Drawing.Size(198, 180);
            this.splitContainer2.SplitterDistance = 89;
            this.splitContainer2.TabIndex = 8;
            // 
            // richTxtBoxArticleName
            // 
            this.richTxtBoxArticleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBoxArticleName.Enabled = false;
            this.richTxtBoxArticleName.Location = new System.Drawing.Point(0, 0);
            this.richTxtBoxArticleName.Name = "richTxtBoxArticleName";
            this.richTxtBoxArticleName.Size = new System.Drawing.Size(89, 180);
            this.richTxtBoxArticleName.TabIndex = 0;
            this.richTxtBoxArticleName.Text = "";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(417, 256);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblMostPopularExams);
            this.Controls.Add(this.lblTopTenPlayears);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtExamName;
        private System.Windows.Forms.Label lblTopTenPlayears;
        private System.Windows.Forms.Label lblMostPopularExams;
        private System.Windows.Forms.RichTextBox richTxtBoxPlayerScores;
        private System.Windows.Forms.RichTextBox richTxtTopTenPlayers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox richTxtBoxArticleName;



    }
}