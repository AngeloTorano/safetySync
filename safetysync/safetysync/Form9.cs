using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace safetysync
{
    public partial class Form9 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");

        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (comboBox1.Text == "ALL")
                {
                    string query =
                    "SELECT safetysync.province.province_id, safetysync.province.provinceName, " +
                    "COUNT(DISTINCT safetysync.hotline.hotlineNumber) AS hotlineCount, " +
                    "COUNT(DISTINCT safetysync.hotline.agency) AS agencyCount, " +
                    "COUNT(DISTINCT safetysync.cashistory.catastrophicHistory) AS cashistoryCount " +
                    "FROM safetysync.province " +
                    "INNER JOIN safetysync.hotline ON safetysync.province.province_id = safetysync.hotline.province_id " +
                    "INNER JOIN safetysync.cashistory ON safetysync.province.province_id = safetysync.cashistory.province_id " +
                    "GROUP BY " +
                    "safetysync.province.province_id, " +
                    "safetysync.province.provinceName " +
                    "ORDER BY " +
                    "safetysync.province.provinceName;";


                    //string query =
                    // "SELECT safetysync.province.province_id, safetysync.province.provinceName, " +
                    // "COUNT(DISTINCT safetysync.hotline.hotlineNumber) AS hotlineCount, " +
                    // "COUNT(DISTINCT safetysync.hotline.agency) AS agencyCount, " +
                    // "COUNT(DISTINCT safetysync.cashistory.catastrophicHistory) AS cashistoryCount " +
                    // "FROM safetysync.province " +
                    // "INNER JOIN safetysync.hotline ON safetysync.province.province_id = safetysync.hotline.province_id " +
                    // "INNER JOIN safetysync.cashistory ON safetysync.province.province_id = safetysync.cashistory.province_id " +
                    // "GROUP BY" +
                    // "safetysync.province.province_id, " +
                    // "safetysync.province.provinceName" +
                    // "ORDER BY" +
                    // "safetysync.province.province_id;";

                    using (MySqlCommand com = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(com))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                        dataGridView1.Columns["province_id"].HeaderText = "ID";
                        dataGridView1.Columns["provinceName"].HeaderText = "PROVINCE NAME";
                        dataGridView1.Columns["hotlineCount"].HeaderText = "HOTLINE";
                        dataGridView1.Columns["agencyCount"].HeaderText = "AGENCY";
                        dataGridView1.Columns["cashistoryCount"].HeaderText = "CATASTROPHIC HISTORY";

                    }
                }
                else
                {

                    string query =
                      "SELECT safetysync.province.province_id, safetysync.province.provinceName, " +
                      "COUNT(DISTINCT safetysync.hotline.hotlineNumber) AS hotlineCount, " +
                      "COUNT(DISTINCT safetysync.hotline.agency) AS agencyCount, " +
                      "COUNT(DISTINCT safetysync.cashistory.catastrophicHistory) AS cashistoryCount " +
                      "FROM safetysync.province " +
                      "INNER JOIN safetysync.hotline ON safetysync.province.province_id = safetysync.hotline.province_id " +
                      "INNER JOIN safetysync.cashistory ON safetysync.province.province_id = safetysync.cashistory.province_id " +
                      "WHERE safetysync.province.provinceName = @province " +
                      "GROUP BY " +
                      "safetysync.province.province_id, safetysync.province.provinceName;";


                    using (MySqlCommand com = new MySqlCommand(query, connection))
                    {
                        com.Parameters.AddWithValue("@province", comboBox1.Text);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(com))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                        dataGridView1.Columns["province_id"].HeaderText = "ID";
                        dataGridView1.Columns["provinceName"].HeaderText = "PROVINCE NAME";
                        dataGridView1.Columns["hotlineCount"].HeaderText = "HOTLINE";
                        dataGridView1.Columns["agencyCount"].HeaderText = "AGENCY";
                        dataGridView1.Columns["cashistoryCount"].HeaderText = "CATASTROPHIC HISTORY";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
