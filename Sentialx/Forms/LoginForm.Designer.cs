namespace Sentialx.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();

            // ── Colors ───────────────────────────────────────
            var bgDark = System.Drawing.Color.FromArgb(10, 14, 26);
            var bgPanel = System.Drawing.Color.FromArgb(16, 22, 36);
            var bgInput = System.Drawing.Color.FromArgb(20, 28, 45);
            var cyan = System.Drawing.Color.FromArgb(0, 255, 200);
            var cyanDim = System.Drawing.Color.FromArgb(0, 180, 140);
            var textMute = System.Drawing.Color.FromArgb(100, 120, 150);
            var textMain = System.Drawing.Color.FromArgb(200, 215, 230);
            var red = System.Drawing.Color.FromArgb(255, 70, 70);

            // panelLeft
            this.panelLeft.BackColor = bgDark;
            this.panelLeft.Controls.Add(this.lblAppName);
            this.panelLeft.Controls.Add(this.lblTagline);
            this.panelLeft.Controls.Add(this.lblVersion);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Size = new System.Drawing.Size(340, 520);

            // lblAppName
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = cyan;
            this.lblAppName.Text = "SENTIALX";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAppName.Size = new System.Drawing.Size(300, 60);
            this.lblAppName.Location = new System.Drawing.Point(20, 170);

            // lblTagline
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTagline.ForeColor = textMute;
            this.lblTagline.Text = "Threat Monitoring & Logging System";
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTagline.Size = new System.Drawing.Size(300, 30);
            this.lblTagline.Location = new System.Drawing.Point(20, 235);

            // lblVersion
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(50, 70, 90);
            this.lblVersion.Text = "v1.0.0  |  SECURE ACCESS ONLY";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVersion.Size = new System.Drawing.Size(300, 25);
            this.lblVersion.Location = new System.Drawing.Point(20, 460);

            // panelRight
            this.panelRight.BackColor = bgPanel;
            this.panelRight.Controls.Add(this.lblTitle);
            this.panelRight.Controls.Add(this.lblSubtitle);
            this.panelRight.Controls.Add(this.lblUsername);
            this.panelRight.Controls.Add(this.txtUsername);
            this.panelRight.Controls.Add(this.lblPassword);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.btnLogin);
            this.panelRight.Controls.Add(this.lblError);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = textMain;
            this.lblTitle.Text = "Welcome Back";
            this.lblTitle.Location = new System.Drawing.Point(50, 75);
            this.lblTitle.Size = new System.Drawing.Size(320, 45);

            // lblSubtitle
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = textMute;
            this.lblSubtitle.Text = "Sign in to access the system";
            this.lblSubtitle.Location = new System.Drawing.Point(50, 120);
            this.lblSubtitle.Size = new System.Drawing.Size(320, 25);

            // lblUsername
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = cyan;
            this.lblUsername.Text = "USERNAME";
            this.lblUsername.Location = new System.Drawing.Point(50, 178);
            this.lblUsername.Size = new System.Drawing.Size(320, 18);

            // txtUsername
            this.txtUsername.BackColor = bgInput;
            this.txtUsername.ForeColor = textMain;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(50, 200);
            this.txtUsername.Size = new System.Drawing.Size(320, 32);
            this.txtUsername.Name = "txtUsername";

            // lblPassword
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = cyan;
            this.lblPassword.Text = "PASSWORD";
            this.lblPassword.Location = new System.Drawing.Point(50, 255);
            this.lblPassword.Size = new System.Drawing.Size(320, 18);

            // txtPassword
            this.txtPassword.BackColor = bgInput;
            this.txtPassword.ForeColor = textMain;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Location = new System.Drawing.Point(50, 277);
            this.txtPassword.Size = new System.Drawing.Size(320, 32);
            this.txtPassword.Name = "txtPassword";

            // btnLogin
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 60, 50);
            this.btnLogin.ForeColor = cyan;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderColor = cyanDim;
            this.btnLogin.FlatAppearance.BorderSize = 1;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Text = "ACCESS SYSTEM";
            this.btnLogin.Location = new System.Drawing.Point(50, 340);
            this.btnLogin.Size = new System.Drawing.Size(320, 45);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // lblError
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblError.ForeColor = red;
            this.lblError.Text = "";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Location = new System.Drawing.Point(50, 395);
            this.lblError.Size = new System.Drawing.Size(320, 25);
            this.lblError.Name = "lblError";

            // LoginForm
            this.BackColor = bgPanel;
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentialx — Secure Login";
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
    }
}