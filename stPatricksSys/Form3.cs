using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.Types;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stPatricksSys
{
    public partial class Form3 : Form
    {   
        MySqlConnection conn = new MySqlConnection();
        public Form3()
        {
            InitializeComponent();
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "school";
            builder.AllowZeroDateTime = true;
            builder.ConvertZeroDateTime = true;
            conn.ConnectionString = builder.ToString();
        }
        private void load_data()
        {
            conn.Close();
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students", conn);
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
            clearFields();
        }
        private void clearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtGen.SelectedIndex = 0;
            txtClass.SelectedIndex = 0;
            txtSch.SelectedIndex = 0;
            txtMob.Clear();
            studentImg.Image = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] imageBytes = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream mstream = new MemoryStream(imageBytes);

            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGen.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtClass.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dtpDOB.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            txtSch.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtMob.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            studentImg.Image = System.Drawing.Image.FromStream(mstream);
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO students (sname, gender, class, dob, scholarType, mob, img) VALUES (@name, @gen, @class, @dob, @sch, @mob, @img)", conn);
                int i;
                MemoryStream mstream = new MemoryStream();
                studentImg.Image.Save(mstream, studentImg.Image.RawFormat);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@gen", txtGen.Text);
                cmd.Parameters.AddWithValue("@class", txtClass.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@sch", txtSch.Text);
                cmd.Parameters.AddWithValue("@mob", txtMob.Text);
                cmd.Parameters.AddWithValue("@img", mstream.ToArray());

                i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Record saved succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No record saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            load_data();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE students SET sname=@name, gender=@gen, class=@class, dob=@dob, scholarType=@sch, mob=@mob, img=@img WHERE id=@id", conn);
                int i;
                MemoryStream mstream = new MemoryStream();
                studentImg.Image.Save(mstream, studentImg.Image.RawFormat);

                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@gen", txtGen.Text);
                cmd.Parameters.AddWithValue("@class", txtClass.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@sch", txtSch.Text);
                cmd.Parameters.AddWithValue("@mob", txtMob.Text);
                cmd.Parameters.AddWithValue("@img", mstream.ToArray());

                i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Record updated succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No record updated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            load_data();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM students WHERE id=@id", conn);
                int i;

                cmd.Parameters.AddWithValue("@id", txtID.Text);

                i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Record deleted succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No record deleted", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            load_data();

        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
            admindashboard newform = new admindashboard();
            newform.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                "sname like'%" + textBox1.Text + "%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                "class like '%" + textBox2.Text + "%'";
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
            DataObject copydata = dataGridView1.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);

            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;

            object missed_data = System.Reflection.Missing.Value;

            xlWbook = xlapp.Workbooks.Add(missed_data);

            xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);

            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[1, 1];
            xlr.Select();

            xlSheet.PasteSpecial(Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            load_data();
            txtID.ReadOnly = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.jfif"
            };
            if (ofd.ShowDialog() == DialogResult.OK) {
                studentImg.Image = System.Drawing.Image.FromFile(ofd.FileName);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
