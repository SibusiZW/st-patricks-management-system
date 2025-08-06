using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace stPatricksSys
{
    public partial class Form6 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;database=school");
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            admindashboard newform = new admindashboard();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO `users` (`user`, `password`) VALUES (@usr, @pass);", conn);
                int i = 0;

                cmd.Parameters.AddWithValue("@usr", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                i = cmd.ExecuteNonQuery();

                if (i > 0) MessageBox.Show("User added succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("No user added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE user=@usr AND password=@pass", conn);
                int i = 0;

                cmd.Parameters.AddWithValue("@usr", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                i = cmd.ExecuteNonQuery();

                if (i > 0) MessageBox.Show("User deleted succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("No user deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
