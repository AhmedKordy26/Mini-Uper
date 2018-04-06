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
    public partial class to_drive_when_sending_request : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");
        string dd_mail = "", from1 =  "", to1 = "" , pp_email = "";
        int code_id = 0;
        public to_drive_when_sending_request(string pass_email ,string from , string to, string driver_email,int Code_id)//888888
        {
            InitializeComponent();
            code_id = Code_id;
            dd_mail = driver_email;
            label4.Text =from1 = from;
            label3.Text =to1 = to;
            pp_email = pass_email;
            SqlCommand cmd;
            con.Open();
            cmd = new SqlCommand("select Rating from Passenger where Email like '"+pass_email+"'",con);
            label6.Text = ((int)cmd.ExecuteScalar()).ToString();
            con.Close();
            con.Open();
            cmd = new SqlCommand("select Name from Passenger where Email like '" + pass_email + "'", con);
            label8.Text = ((string)cmd.ExecuteScalar()).ToString();
            con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void to_drive_when_sending_request_Load(object sender, EventArgs e)
        {

        }

        private void Accept_Request_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd;
            con.Open();
           cmd = new SqlCommand("select weight from location where loc_name like '" + from1+ "'", con);
            int from_weight = (int)cmd.ExecuteScalar();
            con.Close();

            con.Open();
            cmd = new SqlCommand("select weight from location where loc_name like '" + to1 + "'", con);
            int to_weight = (int)cmd.ExecuteScalar();
            con.Close();

            int fee = 0;

            if (from_weight > to_weight)
            {
                fee = ((from_weight - to_weight) * 5);
            }
            else
            {
                fee = ((from_weight - to_weight) * -5);
            }



            con.Open();
             cmd = new SqlCommand("insert into Trip (Pickup_Location , Destination , Distance, Passenger_ID_FK , Driver_ID_FK, Fee)values (@Pickup_Location , @Destination , @Distance, @Passenger_ID_FK , @Driver_ID_FK,@Fee);", con);
            SqlParameter par;
            par = new SqlParameter("@Pickup_Location", from1);
            cmd.Parameters.Add(par);
            par = new SqlParameter("@Destination", to1);
            cmd.Parameters.Add(par);

            SqlCommand cmd2 = new SqlCommand("select ID from Passenger where Email like '"+pp_email+"'",con);
            int pp_id = (int)cmd2.ExecuteScalar();

            cmd2 = new SqlCommand("select ID from Driver where Email like '"+dd_mail+"'", con);
            int dd_id = (int)cmd2.ExecuteScalar();

            par = new SqlParameter("@Passenger_ID_FK", pp_id);//
            cmd.Parameters.Add(par);
            par = new SqlParameter("@Driver_ID_FK", dd_id);
            cmd.Parameters.Add(par);

            par = new SqlParameter("@Distance",(int)(fee/5));
            cmd.Parameters.Add(par);
            
            par = new SqlParameter("@Fee",fee );
            cmd.Parameters.Add(par);
           
            cmd.ExecuteNonQuery();
           con.Close();

           con.Open();

           cmd = new SqlCommand("select max(ID)from Trip", con);
           int trip_id = (int)cmd.ExecuteScalar();

           con.Close();


            DriverData fm2 = new DriverData(dd_mail, trip_id);
            fm2.Show();

            Trip_Started fm = new Trip_Started(from1, to1, fm2, trip_id,code_id);//
            fm.Show();

            
            


            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
