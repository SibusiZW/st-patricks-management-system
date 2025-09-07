namespace stPatricksSys
{
    partial class teachers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teachers));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdt = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.txtHOD = new System.Windows.Forms.ComboBox();
            this.txtClass = new System.Windows.Forms.ComboBox();
            this.txtMob = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPost = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(530, 470);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 73;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 71;
            this.label8.Text = "Search by name:";
            // 
            // btnExt
            // 
            this.btnExt.BackColor = System.Drawing.Color.Lime;
            this.btnExt.FlatAppearance.BorderSize = 0;
            this.btnExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExt.ForeColor = System.Drawing.Color.White;
            this.btnExt.Location = new System.Drawing.Point(122, 400);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(67, 30);
            this.btnExt.TabIndex = 70;
            this.btnExt.Text = "Back";
            this.btnExt.UseVisualStyleBackColor = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Lime;
            this.btnClear.Location = new System.Drawing.Point(72, 468);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 30);
            this.btnClear.TabIndex = 69;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdt
            // 
            this.btnUpdt.BackColor = System.Drawing.Color.Lime;
            this.btnUpdt.FlatAppearance.BorderSize = 0;
            this.btnUpdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdt.ForeColor = System.Drawing.Color.White;
            this.btnUpdt.Location = new System.Drawing.Point(122, 344);
            this.btnUpdt.Name = "btnUpdt";
            this.btnUpdt.Size = new System.Drawing.Size(67, 30);
            this.btnUpdt.TabIndex = 68;
            this.btnUpdt.Text = "Edit";
            this.btnUpdt.UseVisualStyleBackColor = false;
            this.btnUpdt.Click += new System.EventHandler(this.btnUpdt_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Lime;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(24, 400);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(73, 30);
            this.btnDel.TabIndex = 67;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.Lime;
            this.btnExp.FlatAppearance.BorderSize = 0;
            this.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExp.ForeColor = System.Drawing.Color.White;
            this.btnExp.Location = new System.Drawing.Point(517, 97);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(203, 30);
            this.btnExp.TabIndex = 66;
            this.btnExp.Text = "Export To Spreadsheet";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnIns
            // 
            this.btnIns.BackColor = System.Drawing.Color.Lime;
            this.btnIns.FlatAppearance.BorderSize = 0;
            this.btnIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIns.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.ForeColor = System.Drawing.Color.White;
            this.btnIns.Location = new System.Drawing.Point(24, 344);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(67, 30);
            this.btnIns.TabIndex = 65;
            this.btnIns.Text = "Add";
            this.btnIns.UseVisualStyleBackColor = false;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // txtHOD
            // 
            this.txtHOD.FormattingEnabled = true;
            this.txtHOD.Items.AddRange(new object[] {
            "",
            "N/A",
            "Languages",
            "Sports",
            "Maths",
            "Arts",
            "Sciences",
            "Practicals",
            "Commercials"});
            this.txtHOD.Location = new System.Drawing.Point(95, 262);
            this.txtHOD.Name = "txtHOD";
            this.txtHOD.Size = new System.Drawing.Size(137, 25);
            this.txtHOD.TabIndex = 64;
            // 
            // txtClass
            // 
            this.txtClass.FormattingEnabled = true;
            this.txtClass.Items.AddRange(new object[] {
            "",
            "1N",
            "2N",
            "3N",
            "4N",
            "1E",
            "2E",
            "3E",
            "4E",
            "1W",
            "2W",
            "3W",
            "4W",
            "1S",
            "2S",
            "3S",
            "4S",
            "L6A",
            "U6A",
            "L6C",
            "U6C",
            "L6S",
            "U6S",
            "N/A"});
            this.txtClass.Location = new System.Drawing.Point(95, 200);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(137, 25);
            this.txtClass.TabIndex = 63;
            // 
            // txtMob
            // 
            this.txtMob.Location = new System.Drawing.Point(95, 293);
            this.txtMob.Name = "txtMob";
            this.txtMob.Size = new System.Drawing.Size(133, 25);
            this.txtMob.TabIndex = 61;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 169);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 25);
            this.txtName.TabIndex = 60;
            // 
            // txtEC
            // 
            this.txtEC.Location = new System.Drawing.Point(95, 138);
            this.txtEC.Name = "txtEC";
            this.txtEC.Size = new System.Drawing.Size(114, 25);
            this.txtEC.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "Post:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "HOD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Mobile:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "EC No.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(381, 144);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 309);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtPost
            // 
            this.txtPost.FormattingEnabled = true;
            this.txtPost.Items.AddRange(new object[] {
            "",
            "N/A",
            "Senior Master",
            "Senior Woman",
            "Warden",
            "Deputy Head",
            "Head"});
            this.txtPost.Location = new System.Drawing.Point(95, 231);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(137, 25);
            this.txtPost.TabIndex = 74;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 79);
            this.panel1.TabIndex = 75;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(326, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 30);
            this.label12.TabIndex = 3;
            this.label12.Text = "Teacher Records";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(871, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(193, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(489, 43);
            this.label11.TabIndex = 0;
            this.label11.Text = "St Patrick\'s Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 47);
            this.panel2.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(306, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(250, 30);
            this.label13.TabIndex = 2;
            this.label13.Text = "Taking up the challenge";
            // 
            // teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(896, 565);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdt);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.txtHOD);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtMob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Records";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdt;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.ComboBox txtHOD;
        private System.Windows.Forms.ComboBox txtClass;
        private System.Windows.Forms.TextBox txtMob;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtPost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
    }
}