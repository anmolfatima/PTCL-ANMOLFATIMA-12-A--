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
    public partial class Form11 : Form
    {
        public Class con = new Class();
        public Form11()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select MDN_no from Bill", con.sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["MDN_no"]);

            }

            con.sqlcon.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from Bill where MDN_no = '" + comboBox1.Text + "'", con.sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["invoive_no"].ToString();
                textBox2.Text = dr["Billing month"].ToString();
                textBox3.Text = dr["Due date"].ToString();
                textBox4.Text = dr["Status"].ToString();
                textBox5.Text = dr["total amount"].ToString();
                textBox6.Text = dr["amount after date"].ToString();

            }
            con.sqlcon.Close();
        }
    }
}
