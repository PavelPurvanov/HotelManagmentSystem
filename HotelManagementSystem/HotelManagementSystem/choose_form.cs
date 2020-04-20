using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class choose_form : Form
    {
        public choose_form()
        {
            InitializeComponent();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            clients_form c1 = new clients_form();
            c1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employees_form e1 = new employees_form();
            e1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rooms_form r1 = new rooms_form();
            r1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reservations_form t1 = new reservations_form();
            t1.ShowDialog();
        }
    }
}
