namespace ies_admin_academ
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.main_login_titleIES = new System.Windows.Forms.Label();
            this.main_login_appenvText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_pwd = new System.Windows.Forms.TextBox();
            this.login_execution_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(0, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "dalarcont Software Development Services\r\nVersión 2023.1.1.B";
            // 
            // main_login_titleIES
            // 
            this.main_login_titleIES.AutoSize = true;
            this.main_login_titleIES.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_login_titleIES.Location = new System.Drawing.Point(15, 14);
            this.main_login_titleIES.Name = "main_login_titleIES";
            this.main_login_titleIES.Size = new System.Drawing.Size(68, 30);
            this.main_login_titleIES.TabIndex = 1;
            this.main_login_titleIES.Text = "label2";
            // 
            // main_login_appenvText
            // 
            this.main_login_appenvText.AutoSize = true;
            this.main_login_appenvText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_login_appenvText.Location = new System.Drawing.Point(15, 44);
            this.main_login_appenvText.Name = "main_login_appenvText";
            this.main_login_appenvText.Size = new System.Drawing.Size(68, 30);
            this.main_login_appenvText.TabIndex = 2;
            this.main_login_appenvText.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de usuario: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña: ";
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(134, 101);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(338, 23);
            this.login_username.TabIndex = 5;
            this.login_username.TextChanged += new System.EventHandler(this.login_username_TextChanged);
            // 
            // login_pwd
            // 
            this.login_pwd.Location = new System.Drawing.Point(134, 138);
            this.login_pwd.Name = "login_pwd";
            this.login_pwd.Size = new System.Drawing.Size(338, 23);
            this.login_pwd.TabIndex = 6;
            this.login_pwd.UseSystemPasswordChar = true;
            this.login_pwd.TextChanged += new System.EventHandler(this.login_pwd_TextChanged);
            // 
            // login_execution_btn
            // 
            this.login_execution_btn.Enabled = false;
            this.login_execution_btn.Location = new System.Drawing.Point(200, 192);
            this.login_execution_btn.Name = "login_execution_btn";
            this.login_execution_btn.Size = new System.Drawing.Size(75, 23);
            this.login_execution_btn.TabIndex = 7;
            this.login_execution_btn.Text = "Conectarse";
            this.login_execution_btn.UseVisualStyleBackColor = true;
            this.login_execution_btn.Click += new System.EventHandler(this.login_execution_btn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 271);
            this.Controls.Add(this.login_execution_btn);
            this.Controls.Add(this.login_pwd);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.main_login_appenvText);
            this.Controls.Add(this.main_login_titleIES);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 310);
            this.MinimumSize = new System.Drawing.Size(500, 310);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        public Label main_login_titleIES;
        public Label main_login_appenvText;
        private Label label2;
        private Label label3;
        public TextBox login_username;
        public TextBox login_pwd;
        public Button login_execution_btn;
    }
}