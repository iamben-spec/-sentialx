namespace Sentialx.Forms
{
    partial class UserManagementForm
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panelForm.SuspendLayout();
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
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(10, 14, 26);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1100, 55);

            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = cyan;
            this.lblTitle.Text = "⬡  SENTIALX  —  User Management";
            this.lblTitle.Location = new System.Drawing.Point(20, 13);
            this.lblTitle.Size = new System.Drawing.Size(500, 30);

            // panelMain
            this.panelMain.BackColor = bgDark;
            this.panelMain.Controls.Add(this.dgvUsers);
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);

            // dgvUsers
            this.dgvUsers.BackgroundColor = bgPanel;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.Location = new System.Drawing.Point(20, 20);
            this.dgvUsers.Size = new System.Drawing.Size(650, 550);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(25, 35, 55);
            this.dgvUsers.DefaultCellStyle.BackColor = bgPanel;
            this.dgvUsers.DefaultCellStyle.ForeColor = textMain;
            this.dgvUsers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 60, 50);
            this.dgvUsers.DefaultCellStyle.SelectionForeColor = cyan;
            this.dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 28, 45);
            this.dgvUsers.AlternatingRowsDefaultCellStyle.ForeColor = textMain;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 40, 35);
            this.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = cyan;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);

            // panelForm
            this.panelForm.BackColor = bgPanel;
            this.panelForm.Controls.Add(this.lblFormTitle);
            this.panelForm.Controls.Add(this.lblUsername);
            this.panelForm.Controls.Add(this.txtUsername);
            this.panelForm.Controls.Add(this.lblPassword);
            this.panelForm.Controls.Add(this.txtPassword);
            this.panelForm.Controls.Add(this.lblRole);
            this.panelForm.Controls.Add(this.cmbRole);
            this.panelForm.Controls.Add(this.btnAdd);
            this.panelForm.Controls.Add(this.btnEdit);
            this.panelForm.Controls.Add(this.btnDelete);
            this.panelForm.Controls.Add(this.btnClear);
            this.panelForm.Location = new System.Drawing.Point(690, 20);
            this.panelForm.Size = new System.Drawing.Size(350, 550);
            this.panelForm.Padding = new System.Windows.Forms.Padding(20);

            // lblFormTitle
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = cyan;
            this.lblFormTitle.Text = "▶  ADD / EDIT USER";
            this.lblFormTitle.Location = new System.Drawing.Point(20, 20);
            this.lblFormTitle.Size = new System.Drawing.Size(310, 30);

            // Username
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = cyan;
            this.lblUsername.Text = "USERNAME";
            this.lblUsername.Location = new System.Drawing.Point(20, 75);
            this.lblUsername.Size = new System.Drawing.Size(310, 18);

            this.txtUsername.BackColor = bgInput;
            this.txtUsername.ForeColor = textMain;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(20, 96);
            this.txtUsername.Size = new System.Drawing.Size(310, 30);
            this.txtUsername.Name = "txtUsername";

            // Password
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = cyan;
            this.lblPassword.Text = "PASSWORD";
            this.lblPassword.Location = new System.Drawing.Point(20, 145);
            this.lblPassword.Size = new System.Drawing.Size(310, 18);

            this.txtPassword.BackColor = bgInput;
            this.txtPassword.ForeColor = textMain;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Location = new System.Drawing.Point(20, 166);
            this.txtPassword.Size = new System.Drawing.Size(310, 30);
            this.txtPassword.Name = "txtPassword";

            // Role
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = cyan;
            this.lblRole.Text = "ROLE";
            this.lblRole.Location = new System.Drawing.Point(20, 215);
            this.lblRole.Size = new System.Drawing.Size(310, 18);

            this.cmbRole.BackColor = bgInput;
            this.cmbRole.ForeColor = textMain;
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRole.Location = new System.Drawing.Point(20, 236);
            this.cmbRole.Size = new System.Drawing.Size(310, 30);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] { "Admin", "User" });

            // Buttons
            SetupButton(btnAdd, "＋  ADD USER", System.Drawing.Color.FromArgb(0, 60, 50), cyan, cyanDim, 20, 310);
            SetupButton(btnEdit, "✎  UPDATE USER", System.Drawing.Color.FromArgb(40, 50, 20), green, green, 20, 365);
            SetupButton(btnDelete, "✕  DELETE USER", System.Drawing.Color.FromArgb(60, 15, 15), red, red, 20, 420);
            SetupButton(btnClear, "↺  CLEAR", System.Drawing.Color.FromArgb(25, 30, 45), muted, muted, 20, 475);

            this.btnAdd.Name = "btnAdd";
            this.btnEdit.Name = "btnEdit";
            this.btnDelete.Name = "btnDelete";
            this.btnClear.Name = "btnClear";

            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Form
            this.BackColor = bgDark;
            this.ClientSize = new System.Drawing.Size(1060, 650);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentialx — User Management";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
        }

        private void SetupButton(System.Windows.Forms.Button btn, string text,
            System.Drawing.Color bg, System.Drawing.Color fg,
            System.Drawing.Color border, int x, int y)
        {
            btn.BackColor = bg;
            btn.ForeColor = fg;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = border;
            btn.FlatAppearance.BorderSize = 1;
            btn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btn.Text = text;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(310, 40);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}