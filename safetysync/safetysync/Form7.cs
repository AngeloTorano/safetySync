using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace safetysync
{
    public partial class Form7 : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
        private int selectRow;
        private int rowIndex;

        public Form7()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            edit();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var editedValue = dataGridView1.Rows[selectRow].Cells[rowIndex].Value.ToString();

                string query = $"UPDATE safetysync.cashistory SET `{dataGridView1.Columns[rowIndex].Name}` " +
                               $"= @editedValue WHERE catastrophicHistory_id = @ID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    cmd.Parameters.AddWithValue("@editedValue", editedValue);
                    cmd.Parameters.AddWithValue("@ID", dataGridView1.Rows[selectRow].Cells["catastrophicHistory_id"].Value);

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

                dataGridView1.Rows[selectRow].Cells[rowIndex].Style.BackColor = Color.Pink;
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
                dataGridView1.Rows[selectRow].Cells[rowIndex].Style.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Please select a cell to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "INSERT INTO safetysync.cashistory(disasterEvent, catastrophicHistory, category, provinceName, province_id) " +
                               "VALUES (@event, @history, @category, @province, @ID)";

                using (MySqlCommand com = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    com.Parameters.AddWithValue("@event", comboBox1.Text);
                    com.Parameters.AddWithValue("@history", textBox1.Text);
                    com.Parameters.AddWithValue("@category", comboBox3.Text);
                    com.Parameters.AddWithValue("@province", comboBox2.Text);

                    // Set the ID parameter based on the selected province
                    switch (comboBox2.Text)
                    {
                        case "Cavite":
                            com.Parameters.AddWithValue("@ID", 1);
                            break;
                        case "Laguna":
                            com.Parameters.AddWithValue("@ID", 2);
                            break;
                        case "Batangas":
                            com.Parameters.AddWithValue("@ID", 3);
                            break;
                        case "Rizal":
                            com.Parameters.AddWithValue("@ID", 4);
                            break;
                        case "Quezon":
                            com.Parameters.AddWithValue("@ID", 5);
                            break;
                        default:

                            break;
                    }

                    com.ExecuteNonQuery();
                    MessageBox.Show("Data saved!");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            textBox1.Text = string.Empty;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM safetysync.cashistory";

            using (MySqlCommand com = new MySqlCommand(query, connection))
            {

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                dataGridView1.Columns["catastrophicHistory_id"].HeaderText = "ID";
                dataGridView1.Columns["disasterEvent"].HeaderText = "EVENT";
                dataGridView1.Columns["catastrophicHistory"].HeaderText = "HISTORY";
                dataGridView1.Columns["category"].HeaderText = "CATEGORY";
                dataGridView1.Columns["provinceName"].HeaderText = "PROVINCE";
                dataGridView1.Columns["province_id"].HeaderText = "PROVINCE ID";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM safetysync.cashistory WHERE catastrophicHistory_id = @ID";

                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                {
                    connection.Open();
                    deleteCommand.Parameters.AddWithValue("@ID", int.Parse(textBox2.Text));
                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data deleted!");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the specified ID.");

                    }
                    textBox2.Text = string.Empty;

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid ID (numeric value).");
                textBox2.Text = string.Empty;
            }
            connection.Close();
        }
    }
}
