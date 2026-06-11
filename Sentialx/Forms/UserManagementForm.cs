using System;
using System.Data;
using System.Windows.Forms;
using Sentialx.Classes;

namespace Sentialx.Forms
{
    public partial class UserManagementForm : Form
    {
        private int _selectedUserID = -1;

        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                var dt = DatabaseHelper.ExecuteQuery(
                    "SELECT UserID, Username, Role, CreatedAt FROM Users ORDER BY UserID");
                dgvUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "UserManagement load error: " + ex.Message);
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvUsers.Rows[e.RowIndex];
            _selectedUserID = Convert.ToInt32(row.Cells["UserID"].Value);
            txtUsername.Text = row.Cells["Username"].Value.ToString();
            txtPassword.Text = "";
            cmbRole.SelectedItem = row.Cells["Role"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                string hash = User.HashPassword(txtPassword.Text.Trim());
                var p = new Microsoft.Data.SqlClient.SqlParameter[] {
                    new Microsoft.Data.SqlClient.SqlParameter("@u", txtUsername.Text.Trim()),
                    new Microsoft.Data.SqlClient.SqlParameter("@p", hash),
                    new Microsoft.Data.SqlClient.SqlParameter("@r", cmbRole.SelectedItem.ToString())
                };
                DatabaseHelper.ExecuteNonQuery(
                    "INSERT INTO Users (Username, PasswordHash, Role) VALUES (@u, @p, @r)", p);

                EventLogger.LogAction(GetCurrentUserID(), "Added new user: " + txtUsername.Text.Trim());

                MessageBox.Show("User added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadUsers();
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "Add user error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedUserID == -1) { MessageBox.Show("Select a user first."); return; }
            if (!ValidateInputs()) return;
            try
            {
                string hash = User.HashPassword(txtPassword.Text.Trim());
                var p = new Microsoft.Data.SqlClient.SqlParameter[] {
                    new Microsoft.Data.SqlClient.SqlParameter("@u",  txtUsername.Text.Trim()),
                    new Microsoft.Data.SqlClient.SqlParameter("@p",  hash),
                    new Microsoft.Data.SqlClient.SqlParameter("@r",  cmbRole.SelectedItem.ToString()),
                    new Microsoft.Data.SqlClient.SqlParameter("@id", _selectedUserID)
                };
                DatabaseHelper.ExecuteNonQuery(
                    "UPDATE Users SET Username=@u, PasswordHash=@p, Role=@r WHERE UserID=@id", p);

                EventLogger.LogAction(GetCurrentUserID(), "Updated user: " + txtUsername.Text.Trim());

                MessageBox.Show("User updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadUsers();
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "Edit user error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedUserID == -1) { MessageBox.Show("Select a user first."); return; }
            var confirm = MessageBox.Show("Are you sure you want to delete this user?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;
            try
            {
                string deletedUsername = txtUsername.Text.Trim();
                DatabaseHelper.ExecuteNonQuery("DELETE FROM Users WHERE UserID=@id",
                    new[] { new Microsoft.Data.SqlClient.SqlParameter("@id", _selectedUserID) });

                EventLogger.LogDelete(GetCurrentUserID(), "Deleted user: " + deletedUsername);

                MessageBox.Show("User deleted.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadUsers();
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "Delete user error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        private void ClearFields()
        {
            _selectedUserID = -1;
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            { MessageBox.Show("Username is required."); return false; }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            { MessageBox.Show("Password is required."); return false; }
            if (txtPassword.Text.Length < 6)
            { MessageBox.Show("Password must be at least 6 characters."); return false; }
            if (cmbRole.SelectedIndex == -1)
            { MessageBox.Show("Please select a role."); return false; }
            return true;
        }

        private int GetCurrentUserID()
        {
            return DashboardForm.CurrentUser != null ? DashboardForm.CurrentUser.UserID : 0;
        }
    }
}