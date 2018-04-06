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
    public partial class Driver_Registration : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");
        int admin_id ;
        public Driver_Registration(int x=-1)
        {
            InitializeComponent();
            admin_id = x;
        }

        private void Driver_Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if(password.Text != confirming_pass.Text)
            {

                MessageBox.Show("Password doesn't match!");
                return;
            }
            SqlParameter par;
            SqlCommand cmd;
            if (admin_id == -1)
            {
                
                cmd = new SqlCommand("insert into Driver (License_Number ,Name , Phone_Number , Hire_Date , Email, Password, Car_Plate_Number_FK) values (@License_Number ,@Name , @Phone_Number , @Hire_Date , @Email, @Password,@Car_Plate_Number_FK);", con);
                par = new SqlParameter("@License_Number", license_number.Text);
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Name", full_name.Text);
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Phone_Number", phone_number.Text);
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Hire_Date", "29-jul-2011");//DateTime.UtcNow.Date.ToString("yyyy-MM-dd")
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Email", email.Text);
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Password", password.Text);
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Car_Plate_Number_FK", car_plate.Text);
                cmd.Parameters.Add(par);
            }
            else
            {
                cmd = new SqlCommand("insert into Driver (License_Number ,Name , Phone_Number , Hire_Date , Email, Password, Car_Plate_Number_FK,admin_id_fk) values (@License_Number ,@Name , @Phone_Number , @Hire_Date , @Email, @Password,@Car_Plate_Number_FK,@admin_id_fk);", con);
                par = new SqlParameter("@License_Number", license_number.Text);
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Name", full_name.Text);
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Phone_Number", phone_number.Text);
                cmd.Parameters.Add(par);
                //string date = date;
                par = new SqlParameter("@Hire_Date", "29-jul-2011");//note done
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Email", email.Text);
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Password", password.Text);
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Car_Plate_Number_FK", car_plate.Text);
                cmd.Parameters.Add(par);
                par = new SqlParameter("@admin_id_fk", admin_id.ToString());
                cmd.Parameters.Add(par);
            }




             SqlCommand cmd2 = new SqlCommand("insert into Car (Plate_Number,Brand,Model,Color) values (@Plate_Number,@Brand,@Model,@Color);", con);

             par = new SqlParameter("@Plate_Number", car_plate.Text);
             cmd2.Parameters.Add(par);
             par = new SqlParameter("@Brand", car_brand.Text);
             cmd2.Parameters.Add(par);
             par = new SqlParameter("@Model", car_model.Text);
             cmd2.Parameters.Add(par);
             par = new SqlParameter("@Color", car_color.Text);//
             cmd2.Parameters.Add(par);


             SqlCommand cmd3 = new SqlCommand("select count(*) from Driver where Email like '" + email.Text + "'", con);
             int rep = (int)cmd3.ExecuteScalar();
             SqlCommand cmd4 = new SqlCommand("select count(*) from Car where Plate_Number like '" + car_plate.Text + "'", con);
             int rcp = (int)cmd4.ExecuteScalar();



             if (rep == 0 && rcp==0)
             {
                 cmd2.ExecuteNonQuery();
                 cmd.ExecuteNonQuery();
                 
                 MessageBox.Show("mabroak");
                 this.Close();
             }
             else 
             {
                 string E="";
                 if (rep == 1) E += "Repeated Email \n";
                 if (rcp == 1) E += " Repeated Plate Number";
                 MessageBox.Show(E);
             }


            con.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void full_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
