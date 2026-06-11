using System;
using System.Windows.Forms;
using Sentialx.Classes;

namespace Sentialx.Forms
{
    public partial class ReportGeneratorForm : Form
    {
        private ReportGenerator _gen;

        public ReportGeneratorForm()
        {
            InitializeComponent();
        }

        private void ReportGeneratorForm_Load(object sender, EventArgs e)
        {
            rtbReport.Text = "Set your conditions above and click GENERATE.";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show("From date must be before To date.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string evType = cmbEventType.SelectedItem.ToString() == "All"
                                ? null : cmbEventType.SelectedItem.ToString();
                string sev = cmbSeverity.SelectedItem.ToString() == "All"
                                ? null : cmbSeverity.SelectedItem.ToString();

                ReportFilter filter = new ReportFilter
                {
                    EventType = evType,
                    FromDate = dtpFrom.Value.Date,
                    ToDate = dtpTo.Value.Date.AddDays(1),
                    Severity = sev,
                    MinCount = (int)numMinCount.Value,
                    IncludeAlerts = chkAlerts.Checked
                };

                _gen = new ReportGenerator(filter);
                rtbReport.Text = _gen.Generate();

                EventLogger.LogAction(GetCurrentUserID(), "Generated activity report.");
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "Report generation error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (_gen == null)
            {
                MessageBox.Show("Generate a report first.");
                return;
            }

            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Text Files (*.txt)|*.txt";
                    sfd.FileName = "Sentialx_Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        _gen.ExportToFile(sfd.FileName);
                        EventLogger.LogAction(GetCurrentUserID(), "Exported report to: " + sfd.FileName);
                        MessageBox.Show("Exported successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogError(GetCurrentUserID(), "Export error: " + ex.Message);
                MessageBox.Show("Export failed: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbEventType.SelectedIndex = 0;
            cmbSeverity.SelectedIndex = 0;
            dtpFrom.Value = DateTime.Now.AddDays(-30);
            dtpTo.Value = DateTime.Now;
            numMinCount.Value = 0;
            chkAlerts.Checked = true;
            rtbReport.Text = "Set your conditions above and click GENERATE.";
            _gen = null;
        }

        private int GetCurrentUserID()
        {
            return DashboardForm.CurrentUser != null ? DashboardForm.CurrentUser.UserID : 0;
        }
    }
}