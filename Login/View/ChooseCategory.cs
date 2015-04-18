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

        private void btnAstronomy_Click(object sender, EventArgs e)
        {

            Astronomy newForm = new Astronomy();
            this.Close();
            newForm.Show();
        }

        private void btnBulgarianLanguage_Click(object sender, EventArgs e)
        {
            BulgarianLanguage newForm = new BulgarianLanguage();
            this.Close();
            newForm.Show();
        }

        private void btnBilogy_Click(object sender, EventArgs e)
        {
            Biology newForm = new Biology();
            this.Close();
            newForm.Show();
        }

        private void btnGeography_Click(object sender, EventArgs e)
        {
            Geography newForm = new Geography();
            this.Close();
            newForm.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History newForm = new History();
            this.Close();
            newForm.Show();
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            IT newForm = new IT();
            this.Close();
            newForm.Show();
        }

        private void btnEngennering_Click(object sender, EventArgs e)
        {
            Engeneering newForm = new Engeneering();
            this.Close();
            newForm.Show();
        }

        private void btnArtStudies_Click(object sender, EventArgs e)
        {
            ArtStudies newForm = new ArtStudies();
            this.Close();
            newForm.Show();
        }

        private void btnCinema_Click(object sender, EventArgs e)
        {
            Cinema newForm = new Cinema();
            this.Close();
            newForm.Show();
        }

        private void btnLiterature_Click(object sender, EventArgs e)
        {
            Literature newForm = new Literature();
            this.Close();
            newForm.Show();
        }

        private void btnLogicTasks_Click(object sender, EventArgs e)
        {
            LogicTasks newForm = new LogicTasks();
            this.Close();
            newForm.Show();
        }

        private void btnMathematics_Click(object sender, EventArgs e)
        {
            Mathematics newForm = new Mathematics();
            this.Close();
            newForm.Show();
        }

        private void btnPsychology_Click(object sender, EventArgs e)
        {
            Psychology newForm = new Psychology();
            this.Close();
            newForm.Show();
        }

        private void btnMythsAndLegends_Click(object sender, EventArgs e)
        {
            MythsAndLegends newForm = new MythsAndLegends();
            this.Close();
            newForm.Show();
        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
            Law newForm = new Law();
            this.Close();
            newForm.Show();
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            Accounting newForm = new Accounting();
            this.Close();
            newForm.Show();
        }

        private void btnPhysics_Click(object sender, EventArgs e)
        {
            Physics newForm = new Physics();
            this.Close();
            newForm.Show();
        }

        private void btnPhilospophy_Click(object sender, EventArgs e)
        {
            Philosophy newForm = new Philosophy();
            this.Close();
            newForm.Show();
        }

        private void btnChemistry_Click(object sender, EventArgs e)
        {
            Chemistry newForm = new Chemistry();
            this.Close();
            newForm.Show();
        }

        private void btnForeignLanguages_Click(object sender, EventArgs e)
        {
            ForeignLanguages newForm = new ForeignLanguages();
            this.Close();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            this.Close();
            statistics.Show();
        }

        private void btnGoToProfile_Click(object sender, EventArgs e)
        {
            UpdateAccount ua = new UpdateAccount();
            this.Close();
            ua.Show();
        }


    }
}
