using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sentialx.Forms
{
    partial class LogImporterForm
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new Panel();
            this.lblTitle = new Label();
            this.panelMain = new Panel();
            this.panelInfo = new Panel();
            this.lblInfoTitle = new Label();
            this.lblFormat = new Label();
            this.lblExample = new Label();
            this.btnImport = new Button();
            this.btnSample = new Button();
            this.lblStatus = new Label();
            this.lblResultTitle = new Label();
            this.dgvResults = new DataGridView();
            this.progressBar = new ProgressBar();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();

            Color bgDark = Color.FromArgb(10, 14, 26);
            Color bgPanel = Color.FromArgb(16, 22, 36);
            Color bgInput = Color.FromArgb(20, 28, 45);
            Color cyan = Color.FromArgb(0, 255, 200);
            Color cyanDim = Color.FromArgb(0, 180, 140);
            Color green = Color.FromArgb(50, 220, 120);
            Color greenDim = Color.FromArgb(20, 130, 60);
            Color muted = Color.FromArgb(100, 120, 150);
            Color textMain = Color.FromArgb(200, 215, 230);
            Color amber = Color.FromArgb(255, 160, 50);

            // panelTop
            this.panelTop.BackColor = bgDark;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Size = new Size(1060, 55);
            this.panelTop.Name = "panelTop";

            this.lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            this.lblTitle.ForeColor = cyan;
            this.lblTitle.Text = "SENTIALX  —  Log Importer";
            this.lblTitle.Location = new Point(20, 13);
            this.lblTitle.Size = new Size(500, 30);
            this.lblTitle.Name = "lblTitle";

            // panelMain
            this.panelMain.BackColor = bgDark;
            this.panelMain.Controls.Add(this.panelInfo);
            this.panelMain.Controls.Add(this.btnImport);
            this.panelMain.Controls.Add(this.btnSample);
            this.panelMain.Controls.Add(this.progressBar);
            this.panelMain.Controls.Add(this.lblStatus);
            this.panelMain.Controls.Add(this.lblResultTitle);
            this.panelMain.Controls.Add(this.dgvResults);
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Name = "panelMain";

            // panelInfo
            this.panelInfo.BackColor = bgPanel;
            this.panelInfo.Controls.Add(this.lblInfoTitle);
            this.panelInfo.Controls.Add(this.lblFormat);
            this.panelInfo.Controls.Add(this.lblExample);
            this.panelInfo.Location = new Point(20, 20);
            this.panelInfo.Size = new Size(1000, 130);
            this.panelInfo.Name = "panelInfo";

            this.lblInfoTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblInfoTitle.ForeColor = cyan;
            this.lblInfoTitle.Text = "EXPECTED CSV FORMAT";
            this.lblInfoTitle.Location = new Point(15, 12);
            this.lblInfoTitle.Size = new Size(400, 25);
            this.lblInfoTitle.Name = "lblInfoTitle";

            this.lblFormat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblFormat.ForeColor = muted;
            this.lblFormat.Text = "Required columns:  Timestamp  |  UserID  |  EventType  |  Description";
            this.lblFormat.Location = new Point(15, 42);
            this.lblFormat.Size = new Size(800, 20);
            this.lblFormat.Name = "lblFormat";

            this.lblExample.Font = new Font("Courier New", 8.5F);
            this.lblExample.ForeColor = green;
            this.lblExample.Text = "2026-05-01 10:23:01,1,Login,User logged in successfully";
            this.lblExample.Location = new Point(15, 68);
            this.lblExample.Size = new Size(900, 20);
            this.lblExample.Name = "lblExample";

            // btnImport
            this.btnImport.BackColor = Color.FromArgb(0, 60, 50);
            this.btnImport.ForeColor = cyan;
            this.btnImport.FlatStyle = FlatStyle.Flat;
            this.btnImport.FlatAppearance.BorderColor = cyanDim;
            this.btnImport.FlatAppearance.BorderSize = 1;
            this.btnImport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnImport.Text = "IMPORT CSV FILE";
            this.btnImport.Location = new Point(20, 170);
            this.btnImport.Size = new Size(200, 42);
            this.btnImport.Cursor = Cursors.Hand;
            this.btnImport.Name = "btnImport";
            this.btnImport.Click += new EventHandler(this.btnImport_Click);

            // btnSample
            this.btnSample.BackColor = Color.FromArgb(30, 40, 20);
            this.btnSample.ForeColor = green;
            this.btnSample.FlatStyle = FlatStyle.Flat;
            this.btnSample.FlatAppearance.BorderColor = greenDim;
            this.btnSample.FlatAppearance.BorderSize = 1;
            this.btnSample.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSample.Text = "DOWNLOAD SAMPLE CSV";
            this.btnSample.Location = new Point(235, 170);
            this.btnSample.Size = new Size(210, 42);
            this.btnSample.Cursor = Cursors.Hand;
            this.btnSample.Name = "btnSample";
            this.btnSample.Click += new EventHandler(this.btnSample_Click);

            // progressBar
            this.progressBar.Location = new Point(20, 225);
            this.progressBar.Size = new Size(1000, 8);
            this.progressBar.Name = "progressBar";
            this.progressBar.Style = ProgressBarStyle.Continuous;
            this.progressBar.ForeColor = cyan;
            this.progressBar.Value = 0;
            this.progressBar.Visible = false;

            // lblStatus
            this.lblStatus.Font = new Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = cyan;
            this.lblStatus.Text = "No file imported yet.";
            this.lblStatus.Location = new Point(20, 240);
            this.lblStatus.Size = new Size(1000, 25);
            this.lblStatus.Name = "lblStatus";

            // lblResultTitle
            this.lblResultTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblResultTitle.ForeColor = cyan;
            this.lblResultTitle.Text = "IMPORTED EVENTS";
            this.lblResultTitle.Location = new Point(20, 272);
            this.lblResultTitle.Size = new Size(400, 25);
            this.lblResultTitle.Name = "lblResultTitle";

            // dgvResults
            this.dgvResults.BackgroundColor = bgPanel;
            this.dgvResults.BorderStyle = BorderStyle.None;
            this.dgvResults.Location = new Point(20, 302);
            this.dgvResults.Size = new Size(1000, 310);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.GridColor = Color.FromArgb(25, 35, 55);
            this.dgvResults.DefaultCellStyle.BackColor = bgPanel;
            this.dgvResults.DefaultCellStyle.ForeColor = textMain;
            this.dgvResults.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 60, 50);
            this.dgvResults.DefaultCellStyle.SelectionForeColor = cyan;
            this.dgvResults.AlternatingRowsDefaultCellStyle.BackColor = bgInput;
            this.dgvResults.AlternatingRowsDefaultCellStyle.ForeColor = textMain;
            this.dgvResults.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 40, 35);
            this.dgvResults.ColumnHeadersDefaultCellStyle.ForeColor = cyan;
            this.dgvResults.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Form
            this.BackColor = bgDark;
            this.ClientSize = new Size(1060, 650);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LogImporterForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sentialx — Log Importer";
            this.Load += new EventHandler(this.LogImporterForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
        }

        private Panel panelTop;
        private Panel panelMain;
        private Panel panelInfo;
        private Label lblTitle;
        private Label lblInfoTitle;
        private Label lblFormat;
        private Label lblExample;
        private Button btnImport;
        private Button btnSample;
        private ProgressBar progressBar;
        private Label lblStatus;
        private Label lblResultTitle;
        private DataGridView dgvResults;
    }
}
