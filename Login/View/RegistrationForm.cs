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
using System.Text.RegularExpressions;
using Login.Data;

namespace Login.View
{
    public partial class RegistrationForm : Form
    {

        MySqlTransaction transaction = null;
        MySqlDataReader login = null;


        public RegistrationForm()
        {
            InitializeComponent();
        }





        private bool validateUsername(string username)
        {
            try
            {
               DatabaseConnection.db_connection();
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "select * from accounts where username= @username";
                cmd.Parameters.AddWithValue("@username", username);

                cmd.Connection = DatabaseConnection.connect;
                login = cmd.ExecuteReader();

            }
            catch (MySqlException msqlEx)
            {

                Console.WriteLine("Error: ", msqlEx.ToString());
            }

            if (login.Read()){ return false; }

            if (String.IsNullOrEmpty(username) && username.Length > 5)
            {
                return false;
            }


            else {return true;}
        }





       public static bool validateName(string name)
        {

            if (String.IsNullOrEmpty(name) || name.Length > 15 || (!(Regex.IsMatch(name, @"^[a-zA-Z]+$"))))
            {

                return false;
            }


            else { return true; }
        }





        private bool validateEmail(string email)
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


            if (login.Read()){ return false;}

            else
            {

                if (String.IsNullOrEmpty(email)){ return false; }



                try
                {

                    Regex _regex = new Regex("^((([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])" +
                            "+(\\.([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+)*)|((\\x22)" +
                            "((((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(([\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x7f]|\\x21|[\\x23-\\x5b]|[\\x5d-\\x7e]|" +
                            "[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(\\\\([\\x01-\\x09\\x0b\\x0c\\x0d-\\x7f]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\u" +
                            "FDF0-\\uFFEF]))))*(((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(\\x22)))@((([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|" +
                            "(([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|\\d|" +
                            "[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|[\\u00A0-\\uD7FF\\uF900" +
                            "-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFF" +
                            "EF])))\\.?$", RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled);



                    return _regex.IsMatch(email);


                }


                catch (RegexMatchTimeoutException) {return false;}


            }
        }





        public static bool validateYears(string years)
        {
            if (!(String.IsNullOrEmpty(years)) && years.All(char.IsDigit))

            {

                if (years.Length < 3)


                {
                    int intYears = Int16.Parse(years);

                     return (intYears > 0 && intYears < 100)?true:false;                    
                  
                }

                else {return false;}


            }
            else 

                return false;


        }




      public static  bool matchPasswords(string password, string repeatedPassword)
        {
            
           return (password.Equals(repeatedPassword))?true:false;
           
        }

        public static bool validatePassword(string password)

        {
            return (Regex.IsMatch(password, @"[!#$%&'()*+,-.:;<=>?@[\\\]{}^_`|~]"))? true: false;       


        }



        private void btnRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection.db_connection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = DatabaseConnection.connect;
                

                transaction = cmd.Connection.BeginTransaction();
                cmd.Transaction = transaction;

                cmd.CommandText = "insert into  accounts (username, email, password) values (@username, @email, @password)";
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.ExecuteNonQuery();


                cmd.CommandText = "select ac_id from accounts where username=@user";
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);

                string acctId = null;
                login = cmd.ExecuteReader();
                while (login.Read())
                {
                    acctId = login[0].ToString();
                }
                int accountId = Convert.ToInt32(acctId);
                login.Close();


                cmd.CommandText = "insert into  users (ac_id,name, years, curr_points) values (@acId,@name, @years, @points)";
                cmd.Parameters.AddWithValue("@acId", accountId);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@years", Convert.ToInt32(txtYears.Text));
                cmd.Parameters.AddWithValue("@points", 0);
                cmd.ExecuteNonQuery();


                transaction.Commit();
                MessageBox.Show("Registration succesfull!");
                this.Close();
                LoginForm newForm = new LoginForm();
                newForm.Show();
            }


            catch (MySqlException mysqlEx)
            {

                MessageBox.Show("Registration failed!Try again.");

                try
                {
                    transaction.Rollback();

                }

                catch (MySqlException mysqlExR)
                {
                    Console.WriteLine("Error: ", mysqlExR.ToString());
                }

                Console.WriteLine("Error: ", mysqlEx.ToString());

            }
        }



        // Methods for validating users input

        private void txtName_Validating(object sender, CancelEventArgs e)
        {


            string errorMsg = "Invalid name.Name can not be empty or contains digits.";

            if (!(validateName(txtName.Text)))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtName.Select(0, txtName.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errProviderName.SetError(txtName, errorMsg);
            }

        }



        private void txtName_Validated(object sender, System.EventArgs e)
        {

            errProviderName.SetError(txtName, "");
        }



        private void txtYears_Validated(object sender, EventArgs e)
        {
            errProviderAge.SetError(txtYears, "");
        }



        private void txtYears_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Invalid age.Age must be between 1 and 100.";

            if (!(validateYears(txtYears.Text)))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtYears.Select(0, txtYears.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errProviderAge.SetError(txtYears, errorMsg);
            }
        }




        private void txtEmail_Validated(object sender, EventArgs e)
        {
            errProviderEmail.SetError(txtEmail, "");
        }



        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Invalid email.";


            if (!(validateEmail(txtEmail.Text)))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtEmail.Select(0, txtEmail.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errProviderEmail.SetError(txtEmail, errorMsg);
            }
        }



        private void txtUsername_Validated(object sender, EventArgs e)
        {
            errProviderUsername.SetError(txtUsername, "");
        }



        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Invalid username.Username already exist or is too long or too short.";

            if (!(validateUsername(txtUsername.Text)))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtUsername.Select(0, txtUsername.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errProviderUsername.SetError(txtUsername, errorMsg);
            }
        }
        


        private void txtPassword_Validated(object sender, EventArgs e)
        {
            errProviderPassword.SetError(txtPassword, "");
        }
        


        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Invalid password.Password must countains at least one digit, one special character, one uppercase letter and be with maximum lengt of 8.";

            if (!(validatePassword(txtPassword.Text)))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtPassword.Select(0, txtPassword.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errProviderPassword.SetError(txtPassword, errorMsg);
            }
        }



        private void txtRepeatPassword_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Passwords does not match!";


            if (!(matchPasswords(txtPassword.Text, txtRepeatPassword.Text)))
            {
                // Cancel the event and select the text to be corrected by the user.
               
                txtPassword.Select(0, txtPassword.Text.Length);
                txtRepeatPassword.Select(0, txtRepeatPassword.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errProviderPassword.SetError(txtPassword, errorMsg);
                this.errProviderMatchingPasswords.SetError(txtRepeatPassword, errorMsg);
            }
        }


        private void txtRepeatPassword_Validated(object sender, EventArgs e)
        {
            errProviderMatchingPasswords.SetError(txtRepeatPassword, "");
            errProviderPassword.SetError(txtPassword, "");
        }


    }
}
