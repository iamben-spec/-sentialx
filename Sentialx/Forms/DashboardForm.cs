using System;
using System.Windows.Forms;
using Sentialx.Classes;

namespace Sentialx.Forms
{
    public partial class DashboardForm : Form
    {
        public static User CurrentUser { get; set; }

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (this.Tag is User user)
            {
                CurrentUser = user;
                lblUser.Text = "ONLINE  |  " + user.Username + "  |  " + user.Role;
            }

            ApplyRoleAccess();
            LoadStats();
            LoadRecentEvents();

            btnUsers.Click += (s, ev) => OpenWithRoleCheck(new UserManagementForm(), "Admin");
            btnEvents.Click += (s, ev) => OpenWithRoleCheck(new EventViewerForm(), "Admin");
            btnFilter.Click += (s, ev) => OpenWithRoleCheck(new FilterSearchForm(), "Admin");
            btnAlerts.Click += (s, ev) => OpenWithRoleCheck(new AlertsForm(), "Admin");
            btnReport.Click += (s, ev) => OpenWithRoleCheck(new ReportGeneratorForm(), "Admin");
            btnImport.Click += (s, ev) => OpenForm(new LogImporterForm());
            btnEventLogger.Click += (s, ev) => OpenWithRoleCheck(new EventLoggerForm(), "Admin");
            btnLogout.Click += (s, ev) => Logout();
        }

        private void ApplyRoleAccess()
        {
            if (CurrentUser == null) return;

            bool isAdmin = CurrentUser.Role == "Admin";

            btnUsers.Visible = isAdmin;
            btnEvents.Visible = isAdmin;
            btnFilter.Visible = isAdmin;
            btnAlerts.Visible = isAdmin;
            btnReport.Visible = isAdmin;
            btnEventLogger.Visible = isAdmin;

        }

        private void OpenWithRoleCheck(Form form, string requiredRole)
        {
            if (CurrentUser == null) return;

            if (CurrentUser.Role != requiredRole)
            {
                MessageBox.Show(
                    "Access Denied. This section requires " + requiredRole + " privileges.",
                    "Unauthorized",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            OpenForm(form);
        }

        private void OpenForm(Form form)
        {
            form.Tag = CurrentUser;
            form.Show();
        }

        private void LoadStats()
        {
            try
            {
                object totalEvents = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Events");
                object openAlerts = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Alerts WHERE IsResolved=0");
                object highAlerts = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Alerts WHERE Severity='High' AND IsResolved=0");
                object totalUsers = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Users");

                lblTotalEventsNum.Text = totalEvents != null ? totalEvents.ToString() : "0";
                lblOpenAlertsNum.Text = openAlerts != null ? openAlerts.ToString() : "0";
                lblHighAlertsNum.Text = highAlerts != null ? highAlerts.ToString() : "0";
                lblUsersNum.Text = totalUsers != null ? totalUsers.ToString() : "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message);
            }
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

        private void Logout()
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}