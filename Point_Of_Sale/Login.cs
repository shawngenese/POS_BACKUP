using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sale
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // CLOSE BUTTON ITO
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please enter both username and password.";
                //MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                lblMessage.Text = "";
            }

            ConnectionDB db = new ConnectionDB();

            try
            {
                db.Open();

                string query = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();

                int userCount = Convert.ToInt32(command.ExecuteScalar());
                if (userCount > 0)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                    this.Close();
                }
                else
                {
                    //MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblMessage.Text = "         Invalid username or password.";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
            }
        }
    }
}
