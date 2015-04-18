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
using Login.Data;

namespace Login.View
{
    public partial class UpdateAccount : Form
    {

        MySqlDataReader data = null;
        MySqlTransaction transaction = null;
   
        public UpdateAccount()
        {
            InitializeComponent();
            fillAllFields();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fillAllFields()
        {
            DatabaseConnection.db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = DatabaseConnection.connect;
            cmd.CommandText = "select username ,email, name, years from accounts inner join users on accounts.ac_id= users.ac_id where username=@username";
            cmd.Parameters.AddWithValue("@username", LoginForm.loggedInPerson);
            data = cmd.ExecuteReader();

            while (data.Read())
            {
                txtUsername.AppendText(data.GetString(0));
                txtEmail.AppendText(data.GetString(1));
                txtName.AppendText(data.GetString(2));
                txtYears.AppendText(data.GetString(3));


            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {

            string errorMsg = "Invalid name.Name can not be empty or contains digits.";

            if (!(RegistrationForm.validateName(txtName.Text)))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtName.Select(0, txtName.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errProviderName.SetError(txtName, errorMsg);
            }
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            errProviderName.SetError(txtName, "");
        }

        private void txtYears_Validated(object sender, EventArgs e)
        {
            errProviderYears.SetError(txtYears, "");
        }

        private void txtYears_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Invalid age.Age must be between 1 and 100.";

            if (!(RegistrationForm.validateYears(txtYears.Text)))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtYears.Select(0, txtYears.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errProviderYears.SetError(txtYears, errorMsg);
            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {

            string errorMsg = "Incorrect password!";
           
            if (!(LoginForm.validate_login(LoginForm.loggedInPerson, txtCurrentPassword.Text)))
            {

                e.Cancel = true;
                txtCurrentPassword.Select(0, txtCurrentPassword.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errProviderCorrectPassword.SetError(txtCurrentPassword, errorMsg);
            }
        }

        private void txtCurrentPassword_Validated(object sender, EventArgs e)
        {
            errProviderCorrectPassword.SetError(txtCurrentPassword, "");
        }

        private void txtNewPassword_Validated(object sender, EventArgs e)
        {
            errProviderNewPassword.SetError(txtNewPassword, "");
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
             string errorMsg = "Invalid password.Password must countains at least one digit, one special character, one uppercase letter and be with maximum lengt of 8.";

            if (!(RegistrationForm.validatePassword(txtNewPassword.Text)))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtNewPassword.Select(0, txtNewPassword.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errProviderNewPassword.SetError(txtNewPassword, errorMsg);
            }
        
        }

        private void txtRepeatNewPassword_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Passwords does not match!";


            if (!(RegistrationForm.matchPasswords(txtNewPassword.Text, txtRepeatNewPassword.Text)))
            {
                // Cancel the event and select the text to be corrected by the user.

                txtNewPassword.Select(0, txtNewPassword.Text.Length);
                txtRepeatNewPassword.Select(0, txtRepeatNewPassword.Text.Length);

                // Set the ErrorProvider error with the text to display.  
           
                this.errProviderMatchingPasswords.SetError(txtRepeatNewPassword, errorMsg);
            }
        }

        private void txtRepeatNewPassword_Validated(object sender, EventArgs e)
        {
            errProviderMatchingPasswords.SetError(txtRepeatNewPassword, "");
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection.db_connection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = DatabaseConnection.connect;


                transaction = cmd.Connection.BeginTransaction();
                cmd.Transaction = transaction;

                cmd.CommandText = "update accounts set password=@password where username=@username";            
                cmd.Parameters.AddWithValue("@password", txtNewPassword.Text);
                cmd.Parameters.AddWithValue("@username", LoginForm.loggedInPerson);
                cmd.ExecuteNonQuery();


                cmd.CommandText = "select ac_id from accounts where username=@user";
                cmd.Parameters.AddWithValue("@user", LoginForm.loggedInPerson);

                string acctId = null;
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    acctId = data[0].ToString();
                }
                int accountId = Convert.ToInt32(acctId);
                data.Close();


                cmd.CommandText = "update users set name=@name, years=@years  where ac_id=@ac_id";
                cmd.Parameters.AddWithValue("@ac_id", accountId);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@years", Convert.ToInt32(txtYears.Text));               
                cmd.ExecuteNonQuery();


                transaction.Commit();
                MessageBox.Show("Changes Accepted!");
                this.Close();
                LoginForm newForm = new LoginForm();
                newForm.Show();
            }


            catch (MySqlException mysqlEx)
            {

                MessageBox.Show("Changes failed!Try again.");

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
    }
}
