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
    public partial class view_assigned_trip_profile : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");
        public view_assigned_trip_profile(string email)
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Trip where Driver_ID_FK = (select ID from Driver where Email like '" + email + "')", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID");
            tbl.Columns.Add("Pickup_Location");
            tbl.Columns.Add("Destination");
            tbl.Columns.Add("Distance");
            tbl.Columns.Add("Passenger_ID_FK");
            tbl.Columns.Add("Driver_ID_FK");
            tbl.Columns.Add("Passenger_to_driver_rating");
            tbl.Columns.Add("Driver_to_passenger_rating");
            tbl.Columns.Add("Fee");
            tbl.Columns.Add("Driver_to_passenger_comment");
            tbl.Columns.Add("Passenger_to_driver_comment");

            DataRow row;
            while (rdr.Read())
            {
                row = tbl.NewRow();
                row["ID"] = rdr["ID"];
                row["Pickup_Location"] = rdr["Pickup_Location"];
                row["Destination"] = rdr["Destination"];
                row["Distance"] = rdr["Distance"];
                row["Passenger_ID_FK"] = rdr["Passenger_ID_FK"];
                row["Driver_ID_FK"] = rdr["Driver_ID_FK"];
                row["Passenger_to_driver_rating"] = rdr["Passenger_to_driver_rating"];
                row["Driver_to_passenger_rating"] = rdr["Driver_to_passenger_rating"];
                row["Fee"] = rdr["Fee"];
                row["Driver_to_passenger_comment"] = rdr["Driver_to_passenger_comment"];
                row["Passenger_to_driver_comment"] = rdr["Passenger_to_driver_comment"];

                tbl.Rows.Add(row);
            }

            rdr.Close();
            con.Close();
            dataGridView1.DataSource = tbl;
        }

        private void view_assigned_trip_profile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
