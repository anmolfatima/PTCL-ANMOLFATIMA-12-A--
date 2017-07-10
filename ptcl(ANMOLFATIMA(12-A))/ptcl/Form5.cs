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
    public partial class Form5 : Form
    {
        public Class con = new Class();
        public Form5()
        {
            InitializeComponent();
        }


        private void Form5_Load(object sender, EventArgs e)
        {
        }
  
    

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();


        }
        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void smartTvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();

        }

       

        private void shopNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from Brodband", con.sqlcon);
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.sqlcon.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            DataTable dt = new DataTable();
           SqlDataAdapter cmd = new SqlDataAdapter("select * from Evo", con.sqlcon);
            cmd.Fill(dt);
            dataGridView2.DataSource = dt;
            con.sqlcon.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            DataTable dt = new DataTable();
           SqlDataAdapter cmd = new SqlDataAdapter("select * from Charji", con.sqlcon);
            cmd.Fill(dt);
            dataGridView3.DataSource = dt;
            con.sqlcon.Close();
        }
    }
}
