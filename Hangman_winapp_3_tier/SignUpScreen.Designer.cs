namespace Hangman
{
    partial class SignUpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpScreen));
            this.txtBUserName = new System.Windows.Forms.TextBox();
            this.txtBPassword = new System.Windows.Forms.TextBox();
            this.txtBAge = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBackToLoginScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBUserName
            // 
            this.txtBUserName.BackColor = System.Drawing.Color.ForestGreen;
            this.txtBUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBUserName.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBUserName.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtBUserName.Location = new System.Drawing.Point(106, 53);
            this.txtBUserName.Name = "txtBUserName";
            this.txtBUserName.Size = new System.Drawing.Size(134, 15);
            this.txtBUserName.TabIndex = 0;
            // 
            // txtBPassword
            // 
            this.txtBPassword.BackColor = System.Drawing.Color.ForestGreen;
            this.txtBPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBPassword.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBPassword.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtBPassword.Location = new System.Drawing.Point(106, 93);
            this.txtBPassword.Multiline = true;
            this.txtBPassword.Name = "txtBPassword";
            this.txtBPassword.Size = new System.Drawing.Size(134, 15);
            this.txtBPassword.TabIndex = 1;
            // 
            // txtBAge
            // 
            this.txtBAge.BackColor = System.Drawing.Color.ForestGreen;
            this.txtBAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBAge.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBAge.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtBAge.Location = new System.Drawing.Point(106, 138);
            this.txtBAge.Multiline = true;
            this.txtBAge.Name = "txtBAge";
            this.txtBAge.Size = new System.Drawing.Size(134, 15);
            this.txtBAge.TabIndex = 2;
            this.txtBAge.TextChanged += new System.EventHandler(this.txtBAge_TextChanged);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Enabled = false;
            this.btnCreateAccount.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnCreateAccount.FlatAppearance.BorderSize = 4;
            this.btnCreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.Gold;
            this.btnCreateAccount.Location = new System.Drawing.Point(106, 172);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(118, 29);
            this.btnCreateAccount.TabIndex = 3;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(30, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age";
            // 
            // btnBackToLoginScreen
            // 
            this.btnBackToLoginScreen.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnBackToLoginScreen.FlatAppearance.BorderSize = 4;
            this.btnBackToLoginScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBackToLoginScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLoginScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLoginScreen.ForeColor = System.Drawing.Color.Gold;
            this.btnBackToLoginScreen.Location = new System.Drawing.Point(48, 232);
            this.btnBackToLoginScreen.Name = "btnBackToLoginScreen";
            this.btnBackToLoginScreen.Size = new System.Drawing.Size(158, 29);
            this.btnBackToLoginScreen.TabIndex = 7;
            this.btnBackToLoginScreen.Text = "Back To Login Screen";
            this.btnBackToLoginScreen.UseVisualStyleBackColor = true;
            this.btnBackToLoginScreen.Click += new System.EventHandler(this.btnBackToLoginScreen_Click);
            // 
            // SignUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(265, 273);
            this.Controls.Add(this.btnBackToLoginScreen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtBAge);
            this.Controls.Add(this.txtBPassword);
            this.Controls.Add(this.txtBUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBUserName;
        private System.Windows.Forms.TextBox txtBPassword;
        private System.Windows.Forms.TextBox txtBAge;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBackToLoginScreen;
    }
}