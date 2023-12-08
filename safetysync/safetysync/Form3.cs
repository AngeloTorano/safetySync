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
    public partial class Form3 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (comboBox2.Text == "ALL")
                {
                    string query = "SELECT agency, hotlineNumber FROM safetysync.hotline WHERE  provinceName = @proName";

                    using (MySqlCommand com = new MySqlCommand(query, connection))
                    {
                        com.Parameters.AddWithValue("@proName", comboBox1.Text);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(com))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                        dataGridView1.Columns["agency"].HeaderText = "AGENCY";
                        dataGridView1.Columns["hotlineNumber"].HeaderText = "EMERGENCY HOTLINE";
                    }
                }
                else
                {
                    string query = "SELECT agency, hotlineNumber FROM safetysync.hotline WHERE agency = @agency AND provinceName = @proName";

                    using (MySqlCommand com = new MySqlCommand(query, connection))
                    {
                        com.Parameters.AddWithValue("@agency", comboBox2.Text);
                        com.Parameters.AddWithValue("@proName", comboBox1.Text);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(com))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                        dataGridView1.Columns["agency"].HeaderText = "AGENCY";
                        dataGridView1.Columns["hotlineNumber"].HeaderText = "EMERGENCY HOTLINE";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1();
            newForm.ShowDialog();
        }
    }
}
