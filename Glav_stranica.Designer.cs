namespace DB_Stroy_Materyali
{
    partial class Glav_stranica
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_close = new System.Windows.Forms.Button();
            this.PB_STR = new System.Windows.Forms.PictureBox();
            this.Nazvanie = new System.Windows.Forms.Label();
            this.Privetstvie = new System.Windows.Forms.Label();
            this.TipVhoda = new System.Windows.Forms.Label();
            this.Btn_Polzovatel = new System.Windows.Forms.Button();
            this.Btn_Admin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_STR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.Btn_close);
            this.panel1.Controls.Add(this.PB_STR);
            this.panel1.Controls.Add(this.Nazvanie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 303);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Btn_close
            // 
            this.Btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_close.FlatAppearance.BorderSize = 0;
            this.Btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_close.ForeColor = System.Drawing.Color.White;
            this.Btn_close.Location = new System.Drawing.Point(1282, 21);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(75, 61);
            this.Btn_close.TabIndex = 2;
            this.Btn_close.Text = "Х";
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // PB_STR
            // 
            this.PB_STR.Image = global::DB_Stroy_Materyali.Properties.Resources.logo;
            this.PB_STR.Location = new System.Drawing.Point(115, 56);
            this.PB_STR.Name = "PB_STR";
            this.PB_STR.Size = new System.Drawing.Size(202, 193);
            this.PB_STR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_STR.TabIndex = 1;
            this.PB_STR.TabStop = false;
            // 
            // Nazvanie
            // 
            this.Nazvanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazvanie.ForeColor = System.Drawing.Color.Transparent;
            this.Nazvanie.Location = new System.Drawing.Point(385, 56);
            this.Nazvanie.Name = "Nazvanie";
            this.Nazvanie.Size = new System.Drawing.Size(924, 193);
            this.Nazvanie.TabIndex = 0;
            this.Nazvanie.Text = "ООО «Стройматериалы»";
            this.Nazvanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          
            // 
            // Privetstvie
            // 
            this.Privetstvie.AutoSize = true;
            this.Privetstvie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Privetstvie.Location = new System.Drawing.Point(135, 353);
            this.Privetstvie.Name = "Privetstvie";
            this.Privetstvie.Size = new System.Drawing.Size(987, 54);
            this.Privetstvie.TabIndex = 1;
            this.Privetstvie.Text = "Добро пожаловать в БД стройматериалы!";
            // 
            // TipVhoda
            // 
            this.TipVhoda.AutoSize = true;
            this.TipVhoda.Location = new System.Drawing.Point(476, 464);
            this.TipVhoda.Name = "TipVhoda";
            this.TipVhoda.Size = new System.Drawing.Size(462, 32);
            this.TipVhoda.TabIndex = 2;
            this.TipVhoda.Text = "Пожалуйста, выберите тип входа:";
            // 
            // Btn_Polzovatel
            // 
            this.Btn_Polzovatel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Btn_Polzovatel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Btn_Polzovatel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Polzovatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Polzovatel.ForeColor = System.Drawing.Color.White;
            this.Btn_Polzovatel.Location = new System.Drawing.Point(197, 562);
            this.Btn_Polzovatel.Name = "Btn_Polzovatel";
            this.Btn_Polzovatel.Size = new System.Drawing.Size(418, 99);
            this.Btn_Polzovatel.TabIndex = 3;
            this.Btn_Polzovatel.Text = "Посетитель";
            this.Btn_Polzovatel.UseVisualStyleBackColor = false;
            this.Btn_Polzovatel.Click += new System.EventHandler(this.Btn_Polzovatel_Click);
            // 
            // Btn_Admin
            // 
            this.Btn_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Btn_Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Admin.ForeColor = System.Drawing.Color.White;
            this.Btn_Admin.Location = new System.Drawing.Point(791, 562);
            this.Btn_Admin.Name = "Btn_Admin";
            this.Btn_Admin.Size = new System.Drawing.Size(413, 99);
            this.Btn_Admin.TabIndex = 4;
            this.Btn_Admin.Text = "Админ";
            this.Btn_Admin.UseVisualStyleBackColor = false;
            this.Btn_Admin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Glav_stranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1396, 732);
            this.Controls.Add(this.Btn_Admin);
            this.Controls.Add(this.Btn_Polzovatel);
            this.Controls.Add(this.TipVhoda);
            this.Controls.Add(this.Privetstvie);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Glav_stranica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glav_stranica";
            this.Load += new System.EventHandler(this.Glav_stranica_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Glav_stranica_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Glav_stranica_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_STR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Nazvanie;
        private System.Windows.Forms.PictureBox PB_STR;
        private System.Windows.Forms.Label Privetstvie;
        private System.Windows.Forms.Label TipVhoda;
        private System.Windows.Forms.Button Btn_Polzovatel;
        private System.Windows.Forms.Button Btn_Admin;
        private System.Windows.Forms.Button Btn_close;
    }
}