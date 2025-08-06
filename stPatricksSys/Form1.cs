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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            label5.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == 100) {
                timer2.Start();
                timer1.Stop();
                label6.Text = "Welcome!";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            confirm newWin = new confirm();
            this.Hide();
            newWin.Show();
        }
    }
}
