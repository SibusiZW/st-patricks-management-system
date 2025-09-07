using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stPatricksSys
{
    public partial class admindashboard : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;database=school");
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
            adminstudents newform = new adminstudents();
            newform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            teachers newform = new teachers();
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
            MessageBox.Show("Made by: Tafadzwa Sibanda\nMade for St Patrick's High\nMade with: C#\n Taking up the challenge", "About System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ancillary newform = new ancillary();
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
            regUsers newform = new regUsers();
            newform.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadStud() {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM students;", conn);
            int count = 0;

            count = Convert.ToInt32(cmd.ExecuteScalar());
            lblStudNum.Text = count.ToString();

            conn.Close();
        }

        private void loadTr() {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM teachers;", conn);
            int count = 0;

            count = Convert.ToInt32(cmd.ExecuteScalar());
            lblTrNum.Text = count.ToString();

            conn.Close();
        }

        private void loadAnc() {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM anc;", conn);
            int count = 0;

            count = Convert.ToInt32(cmd.ExecuteScalar());
            lblAncStaffNum.Text = count.ToString();

            conn.Close();
        }

        private void loadPass() {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM pass;", conn);
            int count = 0;

            count = Convert.ToInt32(cmd.ExecuteScalar());
            lblPassNum.Text = count.ToString();

            conn.Close();
        }

        private void admindashboard_Load(object sender, EventArgs e)
        {
            loadStud();
            loadTr();
            loadAnc();
            loadPass();
        }

    }
}
