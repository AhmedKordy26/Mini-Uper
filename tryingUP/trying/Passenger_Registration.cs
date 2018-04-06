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
    public partial class Passenger_Registration : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");
        int admin_id=-1;
        public Passenger_Registration(int x=-1)
        {
            InitializeComponent();
            admin_id = x;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();

            if (password_txt.Text != confirm_pass_txt.Text)
            {
                MessageBox.Show("Password doesn't match!");
                return;
            }
            SqlCommand cmd;

            if(admin_id==-1){
                cmd = new SqlCommand("insert into Passenger (Phone_Number,Name,Email,Password) values (@Phone_Number,@Name,@Email,@Password)", con);
                SqlParameter par=new SqlParameter("@Phone_Number",phone_txt.Text);
                cmd.Parameters.Add(par);
                par=new SqlParameter("@Email",email_txt.Text);
                cmd.Parameters.Add(par);
                par=new SqlParameter("@Name",full_name_txt.Text);
                cmd.Parameters.Add(par);
                par=new SqlParameter("@Password",password_txt.Text);
                cmd.Parameters.Add(par);  
            }
            else
            {
                cmd = new SqlCommand("insert into Passenger (Phone_Number,Name,Email,Password,admin_id_FK) values (@Phone_Number,@Name,@Email,@Password,@admin_id_FK)", con);
                SqlParameter par = new SqlParameter("@Phone_Number", phone_txt.Text);
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Email", email_txt.Text);
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Name", full_name_txt.Text);
                cmd.Parameters.Add(par);
                par = new SqlParameter("@Password", password_txt.Text);
                cmd.Parameters.Add(par);  
                par = new SqlParameter("@admin_id_FK", admin_id.ToString());
                cmd.Parameters.Add(par);
            }
            SqlCommand cmd2 = new SqlCommand("select count(*) from Passenger where Email like '" + email_txt.Text+"'", con);
            int rep = (int)cmd2.ExecuteScalar();
            if (rep == 0)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("mabroak");
                this.Close();
            }
            else
            {
                MessageBox.Show("Repeated Email");
            }
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
