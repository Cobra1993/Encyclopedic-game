using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Login.Data;

namespace Login.View
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            getTopTenPlayears();
            getTenMostPopularExams();
        }

        MySqlDataReader data = null;

      

        private void getTopTenPlayears() {
            DatabaseConnection.db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = DatabaseConnection.connect;      

            cmd.CommandText = "select username ,curr_points from accounts inner join users on accounts.ac_id= users.ac_id order by curr_points desc limit 10 ";
            data = cmd.ExecuteReader();



            richTxtTopTenPlayers.AppendText("PLAYER \n\n");
            richTxtBoxPlayerScores.AppendText("SCORES \n\n");


            while(data.Read()){
                richTxtTopTenPlayers.AppendText( " "+data.GetString(0)+"\n");
                richTxtBoxPlayerScores.AppendText(" " + data.GetString(1) + "\n");            
              

               
            }
        
        }


        private void getTenMostPopularExams() { 
        
        
       
            DatabaseConnection.db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = DatabaseConnection.connect;      

            cmd.CommandText = "select a_name ,t_name from articles inner join tests on articles.ar_id= tests.ar_id limit 10 ";
            data = cmd.ExecuteReader();



            richTxtBoxArticleName.AppendText("ARTICLE \n\n");
            richtxtExamName.AppendText("EXAM \n\n");


            while(data.Read()){
                richTxtBoxArticleName.AppendText( " "+data.GetString(0)+"\n");
                richtxtExamName.AppendText(" " + data.GetString(1) + "\n");            
              

               
            }
        
        }

        private void richtxtExamName_TextChanged(object sender, EventArgs e)
        {

        }

        
      

        


       
    }
}
