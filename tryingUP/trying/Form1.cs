using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace trying
{
    public partial class form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");
        public form1()
        {
            InitializeComponent();

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
           DialogResult res=MessageBox.Show("Do you want exit ?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
           if(res == DialogResult.OK)
               {
                   this.Close();
               }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string email = textBox1.Text, b1 = textBox2.Text, b2 = "";
            if (email == "" || b1 == "")
            {
                MessageBox.Show("Make sure you entered your email and password");
                return;
            }
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("execute Login_ @email='" + email + "'", con);
                 b2 = ((string)cmd.ExecuteScalar()).ToString();
            }
            catch{
                MessageBox.Show("Make sure you entered a valid email");
                con.Close();
                return ;
            }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                b2 = (string)reader["Password"];
            }
            if ( b2 == b1)
            {
                SqlCommand cmd2 = new SqlCommand("update Passenger set available=1 where Email like '" + email + "'", con);
                Passenger_Interface fm = new Passenger_Interface(email); fm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password or Email");
            }
            //tk@tk.com
            con.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string email = textBox1.Text, b1 = textBox2.Text, b2 = "";
            if (email == "" || b1 == "")
            {
                MessageBox.Show("Make sure you entered your email and password");
                return;
            }
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select Password from Driver where fired = 0 AND Email like '" + email + "'", con);
                b2 = ((string)cmd.ExecuteScalar()).ToString();
            }
            catch
            {
                MessageBox.Show("Make sure you entered your email");
                con.Close();
                return;
            }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                b2 = (string)reader["Password"];
            }
            reader.Close();
            con.Close(); /// tktkttkt
            if (b2 == b1)
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("update Driver set available=1 where Email like '" + email + "'", con);//
                cmd2.ExecuteNonQuery();
                con.Close();
                Driver_Interface fm = new Driver_Interface(email); fm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password or Email");
            }
            //s@s.com
            reader.Close();
            con.Close();
            

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string email = textBox1.Text, b1 = textBox2.Text, b2 = "";
            if (email == "" || b1 == "")
            {
                MessageBox.Show("Make sure you entered your email and password");
                return;
            }
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select Password from Administrators where Email like '" + email + "'", con);
                b2 = ((string)cmd.ExecuteScalar()).ToString();
            }
            catch
            {
                MessageBox.Show("Make sure you entered your email");
                con.Close();
                return;
            }
            /*
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                b2 = (string)reader["Password"];
            }
            reader.Close();
            */
            con.Close();
            
            if (b2 == b1)
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select ID from Administrators where Email like '" + email + "'", con);
                int new_id = ((int)cmd2.ExecuteScalar());
                Administrator_Interface fm = new Administrator_Interface(new_id);fm.Show();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Password or Email");
            }
            
            

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Registration fm = new Registration();
            fm.Show();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        


       

       

        
    }
}
