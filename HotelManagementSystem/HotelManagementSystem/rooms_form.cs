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
    public partial class rooms_form : Form
    {
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmdbl;

        public rooms_form()
        {
            InitializeComponent();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            if ((!(string.IsNullOrWhiteSpace(txt_type.Text) ||
               string.IsNullOrWhiteSpace(txt_room_number.Text) ||
               string.IsNullOrWhiteSpace(txt_price.Text))))
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into rooms_table(type,room_number,price) values ('" + txt_type.Text + "','" + txt_room_number.Text + "','" + txt_price.Text + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Saved");

                }
                else
                {
                    MessageBox.Show("Error");
                }
                con.Close();

                ds = new System.Data.DataSet();
                adap.Fill(ds, "rooms_table");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Некоректно въведени данни !");  
            }
        }

        private void rooms_table_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con2 = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");
                con2.Open();
                adap = new SqlDataAdapter("select id_room, type as 'type', room_number as 'room_number', price as 'price' from rooms_table ", con2);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "rooms_table");
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
                adap.Update(ds, "rooms_table");
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

                SqlCommand cmd = new SqlCommand("DELETE from rooms_table WHERE (id_room='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "')", con3);
                int j = cmd.ExecuteNonQuery();
                if (j > 0)
                {
                    MessageBox.Show("Record Deleted Successfully!" + j + "");


                }
                con3.Close();

                ds = new System.Data.DataSet();
                adap.Fill(ds, "rooms_table");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                this.Show();

            }
        }

        private void txt_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_room_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

     

       
    }
}
