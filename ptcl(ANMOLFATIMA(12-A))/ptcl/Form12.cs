using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form12 : Form
    {
        public Class con = new Class();
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from Numbers", con.sqlcon);
            cmd.Fill(dt);
            dataGridView2.DataSource = dt;
            con.sqlcon.Close();

        }

        private void meinMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter cmd1 = new SqlDataAdapter("select * from cn", con.sqlcon);
            cmd1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.sqlcon.Close();
        }
    }
}
