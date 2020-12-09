namespace Final_Lab03_FormPractice
{
    partial class Form2
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
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.Navy;
            this.buttonAddUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ForeColor = System.Drawing.Color.White;
            this.buttonAddUser.Location = new System.Drawing.Point(91, 165);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(198, 51);
            this.buttonAddUser.TabIndex = 6;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.btnClick);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.BackColor = System.Drawing.Color.Navy;
            this.buttonEditUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEditUser.Location = new System.Drawing.Point(410, 165);
            this.buttonEditUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(192, 51);
            this.buttonEditUser.TabIndex = 7;
            this.buttonEditUser.Text = "Edit User";
            this.buttonEditUser.UseVisualStyleBackColor = false;
            this.buttonEditUser.Click += new System.EventHandler(this.btnclickEU);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(686, 401);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonAddUser);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonEditUser;
    }
}