using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stPatricksSys
{
    public partial class Form2 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;database=school");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            load_data();
            txtID.ReadOnly = true;
        }
        private void load_data()
        {
            
            try
            {
                conn.Open();
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
            txtDOB.Clear();
            txtSch.SelectedIndex = 0;
            txtMob.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGen.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtClass.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDOB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSch.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtMob.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO students (sname, gender, class, dob, scholarType, mob) VALUES (@name, @gen, @class, @dob, @sch, @mob)", conn);
                int i;

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@gen", txtGen.Text);
                cmd.Parameters.AddWithValue("@class", txtClass.Text);
                cmd.Parameters.AddWithValue("@dob", txtDOB.Text);
                cmd.Parameters.AddWithValue("@sch", txtSch.Text);
                cmd.Parameters.AddWithValue("@mob", txtMob.Text);

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
            finally {
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
                MySqlCommand cmd = new MySqlCommand("UPDATE students SET sname=@name, gender=@gen, class=@class, dob=@dob, scholarType=@sch, mob=@mob WHERE id=@id", conn);
                int i;

                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@gen", txtGen.Text);
                cmd.Parameters.AddWithValue("@class", txtClass.Text);
                cmd.Parameters.AddWithValue("@dob", txtDOB.Text);
                cmd.Parameters.AddWithValue("@sch", txtSch.Text);
                cmd.Parameters.AddWithValue("@mob", txtMob.Text);

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
            finally {
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
            finally {
                conn.Close();
            }
            load_data();

        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
            usrdashboard newform = new usrdashboard();
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

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
