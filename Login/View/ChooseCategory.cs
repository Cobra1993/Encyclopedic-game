using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.View;

namespace Login.View
{
    public partial class ChooseCategory : Form
    {
        public ChooseCategory()
        {
            InitializeComponent();
        }

        private void ChooseCategory_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.AntiqueWhite;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnAstronomy_Click(object sender, EventArgs e)
        {

            AstonomyTests newForm = new AstonomyTests();
            this.Hide();
            newForm.Show();
        }

        private void btnBulgarianLanguage_Click(object sender, EventArgs e)
        {
            BulgarianLanguage newForm = new BulgarianLanguage();
            this.Hide();
            newForm.Show();
        }

        private void btnBilogy_Click(object sender, EventArgs e)
        {
            Biology newForm = new Biology();
            this.Hide();
            newForm.Show();
        }

        private void btnGeography_Click(object sender, EventArgs e)
        {
            Geography newForm = new Geography();
            this.Hide();
            newForm.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History newForm = new History();
            this.Hide();
            newForm.Show();
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            IT newForm = new IT();
            this.Hide();
            newForm.Show();
        }




    }
}
