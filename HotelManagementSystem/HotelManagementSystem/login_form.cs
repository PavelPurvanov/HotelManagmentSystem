using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class login_form : Form
    {
        SqlConnection con = new SqlConnection();  

        public login_form()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=Hotel;Integrated Security=True";  
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");
            con.Open();

            {
            }  
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=Hotel;Integrated Security=True";
            con.Open();
            string userid = txt_username.Text;
            string password = txt_password.Text;
            SqlCommand cmd = new SqlCommand("select username,password from login_table where username='" + txt_username.Text + "'and password='" + txt_password.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess !");
                this.Hide();
                choose_form c1 = new choose_form();
                c1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();  
        }


    }
}
