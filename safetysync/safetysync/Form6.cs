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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.TopLevel = false;
            panel1.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.TopLevel = false;
            panel1.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.TopLevel = false;
            panel1.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form9 newForm = new Form9();
            newForm.TopLevel = false;
            panel1.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to leave the admin interface?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 newForm = new Form1();
                newForm.Show();
            }
        }
    }
}
