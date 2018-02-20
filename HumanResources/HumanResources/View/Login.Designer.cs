using System.Windows.Forms;

namespace HumanResources
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBlue = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.txtOops = new System.Windows.Forms.TextBox();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(172, 198);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 29);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.LoginButton);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Enabled = false;
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.lblUsername.Location = new System.Drawing.Point(31, 123);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(34, 123);
            this.txtUsername.MaxLength = 15;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(195, 13);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.Enter += new System.EventHandler(TxtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(TxtUsername_Leave);
            // 
            // lblLine1
            // 
            this.lblLine1.AutoSize = true;
            this.lblLine1.ForeColor = System.Drawing.Color.Gray;
            this.lblLine1.Location = new System.Drawing.Point(30, 125);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(217, 13);
            this.lblLine1.TabIndex = 7;
            this.lblLine1.Text = "___________________________________";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Enabled = false;
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.lblPassword.Location = new System.Drawing.Point(32, 162);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(35, 162);
            this.txtPassword.MaxLength = 32420;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(217, 13);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Enter += new System.EventHandler(TxtPassword_Enter_1);
            this.txtPassword.Leave += new System.EventHandler(TxtPassword_Leave);
            this.txtPassword.KeyDown += new KeyEventHandler(PasswordEnter);
            // 
            // lblLine2
            // 
            this.lblLine2.AutoSize = true;
            this.lblLine2.ForeColor = System.Drawing.Color.Gray;
            this.lblLine2.Location = new System.Drawing.Point(31, 164);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(217, 13);
            this.lblLine2.TabIndex = 10;
            this.lblLine2.Text = "___________________________________";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Welcome Back!";
            // 
            // pnlBlue
            // 
            this.pnlBlue.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlBlue.Enabled = false;
            this.pnlBlue.Location = new System.Drawing.Point(-1, 0);
            this.pnlBlue.Name = "pnlBlue";
            this.pnlBlue.Size = new System.Drawing.Size(285, 73);
            this.pnlBlue.TabIndex = 13;
            this.pnlBlue.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(168)))), ((int)(((byte)(180)))));
            this.lblExit.Location = new System.Drawing.Point(32, 206);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(24, 13);
            this.lblExit.TabIndex = 15;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(LblExit_Click);
            // 
            // txtOops
            // 
            this.txtOops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOops.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtOops.Location = new System.Drawing.Point(34, 93);
            this.txtOops.Name = "txtOops";
            this.txtOops.Size = new System.Drawing.Size(150, 13);
            this.txtOops.TabIndex = 16;
            this.txtOops.Text = "Oops, something went wrong";
            this.txtOops.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(268, 257);
            this.Controls.Add(this.txtOops);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlBlue);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblLine2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(284, 257);
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.DoubleClick += new System.EventHandler(this.Login_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBlue)).EndInit();
    
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblLine1;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblLine2;
        private Label lblTitle;
        private PictureBox pnlBlue;
        private Label lblExit;
        private TextBox txtOops;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}

