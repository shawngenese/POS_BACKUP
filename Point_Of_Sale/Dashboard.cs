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
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoryManagement categoryManagement = new CategoryManagement();
            categoryManagement.ShowDialog();
        }

        private void btnSalesReports_Click(object sender, EventArgs e)
        {
            SalesReport salesReport = new SalesReport();
            salesReport.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            userManagement.ShowDialog();
        }
    }
}
