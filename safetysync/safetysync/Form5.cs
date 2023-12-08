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
    public partial class Form5 : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
        private int selectRow;
        private int rowIndex;
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_saveuser_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_pass.Text) || string.IsNullOrEmpty(txt_username.Text))
                {
                    MessageBox.Show("Fill up");
                }
                else
                {
                    MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM safetysync.admin_accounts WHERE adminusername = @UserName", connection);

                    cmd1.Parameters.AddWithValue("@UserName", txt_username.Text);

                    bool accountIsRegister = true;

                    using (var dr1 = cmd1.ExecuteReader())
                        if (accountIsRegister = dr1.HasRows)
                        {
                            MessageBox.Show("Username is already been used, please use different username");
                            txt_username.Text = string.Empty;
                            txt_name.Text = string.Empty;
                            txt_pass.Text = string.Empty;
                        }

                    if (!(accountIsRegister))
                    {
                        string password = HashPassword(txt_pass.Text);

                        string query = "INSERT INTO safetysync.admin_accounts (name, adminusername, adminpassword) " +
                                       "VALUES (@name, @username, @password)";
                        using (MySqlCommand com = new MySqlCommand(query, connection))
                        {
                            com.Parameters.AddWithValue("@name", txt_name.Text);
                            com.Parameters.AddWithValue("@username", txt_username.Text);
                            com.Parameters.AddWithValue("@password", password);

                            int affectedRows = com.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Data Saved!");

                            }
                            else
                            {
                                MessageBox.Show("Failed to save data. Please try again.");
                            }
                        }
                        txt_name.Text = string.Empty;
                        txt_pass.Text = string.Empty;
                        txt_username.Text = string.Empty;
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

        private void refresh_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM safetysync.admin_accounts";

            using (MySqlCommand com = new MySqlCommand(query, connection))
            {

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                dataGridView1.Columns["admin_id"].HeaderText = "ID";
                dataGridView1.Columns["name"].HeaderText = "NAME";
                dataGridView1.Columns["adminusername"].HeaderText = "USERNAME";
                dataGridView1.Columns["adminpassword"].HeaderText = "PASSWORD";
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string connection = "datasource=localhost;port=3306;username=root;password=''";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var dataID = int.Parse(dataGridView1.SelectedRows[0].Cells["admin_id"].FormattedValue.ToString());

                DialogResult result = MessageBox.Show("Do you want to delete this row of data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();
                        string query = "DELETE FROM safetysync.admin_accounts WHERE admin_id = @dataID";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@dataID", dataID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Deleted!");
                        conn.Close();
                        dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var editedValue = dataGridView1.Rows[selectRow].Cells[rowIndex].Value.ToString();

                string query = $"UPDATE safetysync.admin_accounts SET `{dataGridView1.Columns[rowIndex].Name}` " +
                               $"= @editedValue WHERE admin_id = @ID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    cmd.Parameters.AddWithValue("@editedValue", editedValue);
                    cmd.Parameters.AddWithValue("@ID", dataGridView1.Rows[selectRow].Cells["admin_id"].Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                dataGridView1.Rows[selectRow].Cells[rowIndex].Style.BackColor = Color.Red;
                dataGridView1.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Please select a cell to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
            }


        }
        public void edit()
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                selectRow = dataGridView1.SelectedCells[0].RowIndex;
                rowIndex = dataGridView1.SelectedCells[0].ColumnIndex;

                dataGridView1.ReadOnly = false;
                dataGridView1.Rows[selectRow].Cells[rowIndex].ReadOnly = false;
                dataGridView1.Rows[selectRow].Cells[rowIndex].Style.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Please select a cell to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 newForm = new Form6();
            newForm.ShowDialog();

        }
    }
}
    

