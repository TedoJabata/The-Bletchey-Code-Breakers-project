namespace TheBletcheyCodeBreakers.Views
{
    partial class HomeView
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnWelcomeLogin = new System.Windows.Forms.Button();
            this.btnWelcomeRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Modern No. 20", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(397, 164);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(384, 96);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWelcomeLogin
            // 
            this.btnWelcomeLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnWelcomeLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWelcomeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWelcomeLogin.Location = new System.Drawing.Point(411, 341);
            this.btnWelcomeLogin.Name = "btnWelcomeLogin";
            this.btnWelcomeLogin.Size = new System.Drawing.Size(159, 86);
            this.btnWelcomeLogin.TabIndex = 1;
            this.btnWelcomeLogin.Text = "Log In";
            this.btnWelcomeLogin.UseVisualStyleBackColor = false;
            this.btnWelcomeLogin.Click += new System.EventHandler(this.btnWelcomeLogin_Click);
            // 
            // btnWelcomeRegister
            // 
            this.btnWelcomeRegister.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnWelcomeRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWelcomeRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWelcomeRegister.Location = new System.Drawing.Point(622, 341);
            this.btnWelcomeRegister.Name = "btnWelcomeRegister";
            this.btnWelcomeRegister.Size = new System.Drawing.Size(159, 86);
            this.btnWelcomeRegister.TabIndex = 2;
            this.btnWelcomeRegister.Text = "Register";
            this.btnWelcomeRegister.UseVisualStyleBackColor = false;
            this.btnWelcomeRegister.Click += new System.EventHandler(this.btnWelcomeRegister_Click);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::TheBletcheyCodeBreakers.Properties.Resources.homeBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 641);
            this.Controls.Add(this.btnWelcomeRegister);
            this.Controls.Add(this.btnWelcomeLogin);
            this.Controls.Add(this.lblWelcome);
            this.Name = "HomeView";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnWelcomeLogin;
        private System.Windows.Forms.Button btnWelcomeRegister;
    }
}