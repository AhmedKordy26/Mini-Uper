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
    public partial class Driver_Interface : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");
        string email = "";
        public Driver_Interface(string Email)
        {
            InitializeComponent();
            email = Email;
            con.Open();
            SqlCommand cmd = new SqlCommand("execute  loc_", con);
            SqlDataReader reader = cmd.ExecuteReader();

            
            
            string st ="";
            while (reader.Read())
            {
                st = (string)reader["loc_name"];
                comboBox1.Items.Add(st);
            }
            reader.Close();
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select loc_FK from Driver where Email like '" + email + "'", con);
            Current_Location.Text = ((string)cmd2.ExecuteScalar()).ToString();
            con.Close();
            con.Open();
            SqlCommand cmd3 = new SqlCommand("execute fn '" + email + "'", con);
            label2.Text = ((string)cmd3.ExecuteScalar()).ToString();
            con.Close();
            con.Open();
            SqlCommand cmd4 = new SqlCommand("select Salary from Driver where Email like '" + email + "' ", con);
            label6.Text = ((int)cmd4.ExecuteScalar()).ToString();

            /*
            SqlCommand cmd4 = new SqlCommand("select sum(Fee) from Trip where ID like ( select ID  from Driver where Email like '" + id + "')", con);
            label6.Text = ((int)cmd4.ExecuteScalar()).ToString();
            */
            con.Close();
        }

        private void Driver_Interface_Load(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("update Driver set available=0 where Email like '" + email + "'", con);//
            cmd2.ExecuteNonQuery();
            con.Close();
            this.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string comb;
            try
            {
                comb = comboBox1.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("there is no selected location");
                return;
            }
            if (comb == "")
            {
                MessageBox.Show("select an item");
            }
            else
            {
                con.Open();

                SqlCommand cmd2 = new SqlCommand("update Driver set loc_FK='" + comb + "' where Email like '" + email + "'", con);//
                Current_Location.Text = comb;
                con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrator_Interface_U_Driver fm = new Administrator_Interface_U_Driver(-1, email);
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Driver set fired=1 where Email like '" + email + "'", con);
            DialogResult res = MessageBox.Show("Do you want to delete ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            view_assigned_trip_profile fm = new view_assigned_trip_profile(email);
            fm.Show();
        }
    }
}
