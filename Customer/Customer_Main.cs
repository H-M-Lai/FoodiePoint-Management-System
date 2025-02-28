using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    public partial class Customer_Main : Form
    {
        public Customer_Main()
        {
            InitializeComponent();
        }

        private void Customer_Main_Load(object sender, EventArgs e)
        {

        }

        private void lblcus_feedbacks_Click(object sender, EventArgs e)
        {
            Customer_Feedback customer_feedback = new Customer_Feedback();
            customer_feedback.Show();
        }

        private void lblcus_profile_Click(object sender, EventArgs e)
        {
            Customer_Profile customer_profile = new Customer_Profile();
            customer_profile.Show();
        }

        private void lblcus_reservations_Click(object sender, EventArgs e)
        {
            Customer_Reservation customer_reservation = new Customer_Reservation();
            customer_reservation.Show();
        }

        private void lblcus_orderfood_Click(object sender, EventArgs e)
        {
            Customer_Order customer_order = new Customer_Order();
            customer_order.Show();
        }

        private void lblcus_vieworders_Click(object sender, EventArgs e)
        {
            Customer_OrderStatus customer_orderstatus = new Customer_OrderStatus();
            customer_orderstatus.Show();
        }
    }
}
