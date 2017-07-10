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
    public partial class Form13 : Form
    {
        public Class con = new Class();
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            con.conString();
            con.sqlcon.Open();
            SqlCommand sql = new SqlCommand("Insert into Write_about_us(name,status,comment)values(@name,@status,@comment)",con.sqlcon);
            sql.Parameters.AddWithValue("@name", textBox2.Text);
            sql.Parameters.AddWithValue("@status", comboBox2.Text);
            sql.Parameters.AddWithValue("@comment", textBox1.Text);
            sql.ExecuteNonQuery();
             }
          
             catch (Exception ex)
             {
                 MessageBox.Show("something was wrong");
             }
            con.sqlcon.Close();
            MessageBox.Show("Thank U");
            Application.Exit();
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
    }
}
