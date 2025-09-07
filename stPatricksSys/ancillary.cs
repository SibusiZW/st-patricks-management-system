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
    public partial class ancillary : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;database=school");
        public ancillary()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            conn.Close();
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM anc", conn);
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
            txtDep.SelectedIndex = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGen.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDep.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO anc (aname, gender, dep) VALUES (@name, @gen, @dep)", conn);
                int i;

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@gen", txtGen.Text);
                cmd.Parameters.AddWithValue("@dep", txtDep.Text);

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
                MySqlCommand cmd = new MySqlCommand("UPDATE anc SET aname=@name, gender=@gen, dep=@dep WHERE id=@id", conn);
                int i;

                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@gen", txtGen.Text);
                cmd.Parameters.AddWithValue("@dep", txtDep.Text);

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
                MySqlCommand cmd = new MySqlCommand("DELETE FROM anc WHERE id=@id", conn);
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
                "aname like '%" + textBox1.Text + "%'";
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

        private void Form5_Load(object sender, EventArgs e)
        {
            load_data();
            txtID.ReadOnly = true;
        }
    }
}
