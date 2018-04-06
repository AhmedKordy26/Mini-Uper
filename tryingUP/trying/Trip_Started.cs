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
    public partial class Trip_Started : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");
        DriverData CFM;
        string from2 = "", to2 = "";
        int trip_id = 0, code_id = 0;
        public Trip_Started(string from_par, string to_par, DriverData Cfm, int Trip_id, int Code_id)//***********
        {
            InitializeComponent();
            code_id = Code_id;
            trip_id = Trip_id;
            from.Text = from2 = from_par;
            to.Text = to2 = to_par;
            CFM = Cfm;

        }

        private void Trip_Started_Load(object sender, EventArgs e)
        {

        }

        private void End_trip_Click_1(object sender, EventArgs e)
        {
            CFM.Close();
            Trip_End_Driver fm1 = new Trip_End_Driver(from2, to2, trip_id,code_id);//***
            fm1.Show();

            Trip_End_Passenger fm2 = new Trip_End_Passenger(from2 , to2, trip_id,code_id);//**********
            fm2.Show();

            this.Close();

        }

        private void from_Click(object sender, EventArgs e)
        {

        }

    }
}
