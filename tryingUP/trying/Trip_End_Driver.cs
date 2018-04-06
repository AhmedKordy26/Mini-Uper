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
    public partial class Trip_End_Driver : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");

        string from = "", to = "";
        int trip_id = 0;
        int code_id;
        public Trip_End_Driver(string from_par, string to_par, int Trip_id, int Code_id)//*88888888888
        {
            InitializeComponent();

            code_id = Code_id;
            trip_id = Trip_id;
            from = from_par;
            to = to_par;
            con.Open();
            SqlCommand cmd = new SqlCommand("select weight from location where loc_name like '" + from + "'", con);
            int from_weight = (int)cmd.ExecuteScalar();
            con.Close();

            con.Open();
            cmd = new SqlCommand("select weight from location where loc_name like '" + to + "'", con);
            int to_weight = (int)cmd.ExecuteScalar();
            con.Close();

            int discount = 0;


            con.Open();

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
                fee.Text = ((from_weight - to_weight) * 5).ToString();
            else
                fee.Text = ((from_weight - to_weight) * -5).ToString();


            if (from_weight > to_weight)
                fee2.Text = ((from_weight - to_weight) * 5*(100-discount)/100).ToString();
            else
                fee2.Text = ((from_weight - to_weight) * -5*(100-discount)/100).ToString();

            // Here Paste Code Of Promotion 

            con.Open();
            SqlCommand cmd4 = new SqlCommand("update Promotion Set Number_Of_Trips=Number_Of_Trips-1 where Code= " + code_id.ToString(), con);
            cmd4.ExecuteScalar();

            con.Close();
        }

        private void Trip_End_Driver_Load(object sender, EventArgs e)
        {

        }

        private void fee_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // update trip
            //Driver_to pass rate , comment

            string temp = "";
            try
            {
             temp = comboBox1.SelectedItem.ToString();
            }
            catch
            {
               MessageBox.Show("Please rate the Passenger ");
                return;
            }
            
            con.Open();
            SqlCommand cmd = new SqlCommand("update Trip set Driver_to_passenger_comment  = '"+textBox2.Text+"', Driver_to_passenger_rating = "+temp+" where ID = "+ trip_id, con);
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            cmd = new SqlCommand("select Passenger_ID_FK from Trip where(ID = " + trip_id + ")", con);
            int passenger_id = (int)cmd.ExecuteScalar();
            con.Close();

            con.Open();
            cmd = new SqlCommand("update Passenger set Rating =(select AVG(Driver_to_passenger_rating) from Trip where Passenger_ID_FK = " + passenger_id + ")  where ID = "+passenger_id, con);
            
            cmd.ExecuteNonQuery();
            con.Close();

            this.Close();

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
