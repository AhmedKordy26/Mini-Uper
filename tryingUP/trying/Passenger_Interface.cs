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
    public partial class Passenger_Interface : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");
        string email = "";int code_id= 0 ;
        public Passenger_Interface(string Email)
        {
            InitializeComponent();
            email = Email;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from location", con);
            SqlDataReader reader = cmd.ExecuteReader();
            string st;
            while (reader.Read())
            {
                st = (string)reader["loc_name"];
                comboBox1.Items.Add(st);
                comboBox2.Items.Add(st);
            }
            reader.Close();
            con.Close();
            con.Open();

            SqlCommand cmd2 = new SqlCommand("select Name from Passenger where Email like '" + email + "'", con);
            label2.Text = ((string)cmd2.ExecuteScalar()).ToString();
            con.Close();
            con.Open();
            cmd = new SqlCommand("select Name from Promotion where Code in (select Promotion_Code_FK from passeenger_promotion_intermeediate where Number_Of_Trips>0 AND Expire_date > '"+DateTime.Now.ToString("yyy-MM-dd")+"' AND Apply_Date <= '"+DateTime.Now.ToString("yyy-MM-dd")+"' AND Passenger_ID_FK = (select ID from Passenger where Email like '" + email + "') )", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                st = (string)reader[0];
                comboBox4.Items.Add(st);
            }
            reader.Close();
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string comb = "", comb2 = "";
            try
            {
                comb = comboBox1.SelectedItem.ToString();
                comb2 = comboBox2.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("select an item");
                return;
            }

            con.Open();
       
            string driver="";
            SqlCommand cmd = new SqlCommand("select Email from Driver where available= 1 AND fired = 0 AND loc_FK like '" + comb + "'", con);
            try
            {
                driver = ((string)cmd.ExecuteScalar()).ToString();
            }
            catch
            {
                MessageBox.Show("No available driver near you");
                con.Close();
                return;
            }
           // MessageBox.Show(driver);
            to_drive_when_sending_request fm = new to_drive_when_sending_request(email ,comb , comb2, driver,code_id);//*******
            fm.Show();

            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("update Passenger set available=0 where Email like '" + email + "'", con);//
            cmd2.ExecuteNonQuery();
            con.Close();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Passenger_Interface_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrator_Interface_U_Passenger fm = new Administrator_Interface_U_Passenger(-1, email);
            fm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Passenger set fired=1 where Email like '" + email + "'", con);
            DialogResult res = MessageBox.Show("Do you want to delete ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Expire_date from passeenger_promotion_intermeediate where Promotion_Code_FK =(select Code from Promotion where Name like '"+comboBox4.SelectedItem.ToString()+"')", con);
            label8.Text = (string)cmd.ExecuteScalar().ToString();
            con.Close();

            con.Open();

            cmd = new SqlCommand("select Code from Promotion where Name like '" + comboBox4.SelectedItem.ToString() + "'", con);
            code_id = (int)cmd.ExecuteScalar();
           // MessageBox.Show(code_id.ToString());
            con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
