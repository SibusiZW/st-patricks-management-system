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
    public partial class usrdashboard : Form
    {
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
    }
}

