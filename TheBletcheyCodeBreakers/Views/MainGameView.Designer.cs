
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.num4 = new System.Windows.Forms.TextBox();
            this.historyTable = new System.Windows.Forms.DataGridView();
            this.btnTry = new System.Windows.Forms.Button();
            this.num1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
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
            // historyTable
            // 
            this.historyTable.AllowUserToAddRows = false;
            this.historyTable.AllowUserToDeleteRows = false;
            this.historyTable.AutoGenerateColumns = false;
            this.historyTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.historyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num1DataGridViewTextBoxColumn,
            this.num2DataGridViewTextBoxColumn,
            this.num3DataGridViewTextBoxColumn,
            this.num4DataGridViewTextBoxColumn});
            this.historyTable.DataSource = this.historyBindingSource;
            this.historyTable.Location = new System.Drawing.Point(344, 330);
            this.historyTable.Name = "historyTable";
            this.historyTable.ReadOnly = true;
            this.historyTable.Size = new System.Drawing.Size(444, 186);
            this.historyTable.TabIndex = 6;
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
            // num1DataGridViewTextBoxColumn
            // 
            this.num1DataGridViewTextBoxColumn.DataPropertyName = "Num_1";
            this.num1DataGridViewTextBoxColumn.HeaderText = "Num_1";
            this.num1DataGridViewTextBoxColumn.Name = "num1DataGridViewTextBoxColumn";
            this.num1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // num2DataGridViewTextBoxColumn
            // 
            this.num2DataGridViewTextBoxColumn.DataPropertyName = "Num_2";
            this.num2DataGridViewTextBoxColumn.HeaderText = "Num_2";
            this.num2DataGridViewTextBoxColumn.Name = "num2DataGridViewTextBoxColumn";
            this.num2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // num3DataGridViewTextBoxColumn
            // 
            this.num3DataGridViewTextBoxColumn.DataPropertyName = "Num_3";
            this.num3DataGridViewTextBoxColumn.HeaderText = "Num_3";
            this.num3DataGridViewTextBoxColumn.Name = "num3DataGridViewTextBoxColumn";
            this.num3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // num4DataGridViewTextBoxColumn
            // 
            this.num4DataGridViewTextBoxColumn.DataPropertyName = "Num_4";
            this.num4DataGridViewTextBoxColumn.HeaderText = "Num_4";
            this.num4DataGridViewTextBoxColumn.Name = "num4DataGridViewTextBoxColumn";
            this.num4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataSource = typeof(TheBletcheyCodeBreakers.Model.History);
            // 
            // MainGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheBletcheyCodeBreakers.Properties.Resources.homeBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 644);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.historyTable);
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
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView historyTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn num1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num4DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private System.Windows.Forms.Button btnTry;
    }
}