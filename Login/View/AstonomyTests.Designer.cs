namespace Login.View
{
    partial class AstonomyTests
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
            this.grbArticleNameTest = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grbArticleNameTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbArticleNameTest
            // 
            this.grbArticleNameTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grbArticleNameTest.Controls.Add(this.textBox1);
            this.grbArticleNameTest.Controls.Add(this.button4);
            this.grbArticleNameTest.Controls.Add(this.button3);
            this.grbArticleNameTest.Controls.Add(this.button2);
            this.grbArticleNameTest.Controls.Add(this.button1);
            this.grbArticleNameTest.Location = new System.Drawing.Point(34, 25);
            this.grbArticleNameTest.Name = "grbArticleNameTest";
            this.grbArticleNameTest.Size = new System.Drawing.Size(200, 297);
            this.grbArticleNameTest.TabIndex = 2;
            this.grbArticleNameTest.TabStop = false;
            this.grbArticleNameTest.Text = "ArticleName tests";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBox1.Location = new System.Drawing.Point(6, 212);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 75);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Difficilty:\r\nGreen : EASY (25 points)\r\nYellow: MEDIUM (50 points)\r\nBlue:  DIFFICU" +
    "LT (75 points)\r\nRed: VERY DIFFICULT (100 points)";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(6, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Begin Test";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(6, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Begin Test";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(6, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Begin Test";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(6, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Begin Test";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AstonomyTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(263, 346);
            this.Controls.Add(this.grbArticleNameTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AstonomyTests";
            this.Text = "AstonomyTests";
            this.grbArticleNameTest.ResumeLayout(false);
            this.grbArticleNameTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbArticleNameTest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}