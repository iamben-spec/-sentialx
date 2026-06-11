namespace Sentialx.Forms
{
    partial class FilterSearchForm
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
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();

            var bgDark = System.Drawing.Color.FromArgb(10, 14, 26);
            var bgPanel = System.Drawing.Color.FromArgb(16, 22, 36);
            var bgInput = System.Drawing.Color.FromArgb(20, 28, 45);
            var cyan = System.Drawing.Color.FromArgb(0, 255, 200);
            var cyanDim = System.Drawing.Color.FromArgb(0, 180, 140);
            var muted = System.Drawing.Color.FromArgb(100, 120, 150);
            var textMain = System.Drawing.Color.FromArgb(200, 215, 230);

            // panelTop
            this.panelTop.BackColor = bgDark;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1060, 55);

            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = cyan;
            this.lblTitle.Text = "⬡  SENTIALX  —  Filter & Search";
            this.lblTitle.Location = new System.Drawing.Point(20, 13);
            this.lblTitle.Size = new System.Drawing.Size(500, 30);

            // panelMain
            this.panelMain.BackColor = bgDark;
            this.panelMain.Controls.Add(this.panelFilters);
            this.panelMain.Controls.Add(this.lblResults);
            this.panelMain.Controls.Add(this.dgvResults);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);

            // panelFilters
            this.panelFilters.BackColor = bgPanel;
            this.panelFilters.Controls.Add(this.lblFilterTitle);
            this.panelFilters.Controls.Add(this.lblEventType);
            this.panelFilters.Controls.Add(this.cmbEventType);
            this.panelFilters.Controls.Add(this.lblUsername);
            this.panelFilters.Controls.Add(this.txtUsername);
            this.panelFilters.Controls.Add(this.lblFromDate);
            this.panelFilters.Controls.Add(this.dtpFrom);
            this.panelFilters.Controls.Add(this.lblToDate);
            this.panelFilters.Controls.Add(this.dtpTo);
            this.panelFilters.Controls.Add(this.btnSearch);
            this.panelFilters.Controls.Add(this.btnClear);
            this.panelFilters.Location = new System.Drawing.Point(20, 20);
            this.panelFilters.Size = new System.Drawing.Size(1000, 130);

            // lblFilterTitle
            this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.ForeColor = cyan;
            this.lblFilterTitle.Text = "▶  SEARCH FILTERS";
            this.lblFilterTitle.Location = new System.Drawing.Point(15, 12);
            this.lblFilterTitle.Size = new System.Drawing.Size(200, 25);

            // Event Type
            this.lblEventType.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEventType.ForeColor = muted;
            this.lblEventType.Text = "EVENT TYPE";
            this.lblEventType.Location = new System.Drawing.Point(15, 48);
            this.lblEventType.Size = new System.Drawing.Size(150, 16);

            this.cmbEventType.BackColor = bgInput;
            this.cmbEventType.ForeColor = textMain;
            this.cmbEventType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEventType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbEventType.Location = new System.Drawing.Point(15, 67);
            this.cmbEventType.Size = new System.Drawing.Size(160, 28);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventType.Items.AddRange(new object[] { "All", "Login", "FailedLogin", "Action", "Delete", "Error" });
            this.cmbEventType.SelectedIndex = 0;

            // Username
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = muted;
            this.lblUsername.Text = "USERNAME";
            this.lblUsername.Location = new System.Drawing.Point(195, 48);
            this.lblUsername.Size = new System.Drawing.Size(150, 16);

            this.txtUsername.BackColor = bgInput;
            this.txtUsername.ForeColor = textMain;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUsername.Location = new System.Drawing.Point(195, 67);
            this.txtUsername.Size = new System.Drawing.Size(160, 28);
            this.txtUsername.Name = "txtUsername";

            // From Date
            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFromDate.ForeColor = muted;
            this.lblFromDate.Text = "FROM DATE";
            this.lblFromDate.Location = new System.Drawing.Point(375, 48);
            this.lblFromDate.Size = new System.Drawing.Size(150, 16);

            this.dtpFrom.CalendarForeColor = textMain;
            this.dtpFrom.CalendarMonthBackground = bgPanel;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(375, 67);
            this.dtpFrom.Size = new System.Drawing.Size(150, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Value = System.DateTime.Now.AddDays(-30);

            // To Date
            this.lblToDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblToDate.ForeColor = muted;
            this.lblToDate.Text = "TO DATE";
            this.lblToDate.Location = new System.Drawing.Point(540, 48);
            this.lblToDate.Size = new System.Drawing.Size(150, 16);

            this.dtpTo.CalendarForeColor = textMain;
            this.dtpTo.CalendarMonthBackground = bgPanel;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(540, 67);
            this.dtpTo.Size = new System.Drawing.Size(150, 28);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Value = System.DateTime.Now;

            // btnSearch
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 60, 50);
            this.btnSearch.ForeColor = cyan;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderColor = cyanDim;
            this.btnSearch.FlatAppearance.BorderSize = 1;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Text = "🔍  SEARCH";
            this.btnSearch.Location = new System.Drawing.Point(710, 60);
            this.btnSearch.Size = new System.Drawing.Size(130, 38);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(25, 30, 45);
            this.btnClear.ForeColor = muted;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderColor = muted;
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClear.Text = "↺  CLEAR";
            this.btnClear.Location = new System.Drawing.Point(855, 60);
            this.btnClear.Size = new System.Drawing.Size(130, 38);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // lblResults
            this.lblResults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResults.ForeColor = cyan;
            this.lblResults.Text = "▶  RESULTS";
            this.lblResults.Location = new System.Drawing.Point(20, 165);
            this.lblResults.Size = new System.Drawing.Size(300, 25);

            // dgvResults
            this.dgvResults.BackgroundColor = bgPanel;
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.Location = new System.Drawing.Point(20, 195);
            this.dgvResults.Size = new System.Drawing.Size(1000, 400);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.GridColor = System.Drawing.Color.FromArgb(25, 35, 55);
            this.dgvResults.DefaultCellStyle.BackColor = bgPanel;
            this.dgvResults.DefaultCellStyle.ForeColor = textMain;
            this.dgvResults.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 60, 50);
            this.dgvResults.DefaultCellStyle.SelectionForeColor = cyan;
            this.dgvResults.AlternatingRowsDefaultCellStyle.BackColor = bgInput;
            this.dgvResults.AlternatingRowsDefaultCellStyle.ForeColor = textMain;
            this.dgvResults.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 40, 35);
            this.dgvResults.ColumnHeadersDefaultCellStyle.ForeColor = cyan;
            this.dgvResults.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Form
            this.BackColor = bgDark;
            this.ClientSize = new System.Drawing.Size(1060, 650);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FilterSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentialx — Filter & Search";
            this.Load += new System.EventHandler(this.FilterSearchForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.ComboBox cmbEventType;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}