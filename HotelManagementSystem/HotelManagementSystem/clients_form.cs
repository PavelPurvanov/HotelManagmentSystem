using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem 
{
    public partial class clients_form : Form 
    {
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmdbl;

        public clients_form()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!(string.IsNullOrWhiteSpace(txt_first_name.Text) ||
                string.IsNullOrWhiteSpace(txt_last_name.Text) ||
                string.IsNullOrWhiteSpace(txt_egn.Text) ||
                string.IsNullOrWhiteSpace(txt_phone.Text) ||
                string.IsNullOrWhiteSpace(txt_address.Text))) &&

                txt_egn.Text.Length == 10 &&
                txt_phone.Text.Length == 10)
            {

                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into clients_table(first_name,last_name,egn,phone,address) values ('" + txt_first_name.Text + "','" + txt_last_name.Text + "','" + txt_egn.Text + "','" + txt_phone.Text + "','" + txt_address.Text + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Saved");
                    txt_first_name.Clear();
                    txt_last_name.Clear();
                    txt_egn.Clear();
                    txt_phone.Clear();
                    txt_address.Clear();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                con.Close();

                ds = new System.Data.DataSet();
                adap.Fill(ds, "clients_table");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Некоректно въведени данни !");

            }

        }

        private void clients_form_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con2 = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");
                con2.Open();
                adap = new SqlDataAdapter("select id_client, first_name as 'first_name', last_name as 'last_name', egn as 'egn', phone as 'phone', address as 'address' from clients_table ", con2);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "clients_table");
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                cmdbl = new SqlCommandBuilder(adap);
                adap.Update(ds, "clients_table");
                MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            SqlConnection con3 = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");
            DialogResult del = MessageBox.Show("Are you Sure you want to Delete" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (del == DialogResult.Yes)
            {
                con3.Open();

                SqlCommand cmd = new SqlCommand("DELETE from clients_table WHERE (id_client='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "')", con3);
                int j = cmd.ExecuteNonQuery();
                if (j > 0)
                {
                    MessageBox.Show("Record Deleted Successfully!" + j + "");


                }
                con3.Close();

                ds = new System.Data.DataSet();
                adap.Fill(ds, "clients_table");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                this.Show();

            }
        }


        private void txt_first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_last_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_egn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

    }
}
