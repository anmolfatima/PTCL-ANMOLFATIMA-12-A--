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
    public partial class Form10 : Form
    {
        public Class con = new Class();
        public Form10()
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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           textBox1.Text = "complain -" + comboBox4.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.conString();
                con.sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Insert into Complain(c_no,product,c_type,email,descip)values(@c_no,@product,@c_type,@email)", con.sqlcon);
                cmd.Parameters.AddWithValue("@c_no", Convert.ToInt32(textBox1.Text));
                cmd.Parameters.AddWithValue("@product", comboBox4.Text);
                cmd.Parameters.AddWithValue("@c_type", textBox2.Text);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                cmd.Parameters.AddWithValue("@descip", textBox6.Text);
           
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
             MessageBox.Show("Record has not been insert");
            }
            con.sqlcon.Close();
            MessageBox.Show("We solve this problem As soon As posible");
            Application.Exit();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
