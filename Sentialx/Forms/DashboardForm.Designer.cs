using System;
using System.Windows.Forms;

namespace Sentialx.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new Panel();
            this.lblTitle = new Label();
            this.lblUser = new Label();
            this.panelSide = new Panel();
            this.btnDashboard = new Button();
            this.btnUsers = new Button();
            this.btnEvents = new Button();
            this.btnFilter = new Button();
            this.btnAlerts = new Button();
            this.btnReport = new Button();
            this.btnImport = new Button();
            this.btnEventLogger = new Button();
            this.btnLogout = new Button();
            this.panelMain = new Panel();
            this.cardTotalEvents = new Panel();
            this.lblTotalEventsNum = new Label();
            this.lblTotalEventsTitle = new Label();
            this.cardOpenAlerts = new Panel();
            this.lblOpenAlertsNum = new Label();
            this.lblOpenAlertsTitle = new Label();
            this.cardHighAlerts = new Panel();
            this.lblHighAlertsNum = new Label();
            this.lblHighAlertsTitle = new Label();
            this.cardUsers = new Panel();
            this.lblUsersNum = new Label();
            this.lblUsersTitle = new Label();
            this.lblRecentTitle = new Label();
            this.dgvRecent = new DataGridView();
            this.panelTop.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.cardTotalEvents.SuspendLayout();
            this.cardOpenAlerts.SuspendLayout();
            this.cardHighAlerts.SuspendLayout();
            this.cardUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.SuspendLayout();

            System.Drawing.Color bgDark = System.Drawing.Color.FromArgb(10, 14, 26);
            System.Drawing.Color bgCard = System.Drawing.Color.FromArgb(16, 22, 36);
            System.Drawing.Color bgSide = System.Drawing.Color.FromArgb(13, 18, 30);
            System.Drawing.Color cyan = System.Drawing.Color.FromArgb(0, 255, 200);
            System.Drawing.Color cyanDim = System.Drawing.Color.FromArgb(0, 180, 140);
            System.Drawing.Color red = System.Drawing.Color.FromArgb(255, 70, 70);
            System.Drawing.Color orange = System.Drawing.Color.FromArgb(255, 160, 50);
            System.Drawing.Color green = System.Drawing.Color.FromArgb(50, 220, 120);
            System.Drawing.Color muted = System.Drawing.Color.FromArgb(100, 120, 150);
            System.Drawing.Color textMain = System.Drawing.Color.FromArgb(200, 215, 230);
            System.Drawing.Color gridBg = System.Drawing.Color.FromArgb(16, 22, 36);

            // panelTop
            this.panelTop.BackColor = bgDark;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblUser);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1100, 55);
            this.panelTop.Name = "panelTop";

            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = cyan;
            this.lblTitle.Text = "SENTIALX  —  Threat Monitoring Dashboard";
            this.lblTitle.Location = new System.Drawing.Point(20, 13);
            this.lblTitle.Size = new System.Drawing.Size(600, 30);
            this.lblTitle.Name = "lblTitle";

            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUser.ForeColor = muted;
            this.lblUser.Text = "ONLINE  |  admin";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUser.Location = new System.Drawing.Point(700, 13);
            this.lblUser.Size = new System.Drawing.Size(380, 30);
            this.lblUser.Name = "lblUser";

            // panelSide
            this.panelSide.BackColor = bgSide;
            this.panelSide.Controls.Add(this.btnDashboard);
            this.panelSide.Controls.Add(this.btnUsers);
            this.panelSide.Controls.Add(this.btnEvents);
            this.panelSide.Controls.Add(this.btnFilter);
            this.panelSide.Controls.Add(this.btnAlerts);
            this.panelSide.Controls.Add(this.btnReport);
            this.panelSide.Controls.Add(this.btnImport);
            this.panelSide.Controls.Add(this.btnEventLogger);
            this.panelSide.Controls.Add(this.btnLogout);
            this.panelSide.Dock = DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 55);
            this.panelSide.Size = new System.Drawing.Size(210, 645);
            this.panelSide.Name = "panelSide";

            string[] btnNames = { "btnDashboard", "btnUsers", "btnEvents", "btnFilter", "btnAlerts", "btnReport", "btnImport", "btnEventLogger", "btnLogout" };
            string[] btnTexts = { "  Dashboard", "  User Management", "  Event Viewer", "  Filter & Search", "  Alerts", "  Report Generator", "  Log Importer", "  Event Logger", "  Logout" };
            Button[] btns = { btnDashboard, btnUsers, btnEvents, btnFilter, btnAlerts, btnReport, btnImport, btnEventLogger, btnLogout };

            for (int i = 0; i < btns.Length; i++)
            {
                btns[i].BackColor = bgSide;
                btns[i].ForeColor = muted;
                btns[i].FlatStyle = FlatStyle.Flat;
                btns[i].FlatAppearance.BorderSize = 0;
                btns[i].Font = new System.Drawing.Font("Segoe UI", 9.5F);
                btns[i].Text = btnTexts[i];
                btns[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btns[i].Padding = new Padding(15, 0, 0, 0);
                btns[i].Size = new System.Drawing.Size(210, 48);
                btns[i].Location = new System.Drawing.Point(0, 20 + i * 52);
                btns[i].Cursor = Cursors.Hand;
                btns[i].Name = btnNames[i];
            }

            btnDashboard.ForeColor = cyan;
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(0, 40, 35);
            btnLogout.ForeColor = red;
            btnLogout.Location = new System.Drawing.Point(0, 600);

            // panelMain
            this.panelMain.BackColor = bgDark;
            this.panelMain.Controls.Add(this.cardTotalEvents);
            this.panelMain.Controls.Add(this.cardOpenAlerts);
            this.panelMain.Controls.Add(this.cardHighAlerts);
            this.panelMain.Controls.Add(this.cardUsers);
            this.panelMain.Controls.Add(this.lblRecentTitle);
            this.panelMain.Controls.Add(this.dgvRecent);
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(210, 55);
            this.panelMain.Name = "panelMain";

            SetupCard(cardTotalEvents, lblTotalEventsNum, lblTotalEventsTitle, "0", "TOTAL EVENTS", 20, 20, cyan, bgCard);
            SetupCard(cardOpenAlerts, lblOpenAlertsNum, lblOpenAlertsTitle, "0", "OPEN ALERTS", 235, 20, red, bgCard);
            SetupCard(cardHighAlerts, lblHighAlertsNum, lblHighAlertsTitle, "0", "HIGH SEVERITY", 450, 20, orange, bgCard);
            SetupCard(cardUsers, lblUsersNum, lblUsersTitle, "0", "TOTAL USERS", 665, 20, green, bgCard);

            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecentTitle.ForeColor = cyan;
            this.lblRecentTitle.Text = "RECENT EVENTS";
            this.lblRecentTitle.Location = new System.Drawing.Point(20, 165);
            this.lblRecentTitle.Size = new System.Drawing.Size(300, 28);
            this.lblRecentTitle.Name = "lblRecentTitle";

            this.dgvRecent.BackgroundColor = gridBg;
            this.dgvRecent.BorderStyle = BorderStyle.None;
            this.dgvRecent.Location = new System.Drawing.Point(20, 198);
            this.dgvRecent.Size = new System.Drawing.Size(840, 390);
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.GridColor = System.Drawing.Color.FromArgb(25, 35, 55);
            this.dgvRecent.DefaultCellStyle.BackColor = gridBg;
            this.dgvRecent.DefaultCellStyle.ForeColor = textMain;
            this.dgvRecent.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 60, 50);
            this.dgvRecent.DefaultCellStyle.SelectionForeColor = cyan;
            this.dgvRecent.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 28, 45);
            this.dgvRecent.AlternatingRowsDefaultCellStyle.ForeColor = textMain;
            this.dgvRecent.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 40, 35);
            this.dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor = cyan;
            this.dgvRecent.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvRecent.EnableHeadersVisualStyles = false;
            this.dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Form
            this.BackColor = bgDark;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sentialx — Dashboard";
            this.Load += new EventHandler(this.DashboardForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.cardTotalEvents.ResumeLayout(false);
            this.cardOpenAlerts.ResumeLayout(false);
            this.cardHighAlerts.ResumeLayout(false);
            this.cardUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.ResumeLayout(false);
        }

        private void SetupCard(Panel card, Label numLabel, Label titleLabel,
            string num, string title, int x, int y,
            System.Drawing.Color accent, System.Drawing.Color bg)
        {
            card.BackColor = bg;
            card.Size = new System.Drawing.Size(200, 115);
            card.Location = new System.Drawing.Point(x, y);

            numLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            numLabel.ForeColor = accent;
            numLabel.Text = num;
            numLabel.Location = new System.Drawing.Point(15, 12);
            numLabel.Size = new System.Drawing.Size(170, 55);

            titleLabel.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            titleLabel.ForeColor = System.Drawing.Color.FromArgb(80, 100, 130);
            titleLabel.Text = title;
            titleLabel.Location = new System.Drawing.Point(15, 70);
            titleLabel.Size = new System.Drawing.Size(170, 25);

            card.Controls.Add(numLabel);
            card.Controls.Add(titleLabel);
        }

        private Panel panelTop;
        private Panel panelSide;
        private Panel panelMain;
        private Label lblTitle;
        private Label lblUser;
        private Button btnDashboard;
        private Button btnUsers;
        private Button btnEvents;
        private Button btnFilter;
        private Button btnAlerts;
        private Button btnReport;
        private Button btnImport;
        private Button btnLogout;
        private Panel cardTotalEvents;
        private Label lblTotalEventsNum;
        private Label lblTotalEventsTitle;
        private Panel cardOpenAlerts;
        private Label lblOpenAlertsNum;
        private Label lblOpenAlertsTitle;
        private Button btnEventLogger;
        private Panel cardHighAlerts;
        private Label lblHighAlertsNum;
        private Label lblHighAlertsTitle;
        private Panel cardUsers;
        private Label lblUsersNum;
        private Label lblUsersTitle;
        private Label lblRecentTitle;
        private DataGridView dgvRecent;
    }
}