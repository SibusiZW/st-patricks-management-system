using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stPatricksSys
{
    public partial class pass : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;database=school");
        public pass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
                MySqlCommand cmd = new MySqlCommand("INSERT INTO pass (id, purpose, givenTo, issuedBy) VALUES (@id, @type, @gt, @ib)", conn);
                int i;
                Random rand = new Random();
                string id = "P" + rand.Next(1, 100).ToString();

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@type", txtType.Text);
                cmd.Parameters.AddWithValue("@gt", txtGivenTo.Text);
                cmd.Parameters.AddWithValue("@ib", txtIssuedBy.Text);

                i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show(id + " provided succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pass provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            bindData();
        }

        private void pass_Load(object sender, EventArgs e)
        {
            bindData();
        }
        private void bindData()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM pass", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            txtType.Clear();
            txtGivenTo.Clear();
            txtIssuedBy.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
