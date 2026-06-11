namespace Sentialx.Forms
{
    partial class EventViewerForm
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
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();

            var bgDark = System.Drawing.Color.FromArgb(10, 14, 26);
            var bgPanel = System.Drawing.Color.FromArgb(16, 22, 36);
            var bgInput = System.Drawing.Color.FromArgb(20, 28, 45);
            var cyan = System.Drawing.Color.FromArgb(0, 255, 200);
            var cyanDim = System.Drawing.Color.FromArgb(0, 180, 140);
            var red = System.Drawing.Color.FromArgb(255, 70, 70);
            var muted = System.Drawing.Color.FromArgb(100, 120, 150);
            var textMain = System.Drawing.Color.FromArgb(200, 215, 230);

            // panelTop
            this.panelTop.BackColor = bgDark;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1060, 55);

            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = cyan;
            this.lblTitle.Text = "⬡  SENTIALX  —  Event Viewer";
            this.lblTitle.Location = new System.Drawing.Point(20, 13);
            this.lblTitle.Size = new System.Drawing.Size(500, 30);

            // panelMain
            this.panelMain.BackColor = bgDark;
            this.panelMain.Controls.Add(this.btnRefresh);
            this.panelMain.Controls.Add(this.btnDelete);
            this.panelMain.Controls.Add(this.dgvEvents);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);

            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(0, 60, 50);
            this.btnRefresh.ForeColor = cyan;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderColor = cyanDim;
            this.btnRefresh.FlatAppearance.BorderSize = 1;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Text = "↺  REFRESH";
            this.btnRefresh.Location = new System.Drawing.Point(20, 20);
            this.btnRefresh.Size = new System.Drawing.Size(150, 38);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(60, 15, 15);
            this.btnDelete.ForeColor = red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderColor = red;
            this.btnDelete.FlatAppearance.BorderSize = 1;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Text = "✕  DELETE SELECTED";
            this.btnDelete.Location = new System.Drawing.Point(185, 20);
            this.btnDelete.Size = new System.Drawing.Size(180, 38);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // dgvEvents
            this.dgvEvents.BackgroundColor = bgPanel;
            this.dgvEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEvents.Location = new System.Drawing.Point(20, 75);
            this.dgvEvents.Size = new System.Drawing.Size(1000, 530);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.MultiSelect = false;
            this.dgvEvents.GridColor = System.Drawing.Color.FromArgb(25, 35, 55);
            this.dgvEvents.DefaultCellStyle.BackColor = bgPanel;
            this.dgvEvents.DefaultCellStyle.ForeColor = textMain;
            this.dgvEvents.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 60, 50);
            this.dgvEvents.DefaultCellStyle.SelectionForeColor = cyan;
            this.dgvEvents.AlternatingRowsDefaultCellStyle.BackColor = bgInput;
            this.dgvEvents.AlternatingRowsDefaultCellStyle.ForeColor = textMain;
            this.dgvEvents.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 40, 35);
            this.dgvEvents.ColumnHeadersDefaultCellStyle.ForeColor = cyan;
            this.dgvEvents.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvEvents.EnableHeadersVisualStyles = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Form
            this.BackColor = bgDark;
            this.ClientSize = new System.Drawing.Size(1060, 650);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EventViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentialx — Event Viewer";
            this.Load += new System.EventHandler(this.EventViewerForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
    }
}