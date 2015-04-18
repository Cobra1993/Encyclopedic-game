using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.View
{
    public partial class AstonomyTests : Form
    {
        public AstonomyTests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ExampleAriticle newArticle = new ExampleAriticle();
            MessageBox.Show(this.Name);
            newArticle.Name = "Test1";
            newArticle.Text = "Article 1";
            newArticle.Show();
        }

    }
}
