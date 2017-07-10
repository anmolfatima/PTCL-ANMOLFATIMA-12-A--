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
    public partial class Form8 : Form
    {
        public Class con = new Class();
          string[] prds = new string[50];
        int[] qty = new int[50];
        int counter = 0;
        
        public Form8()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pakegesDetailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.label9.Visible = true;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
           
            SqlCommand cmd = new SqlCommand("select p_type from p_type", con.sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["p_type"]);

            }
            con.sqlcon.Close();
            con.conString();
            con.sqlcon.Open();
           SqlCommand cmd1 = new SqlCommand("select Registration_No from Registration ", con.sqlcon);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox4.Items.Add(dr1["Registration_No"]);

            }
            con.sqlcon.Close();
         
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select Package_Name from Landline", con.sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Package_Name"]);

            }
            con.sqlcon.Close();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select Package_Name from Vfone", con.sqlcon);
           SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Package_Name"]);

            }
            con.sqlcon.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select Packages from Brodband", con.sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Packages"]);

            }
           con.sqlcon.Close();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select Volume  from Charji", con.sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Volume"]);

            }
            con.sqlcon.Close();
        }

      

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select Product  from Evo",con.sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Product"]);

            }
            con.sqlcon.Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select Name from smart_Tv", con.sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Name"]);

            }
            con.sqlcon.Close();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select Package_Name from Smart_tv_app", con.sqlcon);
           SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Package_Name"]);

            }
            con.sqlcon.Close();

        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from smart_tv_app where Package_Name= '" + comboBox2.Text + "'",con.sqlcon);
           SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox6.Text = dr["Price"].ToString();
            }
            con.sqlcon.Close();

            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd1 = new SqlCommand("select * from smart_Tv where Name= '" + comboBox2.Text + "'", con.sqlcon);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                textBox6.Text = dr1["Price"].ToString();
            }
            con.sqlcon.Close();

            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Charji where Volume= '" + comboBox2.Text + "'",con.sqlcon);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                textBox6.Text = dr2["Monthly_Line_Rent"].ToString();
            }
            con.sqlcon.Close();

            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd3 = new SqlCommand("select * from  Evo where Product= '" + comboBox2.Text + "'", con.sqlcon);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                textBox6.Text = dr3["Line Rent"].ToString();
            }
            con.sqlcon.Close();

            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd4 = new SqlCommand("select * from  Brodband where Packages= '" + comboBox2.Text + "'", con.sqlcon);
           SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                textBox6.Text = dr4["Internet_Charges"].ToString();
            }
            con.sqlcon.Close();

            con.conString();
            con.sqlcon.Open();
           SqlCommand cmd5 = new SqlCommand("select * from  Vfone where Package_Name= '" + comboBox2.Text + "'",con.sqlcon);
           SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                textBox6.Text = dr5["Price"].ToString();
            }

            con.sqlcon.Close();

            con.conString();
            con.sqlcon.Open();
            SqlCommand cmd6 = new SqlCommand("select * from  Landline where Package_Name = '" + comboBox2.Text + "'", con.sqlcon);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                textBox6.Text = dr6["Package_charges"].ToString();
            }

            con.sqlcon.Close();
        
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox9.Text += comboBox2.Text + Environment.NewLine;
            textBox10.Text += textBox6.Text + Environment.NewLine;
            textBox11.Text += textBox7.Text + Environment.NewLine;
           
            
        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.conString();
            con.sqlcon.Open();
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into  (p_type,p_pkg,p_price,p_qty,reg_no,name,email,ph1#,add)values(@p_type,@p_pkg,@p_price,@p_qty,@reg_no,@name,@email,@ph1#,@add);", con.sqlcon);
                    cmd.Parameters.AddWithValue("@p_type", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@p_pkg", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@p_price", textBox6.Text);
                    cmd.Parameters.AddWithValue("@p_qty", textBox3.Text);
                    cmd.Parameters.AddWithValue("@reg_no", Convert.ToInt32(comboBox4.Text));
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@email", textBox2.Text);
                    cmd.Parameters.AddWithValue("@ph1#", textBox3.Text);
                    cmd.Parameters.AddWithValue("@add", textBox4.Text);
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
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}