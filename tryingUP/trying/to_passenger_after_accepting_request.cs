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
    public partial class DriverData : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");

        int trip_id = 0;
        public DriverData(string driver_email , int Trip_id)
        {
            InitializeComponent();
            trip_id = Trip_id;
            con.Open();

            SqlCommand cmd = new SqlCommand("select Name, Rating, Car_Plate_Number_FK from Driver where Email like '" + driver_email + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            name.Text = (string)rdr["Name"];
            rating.Text = ((int)rdr["Rating"]).ToString();
            string car_plate_no = ((int)rdr["Car_Plate_Number_FK"]).ToString();
            rdr.Close();
            con.Close();


            con.Open();
            cmd = new SqlCommand("select Brand , color  from Car where Plate_Number = "+car_plate_no, con);
            SqlDataReader rdr1= cmd.ExecuteReader();
            rdr1.Read();
            carBrand.Text = (string) rdr1["Brand"];
            color.Text = (string)rdr1["color"];

            rdr1.Close();
            con.Close();


        }

        private void DriverData_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }


    }
}
