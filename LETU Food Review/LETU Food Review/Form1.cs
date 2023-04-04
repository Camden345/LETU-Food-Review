using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LETU_Food_Review
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            corner1.Show();
            corner1.BringToFront();

            hive1.Hide();
            account1.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hive1.Hide();
            corner1.Hide();
            account1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hive1.Show();
            hive1.BringToFront();

            corner1.Hide();
            account1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            account1.Show();
            account1.BringToFront();

            corner1.Hide();
            hive1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hive1.Hide();
            corner1.Hide();
            account1.Hide();
        }

        private void account1_Load(object sender, EventArgs e)
        {

        }
    }
}
