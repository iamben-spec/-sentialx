using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sentialx.Forms
{
    partial class ReportGeneratorForm
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
            this.panelFilters = new Panel();
            this.lblFilterTitle = new Label();
            this.lblEventType = new Label();
            this.cmbEventType = new ComboBox();
            this.lblFromDate = new Label();
            this.dtpFrom = new DateTimePicker();
            this.lblToDate = new Label();
            this.dtpTo = new DateTimePicker();
            this.lblSeverity = new Label();
            this.cmbSeverity = new ComboBox();
            this.lblMinCount = new Label();
            this.numMinCount = new NumericUpDown();
            this.chkAlerts = new CheckBox();
            this.btnGenerate = new Button();
            this.btnExport = new Button();
            this.btnClear = new Button();
            this.lblReportTitle = new Label();
            this.rtbReport = new RichTextBox();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((ISupportInitialize)(this.numMinCount)).BeginInit();
            this.SuspendLayout();

            Color bgDark = Color.FromArgb(10, 14, 26);
            Color bgPanel = Color.FromArgb(16, 22, 36);
            Color bgInput = Color.FromArgb(20, 28, 45);
            Color cyan = Color.FromArgb(0, 255, 200);
            Color cyanDim = Color.FromArgb(0, 180, 140);
            Color purple = Color.FromArgb(167, 139, 250);
            Color purpleDim = Color.FromArgb(109, 40, 217);
            Color muted = Color.FromArgb(100, 120, 150);
            Color textMain = Color.FromArgb(200, 215, 230);

            // panelTop
            this.panelTop.BackColor = bgDark;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Size = new Size(1060, 55);
            this.panelTop.Name = "panelTop";

            this.lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            this.lblTitle.ForeColor = purple;
            this.lblTitle.Text = "SENTIALX  —  Report Generator";
            this.lblTitle.Location = new Point(20, 13);
            this.lblTitle.Size = new Size(500, 30);
            this.lblTitle.Name = "lblTitle";

            // panelMain
            this.panelMain.BackColor = bgDark;
            this.panelMain.Controls.Add(this.panelFilters);
            this.panelMain.Controls.Add(this.lblReportTitle);
            this.panelMain.Controls.Add(this.rtbReport);
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Name = "panelMain";

            // panelFilters
            this.panelFilters.BackColor = bgPanel;
            this.panelFilters.Controls.Add(this.lblFilterTitle);
            this.panelFilters.Controls.Add(this.lblEventType);
            this.panelFilters.Controls.Add(this.cmbEventType);
            this.panelFilters.Controls.Add(this.lblFromDate);
            this.panelFilters.Controls.Add(this.dtpFrom);
            this.panelFilters.Controls.Add(this.lblToDate);
            this.panelFilters.Controls.Add(this.dtpTo);
            this.panelFilters.Controls.Add(this.lblSeverity);
            this.panelFilters.Controls.Add(this.cmbSeverity);
            this.panelFilters.Controls.Add(this.lblMinCount);
            this.panelFilters.Controls.Add(this.numMinCount);
            this.panelFilters.Controls.Add(this.chkAlerts);
            this.panelFilters.Controls.Add(this.btnGenerate);
            this.panelFilters.Controls.Add(this.btnExport);
            this.panelFilters.Controls.Add(this.btnClear);
            this.panelFilters.Location = new Point(20, 20);
            this.panelFilters.Size = new Size(1000, 160);
            this.panelFilters.Name = "panelFilters";

            // lblFilterTitle
            this.lblFilterTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblFilterTitle.ForeColor = purple;
            this.lblFilterTitle.Text = "REPORT CONDITIONS";
            this.lblFilterTitle.Location = new Point(15, 12);
            this.lblFilterTitle.Size = new Size(300, 25);
            this.lblFilterTitle.Name = "lblFilterTitle";

            // Event Type
            this.lblEventType.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            this.lblEventType.ForeColor = muted;
            this.lblEventType.Text = "EVENT TYPE";
            this.lblEventType.Location = new Point(15, 48);
            this.lblEventType.Size = new Size(140, 16);
            this.lblEventType.Name = "lblEventType";

            this.cmbEventType.BackColor = bgInput;
            this.cmbEventType.ForeColor = textMain;
            this.cmbEventType.FlatStyle = FlatStyle.Flat;
            this.cmbEventType.Font = new Font("Segoe UI", 9F);
            this.cmbEventType.Location = new Point(15, 67);
            this.cmbEventType.Size = new Size(140, 28);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbEventType.Items.AddRange(new object[] { "All", "Login", "FailedLogin", "Action", "Delete", "Error" });
            this.cmbEventType.SelectedIndex = 0;

            // From Date
            this.lblFromDate.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            this.lblFromDate.ForeColor = muted;
            this.lblFromDate.Text = "FROM DATE";
            this.lblFromDate.Location = new Point(170, 48);
            this.lblFromDate.Size = new Size(140, 16);
            this.lblFromDate.Name = "lblFromDate";

            this.dtpFrom.Font = new Font("Segoe UI", 9F);
            this.dtpFrom.Format = DateTimePickerFormat.Short;
            this.dtpFrom.Location = new Point(170, 67);
            this.dtpFrom.Size = new Size(140, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Value = DateTime.Now.AddDays(-30);

            // To Date
            this.lblToDate.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            this.lblToDate.ForeColor = muted;
            this.lblToDate.Text = "TO DATE";
            this.lblToDate.Location = new Point(325, 48);
            this.lblToDate.Size = new Size(140, 16);
            this.lblToDate.Name = "lblToDate";

            this.dtpTo.Font = new Font("Segoe UI", 9F);
            this.dtpTo.Format = DateTimePickerFormat.Short;
            this.dtpTo.Location = new Point(325, 67);
            this.dtpTo.Size = new Size(140, 28);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Value = DateTime.Now;

            // Severity
            this.lblSeverity.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            this.lblSeverity.ForeColor = muted;
            this.lblSeverity.Text = "SEVERITY";
            this.lblSeverity.Location = new Point(480, 48);
            this.lblSeverity.Size = new Size(140, 16);
            this.lblSeverity.Name = "lblSeverity";

            this.cmbSeverity.BackColor = bgInput;
            this.cmbSeverity.ForeColor = textMain;
            this.cmbSeverity.FlatStyle = FlatStyle.Flat;
            this.cmbSeverity.Font = new Font("Segoe UI", 9F);
            this.cmbSeverity.Location = new Point(480, 67);
            this.cmbSeverity.Size = new Size(140, 28);
            this.cmbSeverity.Name = "cmbSeverity";
            this.cmbSeverity.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSeverity.Items.AddRange(new object[] { "All", "High", "Medium", "Low" });
            this.cmbSeverity.SelectedIndex = 0;

            // Min Count
            this.lblMinCount.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            this.lblMinCount.ForeColor = muted;
            this.lblMinCount.Text = "MIN OCCURRENCES";
            this.lblMinCount.Location = new Point(635, 48);
            this.lblMinCount.Size = new Size(150, 16);
            this.lblMinCount.Name = "lblMinCount";

            this.numMinCount.BackColor = bgInput;
            this.numMinCount.ForeColor = textMain;
            this.numMinCount.BorderStyle = BorderStyle.FixedSingle;
            this.numMinCount.Font = new Font("Segoe UI", 9F);
            this.numMinCount.Location = new Point(635, 67);
            this.numMinCount.Size = new Size(100, 28);
            this.numMinCount.Name = "numMinCount";
            this.numMinCount.Minimum = 0;
            this.numMinCount.Maximum = 1000;
            this.numMinCount.Value = 0;

            // Include Alerts
            this.chkAlerts.ForeColor = textMain;
            this.chkAlerts.Font = new Font("Segoe UI", 9F);
            this.chkAlerts.Text = "Include Alerts";
            this.chkAlerts.Location = new Point(750, 70);
            this.chkAlerts.Size = new Size(130, 25);
            this.chkAlerts.Name = "chkAlerts";
            this.chkAlerts.Checked = true;

            // btnGenerate
            this.btnGenerate.BackColor = Color.FromArgb(50, 20, 80);
            this.btnGenerate.ForeColor = purple;
            this.btnGenerate.FlatStyle = FlatStyle.Flat;
            this.btnGenerate.FlatAppearance.BorderColor = purpleDim;
            this.btnGenerate.FlatAppearance.BorderSize = 1;
            this.btnGenerate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.Location = new Point(15, 110);
            this.btnGenerate.Size = new Size(150, 36);
            this.btnGenerate.Cursor = Cursors.Hand;
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Click += new EventHandler(this.btnGenerate_Click);

            // btnExport
            this.btnExport.BackColor = Color.FromArgb(0, 60, 50);
            this.btnExport.ForeColor = cyan;
            this.btnExport.FlatStyle = FlatStyle.Flat;
            this.btnExport.FlatAppearance.BorderColor = cyanDim;
            this.btnExport.FlatAppearance.BorderSize = 1;
            this.btnExport.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnExport.Text = "EXPORT .TXT";
            this.btnExport.Location = new Point(180, 110);
            this.btnExport.Size = new Size(150, 36);
            this.btnExport.Cursor = Cursors.Hand;
            this.btnExport.Name = "btnExport";
            this.btnExport.Click += new EventHandler(this.btnExport_Click);

            // btnClear
            this.btnClear.BackColor = Color.FromArgb(25, 30, 45);
            this.btnClear.ForeColor = muted;
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderColor = muted;
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnClear.Text = "CLEAR";
            this.btnClear.Location = new Point(345, 110);
            this.btnClear.Size = new Size(120, 36);
            this.btnClear.Cursor = Cursors.Hand;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new EventHandler(this.btnClear_Click);

            // lblReportTitle
            this.lblReportTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblReportTitle.ForeColor = purple;
            this.lblReportTitle.Text = "REPORT OUTPUT";
            this.lblReportTitle.Location = new Point(20, 195);
            this.lblReportTitle.Size = new Size(300, 25);
            this.lblReportTitle.Name = "lblReportTitle";

            // rtbReport
            this.rtbReport.BackColor = bgPanel;
            this.rtbReport.ForeColor = textMain;
            this.rtbReport.Font = new Font("Courier New", 9F);
            this.rtbReport.BorderStyle = BorderStyle.None;
            this.rtbReport.Location = new Point(20, 225);
            this.rtbReport.Size = new Size(1000, 360);
            this.rtbReport.Name = "rtbReport";
            this.rtbReport.ReadOnly = true;
            this.rtbReport.ScrollBars = RichTextBoxScrollBars.Vertical;

            // Form
            this.BackColor = bgDark;
            this.ClientSize = new Size(1060, 650);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportGeneratorForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sentialx — Report Generator";
            this.Load += new EventHandler(this.ReportGeneratorForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            ((ISupportInitialize)(this.numMinCount)).EndInit();
            this.ResumeLayout(false);
        }

        private Panel panelTop;
        private Panel panelMain;
        private Panel panelFilters;
        private Label lblTitle;
        private Label lblFilterTitle;
        private Label lblEventType;
        private ComboBox cmbEventType;
        private Label lblFromDate;
        private DateTimePicker dtpFrom;
        private Label lblToDate;
        private DateTimePicker dtpTo;
        private Label lblSeverity;
        private ComboBox cmbSeverity;
        private Label lblMinCount;
        private NumericUpDown numMinCount;
        private CheckBox chkAlerts;
        private Button btnGenerate;
        private Button btnExport;
        private Button btnClear;
        private Label lblReportTitle;
        private RichTextBox rtbReport;
    }
}
