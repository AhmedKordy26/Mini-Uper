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
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Uber_1;Integrated Security=True");
        public Registration()
        {
            InitializeComponent();
        }

        private void Passenger_Click_1(object sender, EventArgs e)
        {
            Passenger_Registration fm=new Passenger_Registration();
            fm.Show();
            this.Close();
        }

        private void Driver_Click_1(object sender, EventArgs e)
        {
            Driver_Registration fm = new Driver_Registration();
            fm.Show();
            this.Close();
        }

        private void Administrator_Click(object sender, EventArgs e)
        {
            
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

       

     


    }
}
