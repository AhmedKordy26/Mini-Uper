using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace trying
{
    public partial class Administrator_Interface_U_Passenger : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");
        int id;
        string choosen_email = "";
        public Administrator_Interface_U_Passenger(int ID=-1 ,string passenger_email ="")//admin's id
        {
            InitializeComponent();
            SqlCommand cmd;
            if (passenger_email != "")
            {
                button1.Hide();
                comboBox1.Hide();
                label1.Hide();
                choosen_email = passenger_email;
                con.Open();
                cmd = new SqlCommand("select Name,Phone_Number,Password from Passenger where Email like '" + choosen_email + "'", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    textBox1.Text = (string)rdr["Name"];
                    textBox2.Text = (string)rdr["Phone_Number"];
                    textBox3.Text = (string)rdr["Password"];
                    break;
                }
                rdr.Close();
                con.Close();
            }
            id = ID;
            con.Open();
            cmd = new SqlCommand("select Email from Passenger", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add((string)reader["Email"]);
            }
            reader.Close();
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd;
            try 
            {
                choosen_email = comboBox1.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("choose element");
                return;
            }
            con.Open();
            cmd = new SqlCommand("select Name,Phone_Number,Password from Passenger where Email like '" + choosen_email + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                textBox1.Text = (string)rdr["Name"];
                textBox2.Text = (string)rdr["Phone_Number"];
                textBox3.Text = (string)rdr["Password"];
                break;
            }
            rdr.Close();
            con.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {

            string a=textBox1.Text,b=textBox2.Text,c=textBox3.Text;
            if (a == "" || b == "" || c == "")
            {
                MessageBox.Show("Missing Data");
                return;
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Passenger set Name ='" + a + "' ,Phone_Number = '" + b + "' ,Password ='" + c + "' where Email like '" + choosen_email + "'", con);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Repeated Phone Number");
                }
                con.Close();
                if (id != -1)
                {
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("update Passenger set admin_id_FK = " + id.ToString() + " where Email like '" + choosen_email + "'", con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Done");
            }
        }

        private void Administrator_Interface_U_Passenger_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

      
    }
}
