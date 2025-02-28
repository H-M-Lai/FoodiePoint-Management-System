using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace manager.design
{
    public partial class manager_main_page : Form
    {
        public manager_main_page()
        {
            InitializeComponent();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Menu_Category_ Menu_Category = new Menu_Category_();
            Menu_Category.Show();
        }

        private void btnhall_Click(object sender, EventArgs e)
        {
            Hall Hall = new Hall();
            Hall.Show();
        }


        private void btnreservationreport_Click(object sender, EventArgs e)
        {
            Reservation_Report Reservation_Report=new Reservation_Report();
            Reservation_Report.Show();  
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Update_Own_Profile Update_Own_Profile = new Update_Own_Profile();
            Update_Own_Profile.Show();

        }

        private void manager_main_page_Load(object sender, EventArgs e)
        {

        }

       

      
    }
}
