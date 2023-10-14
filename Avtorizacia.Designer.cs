namespace DB_Stroy_Materyali
{
    partial class Avtorizacia
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
            this.Lavtoriz = new System.Windows.Forms.Label();
            this.Llogin = new System.Windows.Forms.Label();
            this.Lpassword = new System.Windows.Forms.Label();
            this.TB_login = new System.Windows.Forms.TextBox();
            this.TB_pass = new System.Windows.Forms.TextBox();
            this.Btn_Vhod = new System.Windows.Forms.Button();
            this.Btn_Nazad = new System.Windows.Forms.Button();
            this.LPodskazka = new System.Windows.Forms.Label();
            this.PB_yes2 = new System.Windows.Forms.PictureBox();
            this.PB_yes = new System.Windows.Forms.PictureBox();
            this.PB_Log = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_STR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_yes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_yes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Log)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.Btn_close);
            this.panel1.Controls.Add(this.PB_STR);
            this.panel1.Controls.Add(this.Lavtoriz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 161);
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
            this.Btn_close.Location = new System.Drawing.Point(691, 12);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(75, 71);
            this.Btn_close.TabIndex = 2;
            this.Btn_close.Text = "Х";
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // PB_STR
            // 
            this.PB_STR.Image = global::DB_Stroy_Materyali.Properties.Resources.logo;
            this.PB_STR.Location = new System.Drawing.Point(48, 30);
            this.PB_STR.Name = "PB_STR";
            this.PB_STR.Size = new System.Drawing.Size(124, 105);
            this.PB_STR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_STR.TabIndex = 1;
            this.PB_STR.TabStop = false;
            // 
            // Lavtoriz
            // 
            this.Lavtoriz.AutoSize = true;
            this.Lavtoriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lavtoriz.ForeColor = System.Drawing.Color.White;
            this.Lavtoriz.Location = new System.Drawing.Point(178, 45);
            this.Lavtoriz.Name = "Lavtoriz";
            this.Lavtoriz.Size = new System.Drawing.Size(468, 76);
            this.Lavtoriz.TabIndex = 0;
            this.Lavtoriz.Text = "Авторизация:";
            this.Lavtoriz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Llogin
            // 
            this.Llogin.AutoSize = true;
            this.Llogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Llogin.Location = new System.Drawing.Point(84, 207);
            this.Llogin.Name = "Llogin";
            this.Llogin.Size = new System.Drawing.Size(118, 46);
            this.Llogin.TabIndex = 1;
            this.Llogin.Text = "Login";
            // 
            // Lpassword
            // 
            this.Lpassword.AutoSize = true;
            this.Lpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lpassword.Location = new System.Drawing.Point(70, 301);
            this.Lpassword.Name = "Lpassword";
            this.Lpassword.Size = new System.Drawing.Size(196, 46);
            this.Lpassword.TabIndex = 2;
            this.Lpassword.Text = "Password";
            // 
            // TB_login
            // 
            this.TB_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_login.Location = new System.Drawing.Point(282, 192);
            this.TB_login.Name = "TB_login";
            this.TB_login.Size = new System.Drawing.Size(272, 61);
            this.TB_login.TabIndex = 3;
         
            this.TB_login.Enter += new System.EventHandler(this.TB_login_Enter);
            this.TB_login.Leave += new System.EventHandler(this.TB_login_Leave);
            // 
            // TB_pass
            // 
            this.TB_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_pass.Location = new System.Drawing.Point(282, 286);
            this.TB_pass.Name = "TB_pass";
            this.TB_pass.Size = new System.Drawing.Size(272, 61);
            this.TB_pass.TabIndex = 4;
            this.TB_pass.UseSystemPasswordChar = true;
            // 
            // Btn_Vhod
            // 
            this.Btn_Vhod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Btn_Vhod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Btn_Vhod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Vhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Vhod.ForeColor = System.Drawing.Color.White;
            this.Btn_Vhod.Location = new System.Drawing.Point(92, 407);
            this.Btn_Vhod.Name = "Btn_Vhod";
            this.Btn_Vhod.Size = new System.Drawing.Size(243, 78);
            this.Btn_Vhod.TabIndex = 8;
            this.Btn_Vhod.Text = "Вход";
            this.Btn_Vhod.UseVisualStyleBackColor = false;
            this.Btn_Vhod.Click += new System.EventHandler(this.Btn_Vhod_Click);
            // 
            // Btn_Nazad
            // 
            this.Btn_Nazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Btn_Nazad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Btn_Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Nazad.ForeColor = System.Drawing.Color.White;
            this.Btn_Nazad.Location = new System.Drawing.Point(399, 407);
            this.Btn_Nazad.Name = "Btn_Nazad";
            this.Btn_Nazad.Size = new System.Drawing.Size(247, 78);
            this.Btn_Nazad.TabIndex = 9;
            this.Btn_Nazad.Text = " Назад";
            this.Btn_Nazad.UseVisualStyleBackColor = false;
            this.Btn_Nazad.Click += new System.EventHandler(this.Btn_Nazad_Click);
            // 
            // LPodskazka
            // 
            this.LPodskazka.AutoSize = true;
            this.LPodskazka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LPodskazka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LPodskazka.Location = new System.Drawing.Point(312, 521);
            this.LPodskazka.Name = "LPodskazka";
            this.LPodskazka.Size = new System.Drawing.Size(154, 32);
            this.LPodskazka.TabIndex = 10;
            this.LPodskazka.Text = "Подсказка";
            this.LPodskazka.Click += new System.EventHandler(this.LPodskazka_Click);
            // 
            // PB_yes2
            // 
            this.PB_yes2.Image = global::DB_Stroy_Materyali.Properties.Resources._8665352_eye_slash_icon;
            this.PB_yes2.Location = new System.Drawing.Point(582, 283);
            this.PB_yes2.Name = "PB_yes2";
            this.PB_yes2.Size = new System.Drawing.Size(64, 64);
            this.PB_yes2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_yes2.TabIndex = 7;
            this.PB_yes2.TabStop = false;
            this.PB_yes2.Click += new System.EventHandler(this.PB_yes2_Click);
            // 
            // PB_yes
            // 
            this.PB_yes.Image = global::DB_Stroy_Materyali.Properties.Resources._8541829_eye_vision_view_icon__1_;
            this.PB_yes.Location = new System.Drawing.Point(582, 283);
            this.PB_yes.Name = "PB_yes";
            this.PB_yes.Size = new System.Drawing.Size(64, 64);
            this.PB_yes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_yes.TabIndex = 6;
            this.PB_yes.TabStop = false;
            this.PB_yes.Click += new System.EventHandler(this.PB_yes_Click);
            // 
            // PB_Log
            // 
            this.PB_Log.Image = global::DB_Stroy_Materyali.Properties.Resources._285655_user_icon__1_;
            this.PB_Log.Location = new System.Drawing.Point(582, 186);
            this.PB_Log.Name = "PB_Log";
            this.PB_Log.Size = new System.Drawing.Size(64, 64);
            this.PB_Log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Log.TabIndex = 5;
            this.PB_Log.TabStop = false;
            // 
            // Avtorizacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 589);
            this.Controls.Add(this.LPodskazka);
            this.Controls.Add(this.Btn_Nazad);
            this.Controls.Add(this.Btn_Vhod);
            this.Controls.Add(this.PB_yes2);
            this.Controls.Add(this.PB_yes);
            this.Controls.Add(this.PB_Log);
            this.Controls.Add(this.TB_pass);
            this.Controls.Add(this.TB_login);
            this.Controls.Add(this.Lpassword);
            this.Controls.Add(this.Llogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Avtorizacia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avtorizacia";
            this.Load += new System.EventHandler(this.Avtorizacia_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Avtorizacia_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Avtorizacia_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_STR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_yes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_yes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lavtoriz;
        private System.Windows.Forms.Label Llogin;
        private System.Windows.Forms.Label Lpassword;
        private System.Windows.Forms.TextBox TB_login;
        private System.Windows.Forms.TextBox TB_pass;
        private System.Windows.Forms.PictureBox PB_STR;
        private System.Windows.Forms.PictureBox PB_Log;
        private System.Windows.Forms.PictureBox PB_yes;
        private System.Windows.Forms.PictureBox PB_yes2;
        private System.Windows.Forms.Button Btn_Vhod;
        private System.Windows.Forms.Button Btn_Nazad;
        private System.Windows.Forms.Label LPodskazka;
        private System.Windows.Forms.Button Btn_close;
    }
}