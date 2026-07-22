namespace Hangman
{
    partial class GameLevelScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameLevelScreen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBHard = new System.Windows.Forms.RadioButton();
            this.rdBMedium = new System.Windows.Forms.RadioButton();
            this.rdBEasy = new System.Windows.Forms.RadioButton();
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Controls.Add(this.rdBHard);
            this.groupBox1.Controls.Add(this.rdBMedium);
            this.groupBox1.Controls.Add(this.rdBEasy);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(27, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Level Selection";
            // 
            // rdBHard
            // 
            this.rdBHard.AutoSize = true;
            this.rdBHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBHard.Location = new System.Drawing.Point(27, 128);
            this.rdBHard.Name = "rdBHard";
            this.rdBHard.Size = new System.Drawing.Size(64, 21);
            this.rdBHard.TabIndex = 2;
            this.rdBHard.TabStop = true;
            this.rdBHard.Text = "Hard";
            this.rdBHard.UseVisualStyleBackColor = true;
            // 
            // rdBMedium
            // 
            this.rdBMedium.AutoSize = true;
            this.rdBMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBMedium.Location = new System.Drawing.Point(27, 87);
            this.rdBMedium.Name = "rdBMedium";
            this.rdBMedium.Size = new System.Drawing.Size(88, 21);
            this.rdBMedium.TabIndex = 1;
            this.rdBMedium.TabStop = true;
            this.rdBMedium.Text = "Medium";
            this.rdBMedium.UseVisualStyleBackColor = true;
            // 
            // rdBEasy
            // 
            this.rdBEasy.AutoSize = true;
            this.rdBEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBEasy.Location = new System.Drawing.Point(27, 49);
            this.rdBEasy.Name = "rdBEasy";
            this.rdBEasy.Size = new System.Drawing.Size(64, 21);
            this.rdBEasy.TabIndex = 0;
            this.rdBEasy.TabStop = true;
            this.rdBEasy.Text = "Easy";
            this.rdBEasy.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnclose.FlatAppearance.BorderSize = 4;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Gold;
            this.btnclose.Location = new System.Drawing.Point(140, 253);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(89, 35);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GameLevelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman.Properties.Resources.hangmanbackground;
            this.ClientSize = new System.Drawing.Size(347, 300);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "GameLevelScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Level";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.RadioButton rdBHard;
        private System.Windows.Forms.RadioButton rdBMedium;
        private System.Windows.Forms.RadioButton rdBEasy;
    }
}