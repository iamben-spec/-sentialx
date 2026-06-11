using System;
using System.Windows.Forms;
using Sentialx.Classes;

namespace Sentialx.Forms
{
    public partial class EventViewerForm : Form
    {
        public EventViewerForm()
        {
            InitializeComponent();
        }

        private void EventViewerForm_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void LoadEvents()
        {
            try
            {
                dgvEvents.DataSource = EventLog.GetAll();
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "EventViewer load error: " + ex.Message);
                MessageBox.Show("Error loading events: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadEvents();
                EventLogger.LogAction(GetCurrentUserID(), "Refreshed event viewer.");
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "Refresh error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEvents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an event first.");
                return;
            }

            var confirm = MessageBox.Show("Delete this event?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int eventID = Convert.ToInt32(dgvEvents.SelectedRows[0].Cells["EventID"].Value);
                DatabaseHelper.ExecuteNonQuery("DELETE FROM Events WHERE EventID=@id",
                    new[] { new Microsoft.Data.SqlClient.SqlParameter("@id", eventID) });

                EventLogger.LogDelete(GetCurrentUserID(), "Deleted event ID: " + eventID);

                MessageBox.Show("Event deleted.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEvents();
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "Delete event error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GetCurrentUserID()
        {
            return DashboardForm.CurrentUser != null ? DashboardForm.CurrentUser.UserID : 0;
        }
    }
}