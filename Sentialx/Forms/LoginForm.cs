using System;
using System.Windows.Forms;
using Sentialx.Classes;

namespace Sentialx.Forms
{
    public partial class LoginForm : Form
    {
        private int _failedAttempts = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter username and password.";
                return;
            }

            try
            {
                User user = User.Authenticate(username, password);

                if (user == null)
                {
                    _failedAttempts++;
                    lblError.Text = $"Invalid credentials. Attempt {_failedAttempts}/3";
                    var userCheck = Classes.DatabaseHelper.ExecuteQuery(
                        "SELECT UserID FROM Users WHERE Username=@u",
                        new Microsoft.Data.SqlClient.SqlParameter[] {
                            new Microsoft.Data.SqlClient.SqlParameter("@u", username)
                        });
                    if (userCheck.Rows.Count > 0)
                        EventLogger.LogFailedLogin(Convert.ToInt32(userCheck.Rows[0]["UserID"]), username);
                }
                else
                {
                    _failedAttempts = 0;
                    lblError.Text = "";
                    EventLogger.LogLogin(user.UserID, user.Username);
                    DashboardForm dashboard = new DashboardForm();
                    dashboard.Tag = user;
                    dashboard.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
