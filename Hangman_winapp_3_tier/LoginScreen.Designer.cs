namespace Hangman
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtBUserID = new System.Windows.Forms.TextBox();
            this.txtBPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBCreateNewAccount = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnLogin.FlatAppearance.BorderSize = 4;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Gold;
            this.btnLogin.Location = new System.Drawing.Point(149, 134);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 34);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Enabled = false;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnSignUp.FlatAppearance.BorderSize = 4;
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.Gold;
            this.btnSignUp.Location = new System.Drawing.Point(193, 197);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(107, 34);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtBUserID
            // 
            this.txtBUserID.BackColor = System.Drawing.Color.ForestGreen;
            this.txtBUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBUserID.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBUserID.ForeColor = System.Drawing.Color.DarkOrchid;
            this.txtBUserID.Location = new System.Drawing.Point(128, 55);
            this.txtBUserID.Name = "txtBUserID";
            this.txtBUserID.Size = new System.Drawing.Size(142, 18);
            this.txtBUserID.TabIndex = 2;
            // 
            // txtBPassword
            // 
            this.txtBPassword.BackColor = System.Drawing.Color.ForestGreen;
            this.txtBPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBPassword.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBPassword.ForeColor = System.Drawing.Color.DarkOrchid;
            this.txtBPassword.Location = new System.Drawing.Point(128, 101);
            this.txtBPassword.Name = "txtBPassword";
            this.txtBPassword.Size = new System.Drawing.Size(142, 18);
            this.txtBPassword.TabIndex = 3;
            this.txtBPassword.TextChanged += new System.EventHandler(this.txtBPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(32, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(32, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // chkBCreateNewAccount
            // 
            this.chkBCreateNewAccount.AutoSize = true;
            this.chkBCreateNewAccount.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.chkBCreateNewAccount.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.chkBCreateNewAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.chkBCreateNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBCreateNewAccount.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBCreateNewAccount.ForeColor = System.Drawing.Color.Gold;
            this.chkBCreateNewAccount.Location = new System.Drawing.Point(12, 205);
            this.chkBCreateNewAccount.Name = "chkBCreateNewAccount";
            this.chkBCreateNewAccount.Size = new System.Drawing.Size(172, 21);
            this.chkBCreateNewAccount.TabIndex = 6;
            this.chkBCreateNewAccount.Text = "Create New Account";
            this.chkBCreateNewAccount.UseVisualStyleBackColor = true;
            this.chkBCreateNewAccount.CheckedChanged += new System.EventHandler(this.chkBCreateNewAccount_CheckedChanged);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(305, 267);
            this.Controls.Add(this.chkBCreateNewAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBPassword);
            this.Controls.Add(this.txtBUserID);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtBUserID;
        private System.Windows.Forms.TextBox txtBPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBCreateNewAccount;
    }
}