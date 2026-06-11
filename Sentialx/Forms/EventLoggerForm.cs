using System;
using System.Windows.Forms;
using Sentialx.Classes;

namespace Sentialx.Forms
{
    public partial class EventLoggerForm : Form
    {
        public EventLoggerForm()
        {
            InitializeComponent();
        }

        private void EventLoggerForm_Load(object sender, EventArgs e)
        {
            LoadRecentEvents();
        }

        private void LoadRecentEvents()
        {
            try
            {
                dgvRecent.DataSource = EventLog.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading events: " + ex.Message);
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DashboardForm.CurrentUser == null)
            {
                MessageBox.Show("No user session found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string type = cmbEventType.SelectedItem.ToString();
                string desc = txtDescription.Text.Trim();
                int userID = DashboardForm.CurrentUser.UserID;

                switch (type)
                {
                    case "Action": EventLogger.LogAction(userID, desc); break;
                    case "Delete": EventLogger.LogDelete(userID, desc); break;
                    case "Error": EventLogger.LogError(userID, desc); break;
                }

                lblStatus.Text = $"Event logged successfully: [{type}] {desc}";
                txtDescription.Text = "";
                LoadRecentEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}