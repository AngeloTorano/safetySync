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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Hide();
                Form4 newform = new Form4();
                newform.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 newform = new Form10();
            newform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 newform = new Form3();
            newform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newform = new Form2();
            newform.ShowDialog();
        }
    }
}