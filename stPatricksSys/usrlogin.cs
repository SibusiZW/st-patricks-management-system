using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace stPatricksSys
{
    public partial class usrlogin : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;database=school");
        public usrlogin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try { 
                if (conn.State==ConnectionState.Closed) conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE user=@usr AND password=@passwd", conn);
                MySqlDataReader dr;

                cmd.Parameters.AddWithValue("@usr", txtUser.Text);
                cmd.Parameters.AddWithValue("@passwd", txtPass.Text);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Welcome User", "Login successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usrdashboard newform = new usrdashboard();
                    this.Close();
                    newform.Show();
                    txtPass.Clear();
                    txtUser.Clear();
                    checkBox1.Checked = false;
                }
                else {
                    MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Clear();
                    txtUser.Clear();
                    checkBox1.Checked = false;
                }

                dr.Close();

            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) txtPass.PasswordChar = '\0';
            else txtPass.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
