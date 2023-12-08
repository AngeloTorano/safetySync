using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace safetysync
{
    public partial class Form4 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");

        public Form4()
        {
            InitializeComponent();
        }

        private void logIn_Click(object sender, EventArgs e)
        {

            try
            {
                // Open the connection before executing the query
                connection.Open();

                if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text))
                {
                    MessageBox.Show("Fill in both username and password");
                }
                else
                {
                    string enteredUsername = username.Text;
                    string enteredPassword = password.Text;

                    // Hash the entered password
                    string hashedEnteredPassword = HashPassword(enteredPassword);

                    string query = "SELECT * FROM safetysync.admin_accounts WHERE adminusername = @username AND adminpassword = @password";
                    using (MySqlCommand com = new MySqlCommand(query, connection))
                    {
                        com.Parameters.AddWithValue("@username", enteredUsername);
                        com.Parameters.AddWithValue("@password", hashedEnteredPassword);

                        using (MySqlDataReader reader = com.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.Hide();
                                Form6 form6 = new Form6();
                                form6.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username, Password. Please try again.");
                                username.Text = string.Empty;
                                password.Text = string.Empty;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            username.Text = string.Empty;
            password.Text = string.Empty;
        }
    }
}
