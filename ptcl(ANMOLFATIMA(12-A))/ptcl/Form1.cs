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
    public partial class Form1 : Form
    {
        public Class con = new Class();
        int counter = 0;
        int id = 001;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd1 = new SqlCommand("select  Registration_No from Registration;", con.sqlcon);
            
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Text = dr["Registration_No"].ToString();
                id++;
            }
            con.sqlcon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
           {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("insert into Registration (Registration_No,name,Gender,City,CNIC no,Ph#,Email,Password)values(@Registration_No,@name,@Gender,@City,@CNIC no,@Ph#,@Email,@Password);", con.sqlcon);
                        cmd.Parameters.AddWithValue("@Registration_No",Convert.ToInt32(textBox1.Text));
                        cmd.Parameters.AddWithValue("@name", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Gender", textBox2.Text);
                        cmd.Parameters.AddWithValue("@City", textBox3.Text);
                        cmd.Parameters.AddWithValue("@CNIC no", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Ph#", textBox5.Text);
                        cmd.Parameters.AddWithValue("@Email", textBox6.Text);
                        cmd.Parameters.AddWithValue("@Password", textBox7.Text);
                        
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("something was wrong");
                    }
                }
                con.sqlcon.Close();
                MessageBox.Show("Record has been Inserted ");
          
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
