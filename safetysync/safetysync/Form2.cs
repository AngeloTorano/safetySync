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
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox2.Text == "ALL")
                {
                    string query = "SELECT disasterEvent, catastrophicHistory, category FROM safetysync.cashistory WHERE provinceName = @proName";

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
                        dataGridView1.Columns["disasterEvent"].HeaderText = "DISASTER EVENT";
                        dataGridView1.Columns["catastrophicHistory"].HeaderText = "CATASTROPHIC HISTORY";
                        dataGridView1.Columns["category"].HeaderText = "CATEGORY";

                    }
                }
                else
                {
                    string query = "SELECT disasterEvent, catastrophicHistory, category FROM safetysync.cashistory WHERE disasterEvent = @event AND provinceName = @proName";

                    using (MySqlCommand com = new MySqlCommand(query, connection))
                    {
                        com.Parameters.AddWithValue("@event", comboBox2.Text);
                        com.Parameters.AddWithValue("@proName", comboBox1.Text);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(com))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                        dataGridView1.Columns["disasterEvent"].HeaderText = "DISASTER EVENT";
                        dataGridView1.Columns["catastrophicHistory"].HeaderText = "CATASTROPHIC HISTORY";
                        dataGridView1.Columns["category"].HeaderText = "CATEGORY";

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
