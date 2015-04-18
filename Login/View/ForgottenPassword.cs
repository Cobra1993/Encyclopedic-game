using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;
using Login.Data;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;



namespace Login.View
{
    public partial class ForgottenPassword : Form
    {

        MySqlDataReader login = null;

        public ForgottenPassword()
        {
            InitializeComponent();
        }


        private string generateRandomPassword()
        {


            String symbols = "QqQqEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlZzXxCcVvBbNnMn123456789@#$%^&*";
            int lenghtOfNewPass = 8;
            String newPassword = "";
            Random rnd = new Random();
            List<int> indexes = new List<int>();

            for (int i = 0; i < lenghtOfNewPass; i++)
            {

                int index = rnd.Next(0, symbols.Length);

                if (!(indexes.Contains(index)))
                {

                    indexes.Add(index);
                    newPassword = newPassword + symbols[index];

                }
                else
                {
                    if (i > 0)
                    {
                        i--;
                    }
                }
            }

            return newPassword;
        }

        private void saveAndSendPassword(string email)
        {

            DatabaseConnection.db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = DatabaseConnection.connect;
            string password = generateRandomPassword();

            cmd.CommandText = "update accounts set password= @password where email=@email";
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();

            sendMail(email, password);
            MessageBox.Show("Check your email.");

        }



        private bool emailExistInDB(string email)
        {

            try
            {

                DatabaseConnection.db_connection();
                MySqlCommand cmd = new MySqlCommand();


                cmd.CommandText = "select * from accounts where email= @email";
                cmd.Parameters.AddWithValue("@email", email);


                cmd.Connection = DatabaseConnection.connect;
                login = cmd.ExecuteReader();


            }
            catch (MySqlException msqlEx)
            {

                Console.WriteLine("Error: ", msqlEx.ToString());
            }


            return login.Read() ? true : false;

        }

        private void sendMail(String email, String newPassword)
        {

            var fromAddress = new MailAddress("encyclopedicgame@gmail.com", "encyclopedicgame team");
            var toAddress = new MailAddress(email);
            const string fromPassword = "encyclopedicgame1*Aa";
            const string subject = "Forgotten password";
            string body = "Hello,\n Your new password is: " + newPassword + ". \nRegards,\n Encyclopedicgame team. ";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };


            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }





        private void btnSendPassword_Click(object sender, EventArgs e)
        {

            if ((emailExistInDB(txtEmailFP.Text)))
            {

                saveAndSendPassword(txtEmailFP.Text);
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

            }

            else MessageBox.Show("This email isn`t register!");
        }
    }
}
