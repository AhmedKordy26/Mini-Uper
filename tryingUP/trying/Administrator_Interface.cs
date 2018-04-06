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
    public partial class Administrator_Interface : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");
        string email="";
        int ID=0;
        public Administrator_Interface(int id)
        {
            
            InitializeComponent();
            ID = id;
            
            con.Open();
            SqlCommand cmd = new SqlCommand("select Name from Administrators where ID like '" + id + "'", con);
            label2.Text = ((string)cmd.ExecuteScalar()).ToString();
            con.Close();
            con.Open();
            email = label2.Text;
            con.Close();
            con.Open();
            cmd = new SqlCommand("select Name from Promotion", con);
            SqlDataReader reader=cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox4.Items.Add(reader[0].ToString());
            }
            reader.Close();
            con.Close();
            con.Open();
            cmd = new SqlCommand("select Email from Passenger", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox5.Items.Add(reader[0].ToString());
            }
            reader.Close();
            con.Close();
        }


        private void Hi_Click(object sender, EventArgs e)
        {

        }

        private void Sign_Out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Passenger_Add_Click_1(object sender, EventArgs e)
        {
            Passenger_Registration form = new Passenger_Registration( ID);
            form.Show();
        }

        private void show_driver_date_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select ID ,Name ,Email ,License_Number ,Phone_Number ,Hire_Date ,Salary ,Rating ,Car_Plate_Number_FK ,available ,loc_FK ,admin_id_fk,fired from Driver", con);
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Email");
            table.Columns.Add("License_Number");
            table.Columns.Add("Phone_Number");
            table.Columns.Add("Hire_Date");
            table.Columns.Add("Salary");
            table.Columns.Add("Rating");
            table.Columns.Add("Car_Plate_Number_FK");
            table.Columns.Add("available");
            table.Columns.Add("loc_FK");
            table.Columns.Add("admin_id_fk");
            table.Columns.Add("fired");
            DataRow row;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                row = table.NewRow();
                row["ID"] = reader["ID"];
                row["Name"] = reader["Name"];
                row["Email"] = reader["Email"];
                row["License_Number"] = reader["License_Number"];
                row["Phone_Number"] = reader["Phone_Number"];
                row["Hire_Date"] = reader["Hire_Date"];
                row["Salary"] = reader["Salary"];
                row["Rating"] = reader["Rating"];
                row["Car_Plate_Number_FK"] = reader["Car_Plate_Number_FK"];
                row["available"] = reader["available"];
                row["loc_FK"] = reader["loc_FK"];
                row["admin_id_fk"] = reader["admin_id_fk"];
                row["fired"] = reader["fired"];
                table.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            Display fm = new Display(table);
            fm.Show();
        }

        private void Driver_Add_Click_1(object sender, EventArgs e)
        {
            
            Driver_Registration form = new Driver_Registration( ID);
            form.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try { 
                string temp = comboBox1.SelectedItem.ToString();
             }
            catch
            {
                MessageBox.Show("choose an Email to be deleted");
                return;
            }

            con.Open();
            if(radioButton1.Checked==true){
                SqlCommand cmd = new SqlCommand("update Passenger set fired=1 where Email like '" + comboBox1.SelectedItem.ToString() + "'", con);
                    DialogResult res = MessageBox.Show("Do you want to delete ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (res == DialogResult.OK)
                    {
                        cmd.ExecuteNonQuery();
                        
                    }

                   
                }
                else{
                    SqlCommand cmd = new SqlCommand("update Driver set fired=1 where Email like '" + comboBox1.SelectedItem.ToString() + "'", con);
                    DialogResult res = MessageBox.Show("Do you want to delete ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (res == DialogResult.OK)
                    {
                        cmd.ExecuteNonQuery();
                        
                    }

                }
                con.Close();

                //comboBox1.SelectedItem = "";// not done


                if (radioButton1.Checked == true)
                {
                    comboBox1.Items.Clear();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select Email from Passenger where fired=0", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    string st;
                    while (reader.Read())
                    {
                        st = (string)reader["Email"];
                        comboBox1.Items.Add(st);
                    }
                    reader.Close();
                    con.Close();
                }
                if (radioButton2.Checked == true)
                {
                    comboBox1.Items.Clear();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select Email from Driver where fired=0", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    string st;
                    while (reader.Read())
                    {
                        st = (string)reader["Email"];
                        comboBox1.Items.Add(st);
                    }
                    reader.Close();
                    con.Close();
                }

        }

        private void Pass_chk_box_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void driver_chk_box_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Passenger_Update_Click(object sender, EventArgs e)
        {
            Administrator_Interface_U_Passenger fm = new Administrator_Interface_U_Passenger(ID);
            fm.Show();

        }

        private void Driver_Update_Click_1(object sender, EventArgs e)
        {
            Administrator_Interface_U_Driver fm = new Administrator_Interface_U_Driver(ID);
            fm.Show();
        }

        private void show_pass_data_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select ID ,Name ,Phone_Number ,Email ,Rating ,available ,admin_id_FK,fired from Passenger ", con);
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Phone_Number");
            table.Columns.Add("Email");
            table.Columns.Add("Rating");
            table.Columns.Add("available");
            table.Columns.Add("admin_id_FK");
            table.Columns.Add("fired");
            DataRow row;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                row = table.NewRow();
                row["ID"] = reader["ID"];
                row["Name"] = reader["Name"];
                row["Phone_Number"] = reader["Phone_Number"];
                row["Email"] = reader["Email"];
                row["Rating"] = reader["Rating"];
                row["available"] = reader["available"];
                row["admin_id_FK"] = reader["admin_id_FK"];
                row["fired"] = reader["fired"];
                table.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            Display fm = new Display(table);
            fm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Administrator_Interface_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox1.Items.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select Email from Passenger where fired = 0", con);
                SqlDataReader reader = cmd.ExecuteReader();
                string st;
                while (reader.Read())
                {
                    st = (string)reader["Email"];
                    comboBox1.Items.Add(st);
                }
                reader.Close();
                con.Close();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBox1.Items.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select Email from Driver where fired = 0", con);
                SqlDataReader reader = cmd.ExecuteReader();
                string st;
                while (reader.Read())
                {
                    st = (string)reader["Email"];
                    comboBox1.Items.Add(st);
                }
                reader.Close();
                con.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Administrator_Registration fm = new Administrator_Registration();
            fm.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string Co_name = textBox1.Text;

            string Discount ="";
            string Trips ="";
            try
            {
                Discount = comboBox2.SelectedItem.ToString();
                Trips = comboBox3.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Choose Data");
                con.Close();
                return;
            }
            SqlCommand cmd = new SqlCommand("insert into Promotion (Name ,Number_Of_Trips , Discount ,admin_id_FK) values (@Name ,@Number_Of_Trips ,@Discount ,@admin_id_FK )", con);
            SqlParameter par = new SqlParameter("@Name", Co_name + " - " + Discount+"%");
            cmd.Parameters.Add(par);
            par = new SqlParameter("@Number_Of_Trips", comboBox3.SelectedItem.ToString());
            cmd.Parameters.Add(par);
            par = new SqlParameter("@Discount", comboBox2.SelectedItem.ToString());
            cmd.Parameters.Add(par);
            par = new SqlParameter("@admin_id_FK",ID );
            cmd.Parameters.Add(par);
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Promotion is added");
            con.Close();
            comboBox4.Items.Clear();
            con.Open();
            cmd = new SqlCommand("select Name from Promotion", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox4.Items.Add(reader[0].ToString());
            }
            reader.Close();
            con.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string Promotion = "";
            string Passenger = "";
            string DTP1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string DTP2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            if (string.CompareOrdinal(DTP1, DTP2)>=0)
            {
                MessageBox.Show("Select a valid date ");
                return;
            }
            try
            {
                Promotion = comboBox4.SelectedItem.ToString();
                Passenger = comboBox5.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Select Name and Email ");
                return ;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into passeenger_promotion_intermeediate (Promotion_Code_FK , Passenger_ID_FK , Apply_date , Expire_date ,Number_Of_Trips) values (@Promotion_Code_FK , @Passenger_ID_FK , @Apply_date , @Expire_date ,@Number_Of_Trips)", con);

            SqlCommand cmd2 = new SqlCommand("select  Code from Promotion where Name like '"+Promotion+"'",con);
            int promo_code = (int)cmd2.ExecuteScalar();


            cmd2 = new SqlCommand("select  ID  from Passenger where Email like '"+Passenger+"'",con);
            int pass_id = (int) cmd2.ExecuteScalar();

            cmd2 = new SqlCommand("select  Number_Of_Trips from Promotion where Name like'"+Promotion+"'",con);
            int numOfTrips = (int)cmd2.ExecuteScalar();
            
            
            SqlParameter par;
            par = new SqlParameter("@Promotion_Code_FK", promo_code);
            cmd.Parameters.Add(par);
            par = new SqlParameter("@Passenger_ID_FK", pass_id);
            cmd.Parameters.Add(par);
            par = new SqlParameter("@Apply_date", DTP1);
            cmd.Parameters.Add(par);
            par = new SqlParameter("@Expire_date",DTP2 );
            cmd.Parameters.Add(par);
            par = new SqlParameter("@Number_Of_Trips", numOfTrips);
            cmd.Parameters.Add(par);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Done");

            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Log_Out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        

        

       


       
    }
}
/*
a@a.com
*/