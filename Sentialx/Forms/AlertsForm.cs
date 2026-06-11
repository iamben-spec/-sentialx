using System;
using System.Windows.Forms;
using Sentialx.Classes;

namespace Sentialx.Forms
{
    public partial class AlertsForm : Form
    {
        public AlertsForm()
        {
            InitializeComponent();
        }

        private void AlertsForm_Load(object sender, EventArgs e)
        {
            LoadAlerts();
        }

        private void LoadAlerts()
        {
            try
            {
                var dt = Alert.GetOpen();
                dgvAlerts.DataSource = dt;
                lblCount.Text = "OPEN ALERTS  —  " + dt.Rows.Count + " unresolved";
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "Alerts load error: " + ex.Message);
                MessageBox.Show("Error loading alerts: " + ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string severity = cmbSeverity.SelectedItem?.ToString();
                var dt = severity == "All" ? Alert.GetOpen() : Alert.GetBySeverity(severity);
                dgvAlerts.DataSource = dt;
                lblCount.Text = "ALERTS  —  " + dt.Rows.Count + " records";

                EventLogger.LogAction(GetCurrentUserID(), "Filtered alerts by severity: " + severity);
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "Filter alerts error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbSeverity.SelectedIndex = 0;
            LoadAlerts();
            EventLogger.LogAction(GetCurrentUserID(), "Refreshed alerts view.");
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            if (dgvAlerts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an alert first.");
                return;
            }

            var confirm = MessageBox.Show("Mark this alert as resolved?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int alertID = Convert.ToInt32(dgvAlerts.SelectedRows[0].Cells["AlertID"].Value);
                Alert.Resolve(alertID);

                EventLogger.LogAction(GetCurrentUserID(), "Resolved alert ID: " + alertID);

                MessageBox.Show("Alert resolved.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAlerts();
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "Resolve alert error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GetCurrentUserID()
        {
            return DashboardForm.CurrentUser != null ? DashboardForm.CurrentUser.UserID : 0;
        }
    }
}