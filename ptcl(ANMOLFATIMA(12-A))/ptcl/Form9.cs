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
    public partial class Form9 : Form
    {
        public Class con = new Class();

        public Form9()
        {
            InitializeComponent();
        }

     

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void pakegesDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.label9.Visible = true;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
          SqlCommand  cmd = new SqlCommand("select Registration_No from Registration", con.sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr["Registration_No"]);

            }

            con.sqlcon.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            textBox2.Text = "Invoice -" + comboBox4.SelectedItem;
            
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.conString();
                con.sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Insert into (invoive_no,invoive_date,reg_no)values(@invoive_no,@invoive_date,@reg_no)", con.sqlcon);
                cmd.Parameters.AddWithValue("@invoive_no", Convert.ToInt32(textBox2.Text));
                cmd.Parameters.AddWithValue("@invoive_date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@reg_no", comboBox4.Text);
               

                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Thank U");
            }
            con.sqlcon.Close();
            MessageBox.Show("Thank u");
            Application.Exit();
            Form13 f13 = new Form13();
            f13.Show();
        }
        }
    }

