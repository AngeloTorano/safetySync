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
    public partial class Form8 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");

        private int selectRow;
        private int rowIndex;

        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO safetysync.hotline(agency, hotlineNumber, provinceName, province_id) " +
                               "VALUES (@agency, @hotlineNum, @province, @ID)";

                using (MySqlCommand com = new MySqlCommand(query, connection))
                {
                    connection.Open();

                    com.Parameters.AddWithValue("@agency", comboBox1.Text);
                    com.Parameters.AddWithValue("@hotlineNum", textBox1.Text);
                    com.Parameters.AddWithValue("@province", comboBox2.Text);

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
            string query = "SELECT * FROM safetysync.hotline";

            using (MySqlCommand com = new MySqlCommand(query, connection))
            {

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    dataGridView1.DataSource = dataTable;
                }
                dataGridView1.Columns["hotline_id"].HeaderText = "ID";
                dataGridView1.Columns["agency"].HeaderText = "AGENCY";
                dataGridView1.Columns["hotlineNumber"].HeaderText = "HOTLINE";
                dataGridView1.Columns["provinceName"].HeaderText = "PROVINCE";
                dataGridView1.Columns["province_id"].HeaderText = "PROVINCE ID";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM safetysync.hotline WHERE hotline_id = @ID";

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

        private void button4_Click(object sender, EventArgs e)
        {
            edit();
            int selectRow = dataGridView1.SelectedCells[0].RowIndex;
            int rowIndex = dataGridView1.SelectedCells[0].ColumnIndex;

            var cell = dataGridView1.Rows[selectRow].Cells[rowIndex];
            if (cell.Value != null)
            {
                var editedValue = cell.Value.ToString();
                string columnName = dataGridView1.Columns[rowIndex].Name;

                try
                {
                    string query = $"UPDATE safetysync.hotline SET `{columnName}` = @editedValue WHERE hotline_id = @ID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        cmd.Parameters.AddWithValue("@editedValue", editedValue);
                        cmd.Parameters.AddWithValue("@ID", dataGridView1.Rows[selectRow].Cells["hotline_id"].Value);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Updated!");
                            cell.Value = editedValue;
                            cell.Style.BackColor = Color.Red;
                        }
                        else
                        {
                            MessageBox.Show("No rows updated. Check your primary key value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }

                dataGridView1.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Please enter a value to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

    }
}
