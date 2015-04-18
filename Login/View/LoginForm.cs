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
using Login.View;






namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.AntiqueWhite;
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            this.ForeColor = System.Drawing.Color.ForestGreen;
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
        

        private bool validate_login(string user, string pass)
        {
            Login.Data.DatabaseConnection.db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from accounts where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = Login.Data.DatabaseConnection.connect;
            MySqlDataReader login = cmd.ExecuteReader();


          
            
            if (login.Read())
            {
                Login.Data.DatabaseConnection.connect.Close();
                return true;
            }
            else
            {
                Login.Data.DatabaseConnection.connect.Close();
                return false;
            }
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            string user = txtBoxUserName.Text;
            string pass = txtBoxPassword.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                return;
            }
            bool r = validate_login(user, pass);
            if (r)
            {
                MessageBox.Show("Enjoy the Game!");
                this.Hide();
                ChooseCategory newForm = new ChooseCategory();
                newForm.Show();

            }
            else
                MessageBox.Show("Incorrect Login Credentials");
        }

        private void linkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            RegistrationForm regForm = new RegistrationForm();
            this.Hide();
            regForm.Show();
        }

        private void linkForgottenPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgottenPassword forgotenPassForm = new ForgottenPassword();
            this.Hide();
            forgotenPassForm.Show();
        }
        }




    }

