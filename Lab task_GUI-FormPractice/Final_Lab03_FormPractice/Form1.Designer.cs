namespace Final_Lab03_FormPractice
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.loginForm = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Username.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(183, 200);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(176, 39);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username : ";
            this.Username.Click += new System.EventHandler(this.Login_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Password.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(183, 290);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(174, 39);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password  : ";
            this.Password.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(399, 200);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(334, 47);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(399, 287);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(334, 47);
            this.textBoxPassword.TabIndex = 3;
            // 
            // loginForm
            // 
            this.loginForm.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.loginForm.AutoSize = true;
            this.loginForm.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginForm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.loginForm.Location = new System.Drawing.Point(321, 103);
            this.loginForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginForm.Name = "loginForm";
            this.loginForm.Size = new System.Drawing.Size(235, 64);
            this.loginForm.TabIndex = 4;
            this.loginForm.Text = "Login Form";
            this.loginForm.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(316, 386);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(202, 51);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.btnClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(882, 544);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.loginForm);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label loginForm;
        private System.Windows.Forms.Button buttonLogin;
    }
}

