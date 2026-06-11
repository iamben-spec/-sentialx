namespace Sentialx.Forms
{
    partial class EventLoggerForm
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
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.dgvRecent = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.SuspendLayout();

            var bgDark = System.Drawing.Color.FromArgb(10, 14, 26);
            var bgPanel = System.Drawing.Color.FromArgb(16, 22, 36);
            var bgInput = System.Drawing.Color.FromArgb(20, 28, 45);
            var cyan = System.Drawing.Color.FromArgb(0, 255, 200);
            var cyanDim = System.Drawing.Color.FromArgb(0, 180, 140);
            var amber = System.Drawing.Color.FromArgb(255, 160, 50);
            var muted = System.Drawing.Color.FromArgb(100, 120, 150);
            var textMain = System.Drawing.Color.FromArgb(200, 215, 230);

            // panelTop
            this.panelTop.BackColor = bgDark;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1060, 55);

            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = amber;
            this.lblTitle.Text = "⬡  SENTIALX  —  Event Logger";
            this.lblTitle.Location = new System.Drawing.Point(20, 13);
            this.lblTitle.Size = new System.Drawing.Size(500, 30);

            // panelMain
            this.panelMain.BackColor = bgDark;
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(this.lblRecentTitle);
            this.panelMain.Controls.Add(this.dgvRecent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);

            // panelForm
            this.panelForm.BackColor = bgPanel;
            this.panelForm.Controls.Add(this.lblFormTitle);
            this.panelForm.Controls.Add(this.lblEventType);
            this.panelForm.Controls.Add(this.cmbEventType);
            this.panelForm.Controls.Add(this.lblDescription);
            this.panelForm.Controls.Add(this.txtDescription);
            this.panelForm.Controls.Add(this.btnLog);
            this.panelForm.Controls.Add(this.lblStatus);
            this.panelForm.Location = new System.Drawing.Point(20, 20);
            this.panelForm.Size = new System.Drawing.Size(1000, 180);

            // lblFormTitle
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = amber;
            this.lblFormTitle.Text = "▶  SIMULATE AN EVENT";
            this.lblFormTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFormTitle.Size = new System.Drawing.Size(400, 28);

            // lblEventType
            this.lblEventType.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEventType.ForeColor = muted;
            this.lblEventType.Text = "EVENT TYPE";
            this.lblEventType.Location = new System.Drawing.Point(20, 58);
            this.lblEventType.Size = new System.Drawing.Size(160, 16);

            // cmbEventType
            this.cmbEventType.BackColor = bgInput;
            this.cmbEventType.ForeColor = textMain;
            this.cmbEventType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEventType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbEventType.Location = new System.Drawing.Point(20, 77);
            this.cmbEventType.Size = new System.Drawing.Size(180, 28);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventType.Items.AddRange(new object[] { "Action", "Delete", "Error" });
            this.cmbEventType.SelectedIndex = 0;

            // lblDescription
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = muted;
            this.lblDescription.Text = "DESCRIPTION";
            this.lblDescription.Location = new System.Drawing.Point(220, 58);
            this.lblDescription.Size = new System.Drawing.Size(160, 16);

            // txtDescription
            this.txtDescription.BackColor = bgInput;
            this.txtDescription.ForeColor = textMain;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescription.Location = new System.Drawing.Point(220, 77);
            this.txtDescription.Size = new System.Drawing.Size(500, 28);
            this.txtDescription.Name = "txtDescription";

            // btnLog
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(50, 35, 0);
            this.btnLog.ForeColor = amber;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.FlatAppearance.BorderColor = amber;
            this.btnLog.FlatAppearance.BorderSize = 1;
            this.btnLog.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLog.Text = "LOG EVENT";
            this.btnLog.Location = new System.Drawing.Point(740, 70);
            this.btnLog.Size = new System.Drawing.Size(160, 38);
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.Name = "btnLog";
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);

            // lblStatus
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = cyan;
            this.lblStatus.Text = "";
            this.lblStatus.Location = new System.Drawing.Point(20, 130);
            this.lblStatus.Size = new System.Drawing.Size(900, 25);
            this.lblStatus.Name = "lblStatus";

            // lblRecentTitle
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecentTitle.ForeColor = amber;
            this.lblRecentTitle.Text = "▶  RECENTLY LOGGED EVENTS";
            this.lblRecentTitle.Location = new System.Drawing.Point(20, 220);
            this.lblRecentTitle.Size = new System.Drawing.Size(400, 25);

            // dgvRecent
            this.dgvRecent.BackgroundColor = bgPanel;
            this.dgvRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecent.Location = new System.Drawing.Point(20, 250);
            this.dgvRecent.Size = new System.Drawing.Size(1000, 340);
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.GridColor = System.Drawing.Color.FromArgb(25, 35, 55);
            this.dgvRecent.DefaultCellStyle.BackColor = bgPanel;
            this.dgvRecent.DefaultCellStyle.ForeColor = textMain;
            this.dgvRecent.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(50, 35, 0);
            this.dgvRecent.DefaultCellStyle.SelectionForeColor = amber;
            this.dgvRecent.AlternatingRowsDefaultCellStyle.BackColor = bgInput;
            this.dgvRecent.AlternatingRowsDefaultCellStyle.ForeColor = textMain;
            this.dgvRecent.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 35, 0);
            this.dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor = amber;
            this.dgvRecent.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvRecent.EnableHeadersVisualStyles = false;
            this.dgvRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Form
            this.BackColor = bgDark;
            this.ClientSize = new System.Drawing.Size(1060, 650);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EventLoggerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentialx — Event Logger";
            this.Load += new System.EventHandler(this.EventLoggerForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.ComboBox cmbEventType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRecentTitle;
        private System.Windows.Forms.DataGridView dgvRecent;
    }
}