using System;
using MySql.Data.MySqlClient;
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
    public partial class usrdashboard : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;database=school");
        public usrdashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            usrlogin newform = new usrlogin();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: Tafadzwa Sibanda\nMade for St Patrick's High\nMade with: C#\nPowered by: Sibusi", "About System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2();
            form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadStud()
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM students;", conn);
            int count = 0;

            count = Convert.ToInt32(cmd.ExecuteScalar());
            lblStudNum.Text = count.ToString();

            conn.Close();
        }

        private void loadTr()
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM teachers;", conn);
            int count = 0;

            count = Convert.ToInt32(cmd.ExecuteScalar());
            lblTrNum.Text = count.ToString();

            conn.Close();
        }

        private void loadAnc()
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM anc;", conn);
            int count = 0;

            count = Convert.ToInt32(cmd.ExecuteScalar());
            lblAncStaffNum.Text = count.ToString();

            conn.Close();
        }

        private void loadPass()
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM pass;", conn);
            int count = 0;

            count = Convert.ToInt32(cmd.ExecuteScalar());
            lblPassNum.Text = count.ToString();

            conn.Close();
        }

        private void usrdashboard_Load(object sender, EventArgs e)
        {
            loadAnc();
            loadPass();
            loadStud();
            loadTr();
        }
    }
}

