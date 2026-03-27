namespace FurnitureRental
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            lblError = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(92, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(176, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Employee Login";

            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(38, 84);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(63, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";

            txtUsername.Location = new System.Drawing.Point(122, 81);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(180, 23);
            txtUsername.TabIndex = 2;

            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(38, 123);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(60, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";

            txtPassword.Location = new System.Drawing.Point(122, 120);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(180, 23);
            txtPassword.TabIndex = 4;

            btnLogin.Location = new System.Drawing.Point(122, 162);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(100, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;

            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Location = new System.Drawing.Point(38, 212);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(0, 15);
            lblError.TabIndex = 6;

            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(356, 253);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}