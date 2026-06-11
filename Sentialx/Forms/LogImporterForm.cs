using System;
using System.IO;
using System.Windows.Forms;
using Sentialx.Classes;

namespace Sentialx.Forms
{
    public partial class LogImporterForm : Form
    {
        private LogImporter _importer;

        public LogImporterForm()
        {
            InitializeComponent();
            _importer = new LogImporter();
        }

        private void LogImporterForm_Load(object sender, EventArgs e)
        {
            LoadImportedEvents();
        }

        private void LoadImportedEvents()
        {
            try
            {
                dgvResults.DataSource = EventLog.GetAll();
                lblResultTitle.Text = "IMPORTED EVENTS  —  " + dgvResults.Rows.Count + " total";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading events: " + ex.Message);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                ofd.Title = "Select Log CSV File";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    _importer.ImportFromCSV(ofd.FileName, progressBar, lblStatus);

                    lblStatus.Text = "Import complete.  Imported: " + _importer.ImportedCount +
                                     "  |  Skipped: " + _importer.SkippedCount;

                    MessageBox.Show(
                        "Import complete!\n\nImported: " + _importer.ImportedCount +
                        "\nSkipped:  " + _importer.SkippedCount,
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadImportedEvents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSample_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = "Sentialx_Sample_Logs.csv";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    LogImporter.SaveSampleCSV(sfd.FileName);
                    MessageBox.Show(
                        "Sample CSV saved!\nImport it to trigger all threat detection rules.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}