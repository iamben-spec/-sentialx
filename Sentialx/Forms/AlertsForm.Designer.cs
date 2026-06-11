namespace Sentialx.Forms
{
    partial class AlertsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.cmbSeverity = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnResolve = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvAlerts = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).BeginInit();
            this.SuspendLayout();

            var bgDark = System.Drawing.Color.FromArgb(10, 14, 26);
            var bgPanel = System.Drawing.Color.FromArgb(16, 22, 36);
            var bgInput = System.Drawing.Color.FromArgb(20, 28, 45);
            var cyan = System.Drawing.Color.FromArgb(0, 255, 200);
            var cyanDim = System.Drawing.Color.FromArgb(0, 180, 140);
            var red = System.Drawing.Color.FromArgb(255, 70, 70);
            var orange = System.Drawing.Color.FromArgb(255, 160, 50);
            var green = System.Drawing.Color.FromArgb(50, 220, 120);
            var muted = System.Drawing.Color.FromArgb(100, 120, 150);
            var textMain = System.Drawing.Color.FromArgb(200, 215, 230);

            // panelTop
            this.panelTop.BackColor = bgDark;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1060, 55);

            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = red;
            this.lblTitle.Text = "⬡  SENTIALX  —  Alerts";
            this.lblTitle.Location = new System.Drawing.Point(20, 13);
            this.lblTitle.Size = new System.Drawing.Size(500, 30);

            // panelMain
            this.panelMain.BackColor = bgDark;
            this.panelMain.Controls.Add(this.panelFilters);
            this.panelMain.Controls.Add(this.lblCount);
            this.panelMain.Controls.Add(this.dgvAlerts);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);

            // panelFilters
            this.panelFilters.BackColor = bgPanel;
            this.panelFilters.Controls.Add(this.lblSeverity);
            this.panelFilters.Controls.Add(this.cmbSeverity);
            this.panelFilters.Controls.Add(this.btnFilter);
            this.panelFilters.Controls.Add(this.btnRefresh);
            this.panelFilters.Controls.Add(this.btnResolve);
            this.panelFilters.Location = new System.Drawing.Point(20, 20);
            this.panelFilters.Size = new System.Drawing.Size(1000, 80);

            // lblSeverity
            this.lblSeverity.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSeverity.ForeColor = muted;
            this.lblSeverity.Text = "SEVERITY";
            this.lblSeverity.Location = new System.Drawing.Point(15, 12);
            this.lblSeverity.Size = new System.Drawing.Size(100, 16);

            // cmbSeverity
            this.cmbSeverity.BackColor = bgInput;
            this.cmbSeverity.ForeColor = textMain;
            this.cmbSeverity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSeverity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbSeverity.Location = new System.Drawing.Point(15, 32);
            this.cmbSeverity.Size = new System.Drawing.Size(160, 28);
            this.cmbSeverity.Name = "cmbSeverity";
            this.cmbSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeverity.Items.AddRange(new object[] { "All", "High", "Medium", "Low" });
            this.cmbSeverity.SelectedIndex = 0;

            // btnFilter
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(0, 60, 50);
            this.btnFilter.ForeColor = cyan;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.FlatAppearance.BorderColor = cyanDim;
            this.btnFilter.FlatAppearance.BorderSize = 1;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Text = "🔍  FILTER";
            this.btnFilter.Location = new System.Drawing.Point(190, 30);
            this.btnFilter.Size = new System.Drawing.Size(130, 36);
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);

            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(25, 30, 45);
            this.btnRefresh.ForeColor = muted;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderColor = muted;
            this.btnRefresh.FlatAppearance.BorderSize = 1;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Text = "↺  REFRESH";
            this.btnRefresh.Location = new System.Drawing.Point(335, 30);
            this.btnRefresh.Size = new System.Drawing.Size(130, 36);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // btnResolve
            this.btnResolve.BackColor = System.Drawing.Color.FromArgb(40, 50, 20);
            this.btnResolve.ForeColor = green;
            this.btnResolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolve.FlatAppearance.BorderColor = green;
            this.btnResolve.FlatAppearance.BorderSize = 1;
            this.btnResolve.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnResolve.Text = "✓  RESOLVE SELECTED";
            this.btnResolve.Location = new System.Drawing.Point(480, 30);
            this.btnResolve.Size = new System.Drawing.Size(190, 36);
            this.btnResolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);

            // lblCount
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = red;
            this.lblCount.Text = "▶  OPEN ALERTS";
            this.lblCount.Location = new System.Drawing.Point(20, 115);
            this.lblCount.Size = new System.Drawing.Size(400, 25);
            this.lblCount.Name = "lblCount";

            // dgvAlerts
            this.dgvAlerts.BackgroundColor = bgPanel;
            this.dgvAlerts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlerts.Location = new System.Drawing.Point(20, 145);
            this.dgvAlerts.Size = new System.Drawing.Size(1000, 440);
            this.dgvAlerts.Name = "dgvAlerts";
            this.dgvAlerts.ReadOnly = true;
            this.dgvAlerts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlerts.RowHeadersVisible = false;
            this.dgvAlerts.AllowUserToAddRows = false;
            this.dgvAlerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlerts.MultiSelect = false;
            this.dgvAlerts.GridColor = System.Drawing.Color.FromArgb(25, 35, 55);
            this.dgvAlerts.DefaultCellStyle.BackColor = bgPanel;
            this.dgvAlerts.DefaultCellStyle.ForeColor = textMain;
            this.dgvAlerts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(60, 15, 15);
            this.dgvAlerts.DefaultCellStyle.SelectionForeColor = red;
            this.dgvAlerts.AlternatingRowsDefaultCellStyle.BackColor = bgInput;
            this.dgvAlerts.AlternatingRowsDefaultCellStyle.ForeColor = textMain;
            this.dgvAlerts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 15, 15);
            this.dgvAlerts.ColumnHeadersDefaultCellStyle.ForeColor = red;
            this.dgvAlerts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvAlerts.EnableHeadersVisualStyles = false;
            this.dgvAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Form
            this.BackColor = bgDark;
            this.ClientSize = new System.Drawing.Size(1060, 650);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlertsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentialx — Alerts";
            this.Load += new System.EventHandler(this.AlertsForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSeverity;
        private System.Windows.Forms.ComboBox cmbSeverity;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvAlerts;
    }
}