using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stPatricksSys
{
    public partial class admindashboard : Form
    {
        public admindashboard()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 newform = new Form3();
            newform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 newform = new Form4();
            newform.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            adminlogin newform = new adminlogin();
            newform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: Tafadzwa Sibanda\nMade for St Patrick's High\nMade with: C#\nPowered by: Sibusi", "About System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 newform = new Form5();
            newform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            pass newform = new pass();
            newform.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            users newform = new users();
            newform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 newform = new Form6();
            newform.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
