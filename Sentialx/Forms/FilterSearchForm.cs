using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sentialx.Classes;
using Microsoft.Data.SqlClient;

namespace Sentialx.Forms
{
    public partial class FilterSearchForm : Form
    {
        public FilterSearchForm()
        {
            InitializeComponent();
        }

        private void FilterSearchForm_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void LoadAll()
        {
            try
            {
                dgvResults.DataSource = EventLog.GetAll();
                lblResults.Text = "RESULTS  —  " + dgvResults.Rows.Count + " records";
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "Filter form load error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show("From date must be before To date.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var query = new System.Text.StringBuilder(@"
                    SELECT e.EventID, u.Username, e.EventType, e.Description, e.Timestamp
                    FROM Events e JOIN Users u ON e.UserID = u.UserID
                    WHERE e.Timestamp BETWEEN @from AND @to");

                var pList = new List<SqlParameter> {
                    new SqlParameter("@from", dtpFrom.Value.Date),
                    new SqlParameter("@to",   dtpTo.Value.Date.AddDays(1))
                };

                if (cmbEventType.SelectedItem?.ToString() != "All")
                {
                    query.Append(" AND e.EventType=@type");
                    pList.Add(new SqlParameter("@type", cmbEventType.SelectedItem.ToString()));
                }

                if (!string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    query.Append(" AND u.Username LIKE @user");
                    pList.Add(new SqlParameter("@user", "%" + txtUsername.Text.Trim() + "%"));
                }

                query.Append(" ORDER BY e.Timestamp DESC");

                var dt = DatabaseHelper.ExecuteQuery(query.ToString(), pList.ToArray());
                dgvResults.DataSource = dt;
                lblResults.Text = "RESULTS  —  " + dt.Rows.Count + " records found";

                EventLogger.LogAction(GetCurrentUserID(), "Performed event search/filter.");
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "Search error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbEventType.SelectedIndex = 0;
            txtUsername.Text = "";
            dtpFrom.Value = DateTime.Now.AddDays(-30);
            dtpTo.Value = DateTime.Now;
            LoadAll();
        }

        private int GetCurrentUserID()
        {
            return DashboardForm.CurrentUser != null ? DashboardForm.CurrentUser.UserID : 0;
        }
    }
}