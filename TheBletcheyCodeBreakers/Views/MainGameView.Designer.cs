
namespace TheBletcheyCodeBreakers.Views
{
    partial class MainGameView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.num4 = new System.Windows.Forms.TextBox();
            this.btnTry = new System.Windows.Forms.Button();
            this.lblBulls = new System.Windows.Forms.Label();
            this.lblCows = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.historyTable = new System.Windows.Forms.DataGridView();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheBletcheyCodeBreakers.Properties.Resources.gameBackground;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(50, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1041, 559);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(879, 491);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(179, 81);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(344, 156);
            this.num1.MaxLength = 1;
            this.num1.Multiline = true;
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(85, 78);
            this.num1.TabIndex = 2;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(465, 156);
            this.num2.MaxLength = 1;
            this.num2.Multiline = true;
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(85, 78);
            this.num2.TabIndex = 3;
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(590, 156);
            this.num3.MaxLength = 1;
            this.num3.Multiline = true;
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(85, 78);
            this.num3.TabIndex = 4;
            this.num3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(703, 156);
            this.num4.MaxLength = 1;
            this.num4.Multiline = true;
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(85, 78);
            this.num4.TabIndex = 5;
            this.num4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTry
            // 
            this.btnTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTry.Location = new System.Drawing.Point(852, 156);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(186, 88);
            this.btnTry.TabIndex = 7;
            this.btnTry.Text = "Try Numbers";
            this.btnTry.UseVisualStyleBackColor = true;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // lblBulls
            // 
            this.lblBulls.BackColor = System.Drawing.SystemColors.Control;
            this.lblBulls.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulls.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBulls.Image = global::TheBletcheyCodeBreakers.Properties.Resources.gameBackground;
            this.lblBulls.Location = new System.Drawing.Point(79, 168);
            this.lblBulls.Name = "lblBulls";
            this.lblBulls.Size = new System.Drawing.Size(224, 66);
            this.lblBulls.TabIndex = 8;
            this.lblBulls.Text = "Bulls:";
            // 
            // lblCows
            // 
            this.lblCows.BackColor = System.Drawing.SystemColors.Control;
            this.lblCows.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCows.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCows.Image = global::TheBletcheyCodeBreakers.Properties.Resources.gameBackground;
            this.lblCows.Location = new System.Drawing.Point(79, 255);
            this.lblCows.Name = "lblCows";
            this.lblCows.Size = new System.Drawing.Size(224, 66);
            this.lblCows.TabIndex = 9;
            this.lblCows.Text = "Cows:";
            // 
            // lblWin
            // 
            this.lblWin.BackColor = System.Drawing.SystemColors.Control;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWin.Image = global::TheBletcheyCodeBreakers.Properties.Resources.gameBackground;
            this.lblWin.Location = new System.Drawing.Point(79, 428);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(246, 70);
            this.lblWin.TabIndex = 10;
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // historyTable
            // 
            this.historyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyTable.Location = new System.Drawing.Point(344, 284);
            this.historyTable.Name = "historyTable";
            this.historyTable.Size = new System.Drawing.Size(444, 262);
            this.historyTable.TabIndex = 11;
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.BackColor = System.Drawing.SystemColors.Control;
            this.lblLoggedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLoggedUser.Image = global::TheBletcheyCodeBreakers.Properties.Resources.gameBackground;
            this.lblLoggedUser.Location = new System.Drawing.Point(79, 74);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(171, 36);
            this.lblLoggedUser.TabIndex = 12;
            this.lblLoggedUser.Text = "Hello";
            // 
            // lblWins
            // 
            this.lblWins.BackColor = System.Drawing.SystemColors.Control;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWins.Image = global::TheBletcheyCodeBreakers.Properties.Resources.gameBackground;
            this.lblWins.Location = new System.Drawing.Point(795, 74);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(243, 36);
            this.lblWins.TabIndex = 13;
            this.lblWins.Text = "You have 0 wins  ";
            // 
            // MainGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheBletcheyCodeBreakers.Properties.Resources.homeBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 644);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.historyTable);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblCows);
            this.Controls.Add(this.lblBulls);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainGameView";
            this.Text = "MainGameView";
            this.Load += new System.EventHandler(this.MainGameView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox num4;
        private System.Windows.Forms.DataGridViewTextBoxColumn num1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num4DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.Label lblBulls;
        private System.Windows.Forms.Label lblCows;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.DataGridView historyTable;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Label lblWins;
    }
}