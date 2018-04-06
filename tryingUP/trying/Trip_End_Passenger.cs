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
    public partial class Trip_End_Passenger : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");

        string from = "", to = "";
        int weight = 0, trip_id = 0, code_id = 0;
        public Trip_End_Passenger(string from_par , string to_par, int Trip_id, int Code_id)//***********
        {
            InitializeComponent();
            code_id = Code_id;
            trip_id = Trip_id;
            from = from_par;
            to = to_par;
            con.Open();
            SqlCommand cmd = new SqlCommand("select weight from location where loc_name like '"+from+"'", con);
            int from_weight = (int)cmd.ExecuteScalar();
            con.Close();

            con.Open();
            cmd = new SqlCommand("select weight from location where loc_name like '" + to + "'", con);
            int to_weight = (int)cmd.ExecuteScalar();
            con.Close();

            con.Open();
            int discount = 0;
            try
            {
                cmd = new SqlCommand("select  Discount from Promotion where Code = " + code_id.ToString(), con);
                discount = (int)cmd.ExecuteScalar();
            }
            catch
            {
                discount = 0;
                con.Close();
            }


            con.Close();
            if (from_weight > to_weight)
            {
                fee.Text = ((from_weight - to_weight) * 5 * (100 - discount) / 100).ToString();
            }
            else
            {
                fee.Text = ((from_weight - to_weight) * -5 * (100 - discount) / 100).ToString();
            }



        }

        private void Trip_End_Passenger_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string temp = "";
            try
            {
                temp = comboBox1.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Please rate the Driver");
                return;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("update Trip set Passenger_to_driver_comment  = '" + textBox2.Text + "', Passenger_to_driver_rating = " + temp + " where ID = " + trip_id, con);
            cmd.ExecuteNonQuery();
            con.Close();

            
            // update driver tbl
            con.Open();
            cmd = new SqlCommand("select Driver_ID_FK from Trip where(ID = "+trip_id+")", con);
            int driver_id = (int)cmd.ExecuteScalar();
            con.Close();

            con.Open();
            cmd = new SqlCommand("update driver set Rating =(select AVG(Passenger_to_driver_rating) from Trip where Driver_ID_FK = " + driver_id + " )  , Salary = (select SUM(Fee) from Trip where Driver_ID_FK = " + driver_id + " ) where ID = ("+driver_id+")", con);
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            cmd = new SqlCommand("update driver set loc_FK = '"+to+"' where ID = (" + driver_id + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

    }

}
