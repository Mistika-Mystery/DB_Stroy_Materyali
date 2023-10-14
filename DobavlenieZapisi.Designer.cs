namespace DB_Stroy_Materyali
{
    partial class DobavlenieZapisi
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
            this.PSTR = new System.Windows.Forms.Panel();
            this.Btn_close = new System.Windows.Forms.Button();
            this.LNazvanie = new System.Windows.Forms.Label();
            this.PB_STR = new System.Windows.Forms.PictureBox();
            this.Btn_bakc = new System.Windows.Forms.Button();
            this.LArtikl = new System.Windows.Forms.Label();
            this.TB_Artikl = new System.Windows.Forms.TextBox();
            this.LNameProduct = new System.Windows.Forms.Label();
            this.CB_tovar = new System.Windows.Forms.ComboBox();
            this.LUnit = new System.Windows.Forms.Label();
            this.CB_Unit = new System.Windows.Forms.ComboBox();
            this.LPrice = new System.Windows.Forms.Label();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.LMaxDiskont = new System.Windows.Forms.Label();
            this.TB_MaxDickont = new System.Windows.Forms.TextBox();
            this.LProizvoditel = new System.Windows.Forms.Label();
            this.CB_Munufact = new System.Windows.Forms.ComboBox();
            this.LPostavshik = new System.Windows.Forms.Label();
            this.CB_Provader = new System.Windows.Forms.ComboBox();
            this.LCategory = new System.Windows.Forms.Label();
            this.CB_Category = new System.Windows.Forms.ComboBox();
            this.LTekDiskont = new System.Windows.Forms.Label();
            this.TB_TekDiskont = new System.Windows.Forms.TextBox();
            this.LCount = new System.Windows.Forms.Label();
            this.TB_Count = new System.Windows.Forms.TextBox();
            this.LOpisanie = new System.Windows.Forms.Label();
            this.TB_Opisanie = new System.Windows.Forms.TextBox();
            this.LImage = new System.Windows.Forms.Label();
            this.TB_Image = new System.Windows.Forms.TextBox();
            this.Btn_NovZapis = new System.Windows.Forms.Button();
            this.PSTR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_STR)).BeginInit();
            this.SuspendLayout();
            // 
            // PSTR
            // 
            this.PSTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.PSTR.Controls.Add(this.Btn_close);
            this.PSTR.Controls.Add(this.LNazvanie);
            this.PSTR.Controls.Add(this.PB_STR);
            this.PSTR.Dock = System.Windows.Forms.DockStyle.Top;
            this.PSTR.Location = new System.Drawing.Point(0, 0);
            this.PSTR.Name = "PSTR";
            this.PSTR.Size = new System.Drawing.Size(1733, 137);
            this.PSTR.TabIndex = 0;
            this.PSTR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PSTR_MouseDown);
            this.PSTR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PSTR_MouseMove);
            // 
            // Btn_close
            // 
            this.Btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_close.FlatAppearance.BorderSize = 0;
            this.Btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_close.ForeColor = System.Drawing.Color.White;
            this.Btn_close.Location = new System.Drawing.Point(1627, 0);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(94, 88);
            this.Btn_close.TabIndex = 5;
            this.Btn_close.Text = "X";
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // LNazvanie
            // 
            this.LNazvanie.AutoSize = true;
            this.LNazvanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LNazvanie.ForeColor = System.Drawing.Color.White;
            this.LNazvanie.Location = new System.Drawing.Point(385, 34);
            this.LNazvanie.Name = "LNazvanie";
            this.LNazvanie.Size = new System.Drawing.Size(871, 69);
            this.LNazvanie.TabIndex = 4;
            this.LNazvanie.Text = "Добавить новую запись в БД";
            this.LNazvanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_STR
            // 
            this.PB_STR.Image = global::DB_Stroy_Materyali.Properties.Resources.logo;
            this.PB_STR.Location = new System.Drawing.Point(12, 12);
            this.PB_STR.Name = "PB_STR";
            this.PB_STR.Size = new System.Drawing.Size(100, 100);
            this.PB_STR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_STR.TabIndex = 1;
            this.PB_STR.TabStop = false;
            // 
            // Btn_bakc
            // 
            this.Btn_bakc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Btn_bakc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_bakc.FlatAppearance.BorderSize = 0;
            this.Btn_bakc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Btn_bakc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_bakc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_bakc.ForeColor = System.Drawing.Color.White;
            this.Btn_bakc.Location = new System.Drawing.Point(1046, 725);
            this.Btn_bakc.Name = "Btn_bakc";
            this.Btn_bakc.Size = new System.Drawing.Size(458, 117);
            this.Btn_bakc.TabIndex = 6;
            this.Btn_bakc.Text = "Вернуться назад";
            this.Btn_bakc.UseVisualStyleBackColor = false;
            this.Btn_bakc.Click += new System.EventHandler(this.Btn_bakc_Click);
            // 
            // LArtikl
            // 
            this.LArtikl.AutoSize = true;
            this.LArtikl.Location = new System.Drawing.Point(93, 199);
            this.LArtikl.Name = "LArtikl";
            this.LArtikl.Size = new System.Drawing.Size(78, 32);
            this.LArtikl.TabIndex = 1;
            this.LArtikl.Text = "Artikl";
            // 
            // TB_Artikl
            // 
            this.TB_Artikl.Location = new System.Drawing.Point(214, 193);
            this.TB_Artikl.Name = "TB_Artikl";
            this.TB_Artikl.Size = new System.Drawing.Size(313, 38);
            this.TB_Artikl.TabIndex = 2;
            // 
            // LNameProduct
            // 
            this.LNameProduct.AutoSize = true;
            this.LNameProduct.Location = new System.Drawing.Point(797, 187);
            this.LNameProduct.Name = "LNameProduct";
            this.LNameProduct.Size = new System.Drawing.Size(94, 32);
            this.LNameProduct.TabIndex = 3;
            this.LNameProduct.Text = "Товар";
            // 
            // CB_tovar
            // 
            this.CB_tovar.FormattingEnabled = true;
            this.CB_tovar.Items.AddRange(new object[] {
            "Цемент",
            "Пленка техническа",
            "Песок строительный",
            "Керамзит фракция",
            "Газобетон",
            "Пазогребневая плита ",
            "Угол наружный",
            "Кирпич",
            "Скоба для пазогребневой плиты",
            "Штукатурка гипсовая",
            "Шпаклевка",
            "Клей для плитки, керамогранита и камня",
            "Смесь цементно-песчаная",
            "Ровнитель",
            "Лезвие для ножа ",
            "Шпатель",
            "Нож строительный ",
            "Валик",
            "Кисть",
            "Очки защитные",
            "Каска защитная ",
            "Маска защитная",
            "Подшлемник"});
            this.CB_tovar.Location = new System.Drawing.Point(918, 187);
            this.CB_tovar.Name = "CB_tovar";
            this.CB_tovar.Size = new System.Drawing.Size(662, 39);
            this.CB_tovar.TabIndex = 4;
            // 
            // LUnit
            // 
            this.LUnit.AutoSize = true;
            this.LUnit.Location = new System.Drawing.Point(93, 279);
            this.LUnit.Name = "LUnit";
            this.LUnit.Size = new System.Drawing.Size(107, 32);
            this.LUnit.TabIndex = 5;
            this.LUnit.Text = "Мера в";
            // 
            // CB_Unit
            // 
            this.CB_Unit.FormattingEnabled = true;
            this.CB_Unit.Items.AddRange(new object[] {
            "шт."});
            this.CB_Unit.Location = new System.Drawing.Point(214, 279);
            this.CB_Unit.Name = "CB_Unit";
            this.CB_Unit.Size = new System.Drawing.Size(313, 39);
            this.CB_Unit.TabIndex = 6;
            // 
            // LPrice
            // 
            this.LPrice.AutoSize = true;
            this.LPrice.Location = new System.Drawing.Point(93, 368);
            this.LPrice.Name = "LPrice";
            this.LPrice.Size = new System.Drawing.Size(83, 32);
            this.LPrice.TabIndex = 7;
            this.LPrice.Text = "Цена";
            // 
            // TB_Price
            // 
            this.TB_Price.Location = new System.Drawing.Point(214, 368);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(313, 38);
            this.TB_Price.TabIndex = 8;
            // 
            // LMaxDiskont
            // 
            this.LMaxDiskont.AutoSize = true;
            this.LMaxDiskont.Location = new System.Drawing.Point(93, 460);
            this.LMaxDiskont.Name = "LMaxDiskont";
            this.LMaxDiskont.Size = new System.Drawing.Size(170, 32);
            this.LMaxDiskont.TabIndex = 9;
            this.LMaxDiskont.Text = "Мах Скидка";
            // 
            // TB_MaxDickont
            // 
            this.TB_MaxDickont.Location = new System.Drawing.Point(306, 457);
            this.TB_MaxDickont.Name = "TB_MaxDickont";
            this.TB_MaxDickont.Size = new System.Drawing.Size(221, 38);
            this.TB_MaxDickont.TabIndex = 10;
            // 
            // LProizvoditel
            // 
            this.LProizvoditel.AutoSize = true;
            this.LProizvoditel.Location = new System.Drawing.Point(797, 463);
            this.LProizvoditel.Name = "LProizvoditel";
            this.LProizvoditel.Size = new System.Drawing.Size(219, 32);
            this.LProizvoditel.TabIndex = 11;
            this.LProizvoditel.Text = "Производитель";
            // 
            // CB_Munufact
            // 
            this.CB_Munufact.FormattingEnabled = true;
            this.CB_Munufact.Items.AddRange(new object[] {
            "М500",
            "Изостронг",
            "Knauf",
            "MixMaster",
            "ЛСР",
            "ВОЛМА",
            "Vinylon",
            "Павловский завод",
            "Weber",
            "Hesler",
            "Armero",
            "Wenzo Roma",
            "KILIMGRIN",
            "Исток",
            "Husqvarna",
            "Delta",
            "RUIZ"});
            this.CB_Munufact.Location = new System.Drawing.Point(1046, 456);
            this.CB_Munufact.Name = "CB_Munufact";
            this.CB_Munufact.Size = new System.Drawing.Size(534, 39);
            this.CB_Munufact.TabIndex = 12;
            // 
            // LPostavshik
            // 
            this.LPostavshik.AutoSize = true;
            this.LPostavshik.Location = new System.Drawing.Point(797, 286);
            this.LPostavshik.Name = "LPostavshik";
            this.LPostavshik.Size = new System.Drawing.Size(161, 32);
            this.LPostavshik.TabIndex = 13;
            this.LPostavshik.Text = "Поставщик";
            // 
            // CB_Provader
            // 
            this.CB_Provader.FormattingEnabled = true;
            this.CB_Provader.Items.AddRange(new object[] {
            "М500",
            "Изостронг",
            "Knauf",
            "MixMaster",
            "ЛСР",
            "ВОЛМА",
            "Vinylon",
            "Павловский завод",
            "Weber",
            "Hesler",
            "Armero",
            "Wenzo Roma",
            "KILIMGRIN",
            "Исток",
            "Husqvarna",
            "Delta",
            "RUIZ"});
            this.CB_Provader.Location = new System.Drawing.Point(1020, 279);
            this.CB_Provader.Name = "CB_Provader";
            this.CB_Provader.Size = new System.Drawing.Size(560, 39);
            this.CB_Provader.TabIndex = 14;
            // 
            // LCategory
            // 
            this.LCategory.AutoSize = true;
            this.LCategory.Location = new System.Drawing.Point(797, 375);
            this.LCategory.Name = "LCategory";
            this.LCategory.Size = new System.Drawing.Size(152, 32);
            this.LCategory.TabIndex = 15;
            this.LCategory.Text = "Категория";
            // 
            // CB_Category
            // 
            this.CB_Category.FormattingEnabled = true;
            this.CB_Category.Items.AddRange(new object[] {
            "Общестроительные материалы",
            "Стеновые и фасадные материалы",
            "Сухие строительные смеси и гидроизоляция",
            "Ручной инструмент",
            "Защита лица, глаз, головы"});
            this.CB_Category.Location = new System.Drawing.Point(1020, 368);
            this.CB_Category.Name = "CB_Category";
            this.CB_Category.Size = new System.Drawing.Size(560, 39);
            this.CB_Category.TabIndex = 16;
            // 
            // LTekDiskont
            // 
            this.LTekDiskont.AutoSize = true;
            this.LTekDiskont.Location = new System.Drawing.Point(93, 546);
            this.LTekDiskont.Name = "LTekDiskont";
            this.LTekDiskont.Size = new System.Drawing.Size(110, 32);
            this.LTekDiskont.TabIndex = 17;
            this.LTekDiskont.Text = "Скидка";
            // 
            // TB_TekDiskont
            // 
            this.TB_TekDiskont.Location = new System.Drawing.Point(306, 546);
            this.TB_TekDiskont.Name = "TB_TekDiskont";
            this.TB_TekDiskont.Size = new System.Drawing.Size(221, 38);
            this.TB_TekDiskont.TabIndex = 18;
            // 
            // LCount
            // 
            this.LCount.AutoSize = true;
            this.LCount.Location = new System.Drawing.Point(93, 632);
            this.LCount.Name = "LCount";
            this.LCount.Size = new System.Drawing.Size(122, 32);
            this.LCount.TabIndex = 19;
            this.LCount.Text = "Остаток";
            // 
            // TB_Count
            // 
            this.TB_Count.Location = new System.Drawing.Point(276, 626);
            this.TB_Count.Name = "TB_Count";
            this.TB_Count.Size = new System.Drawing.Size(251, 38);
            this.TB_Count.TabIndex = 20;
            // 
            // LOpisanie
            // 
            this.LOpisanie.AutoSize = true;
            this.LOpisanie.Location = new System.Drawing.Point(797, 546);
            this.LOpisanie.Name = "LOpisanie";
            this.LOpisanie.Size = new System.Drawing.Size(146, 32);
            this.LOpisanie.TabIndex = 21;
            this.LOpisanie.Text = "Описание";
            // 
            // TB_Opisanie
            // 
            this.TB_Opisanie.Location = new System.Drawing.Point(1029, 546);
            this.TB_Opisanie.Name = "TB_Opisanie";
            this.TB_Opisanie.Size = new System.Drawing.Size(551, 38);
            this.TB_Opisanie.TabIndex = 22;
            // 
            // LImage
            // 
            this.LImage.AutoSize = true;
            this.LImage.Location = new System.Drawing.Point(797, 632);
            this.LImage.Name = "LImage";
            this.LImage.Size = new System.Drawing.Size(197, 32);
            this.LImage.TabIndex = 23;
            this.LImage.Text = "Имя картинки";
            // 
            // TB_Image
            // 
            this.TB_Image.Location = new System.Drawing.Point(1029, 632);
            this.TB_Image.Name = "TB_Image";
            this.TB_Image.Size = new System.Drawing.Size(551, 38);
            this.TB_Image.TabIndex = 24;
            // 
            // Btn_NovZapis
            // 
            this.Btn_NovZapis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Btn_NovZapis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NovZapis.FlatAppearance.BorderSize = 0;
            this.Btn_NovZapis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Btn_NovZapis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NovZapis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_NovZapis.ForeColor = System.Drawing.Color.White;
            this.Btn_NovZapis.Location = new System.Drawing.Point(214, 725);
            this.Btn_NovZapis.Name = "Btn_NovZapis";
            this.Btn_NovZapis.Size = new System.Drawing.Size(578, 117);
            this.Btn_NovZapis.TabIndex = 25;
            this.Btn_NovZapis.Text = "Добавить новую запись";
            this.Btn_NovZapis.UseVisualStyleBackColor = false;
            this.Btn_NovZapis.Click += new System.EventHandler(this.Btn_NovZapis_Click);
            // 
            // DobavlenieZapisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 893);
            this.Controls.Add(this.Btn_NovZapis);
            this.Controls.Add(this.Btn_bakc);
            this.Controls.Add(this.TB_Image);
            this.Controls.Add(this.LImage);
            this.Controls.Add(this.TB_Opisanie);
            this.Controls.Add(this.LOpisanie);
            this.Controls.Add(this.TB_Count);
            this.Controls.Add(this.LCount);
            this.Controls.Add(this.TB_TekDiskont);
            this.Controls.Add(this.LTekDiskont);
            this.Controls.Add(this.CB_Category);
            this.Controls.Add(this.LCategory);
            this.Controls.Add(this.CB_Provader);
            this.Controls.Add(this.LPostavshik);
            this.Controls.Add(this.CB_Munufact);
            this.Controls.Add(this.LProizvoditel);
            this.Controls.Add(this.TB_MaxDickont);
            this.Controls.Add(this.LMaxDiskont);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.LPrice);
            this.Controls.Add(this.CB_Unit);
            this.Controls.Add(this.LUnit);
            this.Controls.Add(this.CB_tovar);
            this.Controls.Add(this.LNameProduct);
            this.Controls.Add(this.TB_Artikl);
            this.Controls.Add(this.LArtikl);
            this.Controls.Add(this.PSTR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DobavlenieZapisi";
            this.Text = "DobavlenieZapisi";
            this.Load += new System.EventHandler(this.DobavlenieZapisi_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DobavlenieZapisi_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DobavlenieZapisi_MouseMove);
            this.PSTR.ResumeLayout(false);
            this.PSTR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_STR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PSTR;
        private System.Windows.Forms.PictureBox PB_STR;
        private System.Windows.Forms.Label LNazvanie;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.Button Btn_bakc;
        private System.Windows.Forms.Label LArtikl;
        private System.Windows.Forms.TextBox TB_Artikl;
        private System.Windows.Forms.Label LNameProduct;
        private System.Windows.Forms.ComboBox CB_tovar;
        private System.Windows.Forms.Label LUnit;
        private System.Windows.Forms.ComboBox CB_Unit;
        private System.Windows.Forms.Label LPrice;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.Label LMaxDiskont;
        private System.Windows.Forms.TextBox TB_MaxDickont;
        private System.Windows.Forms.Label LProizvoditel;
        private System.Windows.Forms.ComboBox CB_Munufact;
        private System.Windows.Forms.Label LPostavshik;
        private System.Windows.Forms.ComboBox CB_Provader;
        private System.Windows.Forms.Label LCategory;
        private System.Windows.Forms.ComboBox CB_Category;
        private System.Windows.Forms.Label LTekDiskont;
        private System.Windows.Forms.TextBox TB_TekDiskont;
        private System.Windows.Forms.Label LCount;
        private System.Windows.Forms.TextBox TB_Count;
        private System.Windows.Forms.Label LOpisanie;
        private System.Windows.Forms.TextBox TB_Opisanie;
        private System.Windows.Forms.Label LImage;
        private System.Windows.Forms.TextBox TB_Image;
        private System.Windows.Forms.Button Btn_NovZapis;
    }
}