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
    public partial class Administrator_Registration : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");
        public Administrator_Registration()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Administrator_Registration_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            con.Open();

            if (password.Text != confirming_password.Text)
            {
                MessageBox.Show("Password doesn't match!");
                return;
            }
            SqlCommand cmd = new SqlCommand("insert into Administrators (Name,Email,Password) values (@Name,@Email,@Password)", con);

            SqlParameter par = new SqlParameter("@Name", full_name.Text);
            cmd.Parameters.Add(par);
            par = new SqlParameter("@Email", email.Text);
            cmd.Parameters.Add(par);
            par = new SqlParameter("@Password", password.Text);
            cmd.Parameters.Add(par);
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select count(*) from Administrators where Email like '" + email.Text + "'", con);
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

        private void Back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void email_OnValueChanged(object sender, EventArgs e)
        {

        }
        
    }
}
