
namespace TheBletcheyCodeBreakers.Views
{
    partial class RegisterView
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRegisterToHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("Modern No. 20", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegister.Location = new System.Drawing.Point(383, 144);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(384, 96);
            this.lblRegister.TabIndex = 3;
            this.lblRegister.Text = "Register";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.BackColor = System.Drawing.SystemColors.Menu;
            this.txtRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterUsername.Location = new System.Drawing.Point(447, 299);
            this.txtRegisterUsername.Multiline = true;
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(252, 35);
            this.txtRegisterUsername.TabIndex = 4;
            this.txtRegisterUsername.Text = "Username";
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterEmail.Location = new System.Drawing.Point(447, 351);
            this.txtRegisterEmail.Multiline = true;
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(252, 35);
            this.txtRegisterEmail.TabIndex = 5;
            this.txtRegisterEmail.Text = "E-mail";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.txtRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPassword.Location = new System.Drawing.Point(447, 404);
            this.txtRegisterPassword.Multiline = true;
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(252, 35);
            this.txtRegisterPassword.TabIndex = 6;
            this.txtRegisterPassword.Text = "Password";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegister.Location = new System.Drawing.Point(611, 459);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(88, 43);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnRegisterToHome
            // 
            this.btnRegisterToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterToHome.Location = new System.Drawing.Point(12, 568);
            this.btnRegisterToHome.Name = "btnRegisterToHome";
            this.btnRegisterToHome.Size = new System.Drawing.Size(143, 61);
            this.btnRegisterToHome.TabIndex = 8;
            this.btnRegisterToHome.Text = "Back";
            this.btnRegisterToHome.UseVisualStyleBackColor = true;
            this.btnRegisterToHome.Click += new System.EventHandler(this.btnRegisterToHome_Click);
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::TheBletcheyCodeBreakers.Properties.Resources.homeBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 641);
            this.Controls.Add(this.btnRegisterToHome);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.txtRegisterEmail);
            this.Controls.Add(this.txtRegisterUsername);
            this.Controls.Add(this.lblRegister);
            this.Name = "RegisterView";
            this.Text = "RegisterView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRegisterToHome;
    }
}