using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp4;

namespace Point_Of_Sale
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
            this.Close();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoryManagement categoryManagement = new CategoryManagement();
            categoryManagement.Show();
            this.Close();
        }

        private void btnSalesReports_Click(object sender, EventArgs e)
        {
            this.Close();
            SalesReport salesReport = new SalesReport();
            salesReport.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Close();
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
        }
    }
}
