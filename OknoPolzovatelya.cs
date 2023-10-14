using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;
using System.Drawing.Text;

namespace DB_Stroy_Materyali
{
    public partial class OknoPolzovatelya : Form
    {
        BD db = new BD();
        int slectRow;
        public OknoPolzovatelya()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_SIZEBOX = 0x40000;

                var cp = base.CreateParams;
                cp.Style |= WS_SIZEBOX;

                return cp;
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void OknoPolzovatelya_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(Btn_back, "Вернуться на главную страницу");
            toolTip.SetToolTip(Btn_close, "Закрыть приложение");
            toolTip.SetToolTip(TB_Poisk, "Введите артикль");
            
            string queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId;";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, db.GetSqlConnection());
            DataSet dataSetds = new DataSet();
            dataSetds.Tables.Clear();
            adapter.Fill(dataSetds);
            DGV_Polzovatel.DataSource = dataSetds.Tables[0];
            db.closeConnection();

            this.MinimumSize = new Size(700, 500);


        }
        


        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav_stranica glav_Stranica = new Glav_stranica();
            glav_Stranica.ShowDialog();
        }


        Point lastPoint;
       

        private void LNazvanie_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LNazvanie_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void tableLayoutPanel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void tableLayoutPanel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CB_Price_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryString;
            DataSet dataSetds = new DataSet();
            CB_Product.Text = "";
            CB_Proizvoditel.Text = "";
            CB_Kategory.Text = "";

            switch (CB_Price.SelectedIndex)
            {
                case 0:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId order by Price";
                    SqlDataAdapter adapter1 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter1.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 1:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId order by Price DESC";
                    SqlDataAdapter adapter2 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter2.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;

                case 2:

                    
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId";
                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
            }
        }

        private void CB_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryString;
            DataSet dataSetds = new DataSet();
            CB_Kategory.Text = "";
            CB_Proizvoditel.Text = "";
            CB_Price.Text = "";

            switch (CB_Product.SelectedIndex)
            {
                 
                case 0:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=1;";
                    SqlDataAdapter adapter1 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter1.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 1:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=2;";
                    SqlDataAdapter adapter2 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter2.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 2:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=3;";
                    SqlDataAdapter adapter3 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter3.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 3:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=4;";
                    SqlDataAdapter adapter4 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter4.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 4:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=5;";
                    SqlDataAdapter adapter5 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter5.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 5:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=6;";
                    SqlDataAdapter adapter6= new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter6.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 6:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=7;";
                    SqlDataAdapter adapter7 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter7.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 7:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=8;";
                    SqlDataAdapter adapter8 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter8.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 8:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=9;";
                    SqlDataAdapter adapter9 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter9.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 9:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=10;";
                    SqlDataAdapter adapter10 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter10.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 10:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=11;";
                    SqlDataAdapter adapter11 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter11.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 11:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=12;";
                    SqlDataAdapter adapter12 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter12.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 12:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=13;";
                    SqlDataAdapter adapter13 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter13.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 13:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=14;";
                    SqlDataAdapter adapter14 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter14.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 14:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=15;";
                    SqlDataAdapter adapter15 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter15.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 15:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=16;";
                    SqlDataAdapter adapter16 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter16.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 16:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=17;";
                    SqlDataAdapter adapter17 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter17.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 17:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=18;";
                    SqlDataAdapter adapter18 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter18.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 18:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=19;";
                    SqlDataAdapter adapter19 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter19.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 19:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=20;";
                    SqlDataAdapter adapter20 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter20.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 20:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=21;";
                    SqlDataAdapter adapter21 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter21.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 21:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=22;";
                    SqlDataAdapter adapter22 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter22.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 22:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and NameProduct.id=23;";
                    SqlDataAdapter adapter23 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter23.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 23:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId";
                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
            }            


        }

        private void CB_Proizvoditel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryString;
            DataSet dataSetds = new DataSet();
            CB_Product.Text = "";
            CB_Kategory.Text = "";
            CB_Price.Text = "";
            switch (CB_Proizvoditel.SelectedIndex)
            {
                case 0:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=1;";
                    SqlDataAdapter adapter1 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter1.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 1:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=2;";
                    SqlDataAdapter adapter2 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter2.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 2:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=3;";
                    SqlDataAdapter adapter3 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter3.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 3:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=4;";
                    SqlDataAdapter adapter4 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter4.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 4:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=5;";
                    SqlDataAdapter adapter5 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter5.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 5:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=6;";
                    SqlDataAdapter adapter6 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter6.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 6:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=7;";
                    SqlDataAdapter adapter7 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter7.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 7:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=8;";
                    SqlDataAdapter adapter8 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter8.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 8:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=9;";
                    SqlDataAdapter adapter9 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter9.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 9:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=10;";
                    SqlDataAdapter adapter10 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter10.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 10:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=11;";
                    SqlDataAdapter adapter11 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter11.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 11:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=12;";
                    SqlDataAdapter adapter12 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter12.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 12:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=13;";
                    SqlDataAdapter adapter13 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter13.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 13:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=14;";
                    SqlDataAdapter adapter14 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter14.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 14:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=15;";
                    SqlDataAdapter adapter15 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter15.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 15:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=16;";
                    SqlDataAdapter adapter16 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter16.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 16:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and Manufacturer.Id=17;";
                    SqlDataAdapter adapter17 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter17.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 17:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId";
                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
            }
        }

        private void CB_Kategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryString;
            DataSet dataSetds = new DataSet();
            CB_Product.Text = "";
            CB_Proizvoditel.Text = "";
            CB_Price.Text = "";

            switch (CB_Kategory.SelectedIndex)
            {
                case 0:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and ProductCategory.Id=1;";
                    SqlDataAdapter adapter1 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter1.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 1:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and ProductCategory.Id=2;";
                    SqlDataAdapter adapter2 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter2.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 2:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and ProductCategory.Id=3;";
                    SqlDataAdapter adapter3 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter3.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 3:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and ProductCategory.Id=4;";
                    SqlDataAdapter adapter4 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter4.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 4:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId and ProductCategory.Id=5;";
                    SqlDataAdapter adapter5 = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter5.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;
                case 5:
                    queryString = $"select ProductAll.Id as id, ProductAll.Artikl as Artikl, NameProduct.Name as Tovar, ProductAll.Price as Price, ProductAll.Max_discount, Manufacturer.Name as Proizvoditel, ProductCategory.Product_category as Kategory, ProductAll.Quantity_in_stock as Ostatok, productAll.Description as Komentaryi, ProductAll.Image from ProductAll, NameProduct, Manufacturer, ProductCategory where NameProduct.Id=ProductAll.NameId and Manufacturer.Id=ProductAll.ManufacterId and ProductCategory.Id=ProductAll.Product_categoryId";
                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, db.GetSqlConnection());
                    dataSetds.Tables.Clear();
                    adapter.Fill(dataSetds);
                    DGV_Polzovatel.DataSource = dataSetds.Tables[0];
                    db.closeConnection();
                    break;

            }
        }

     

        private void TB_Poisk_TextChanged(object sender, EventArgs e)
        {
            (DGV_Polzovatel.DataSource as DataTable).DefaultView.RowFilter = $"Artikl like '%" + TB_Poisk.Text + "%'";
        }

        private void DGV_Polzovatel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            slectRow = e.RowIndex;
            if (slectRow >= 0)
            {
                DataGridViewRow row = DGV_Polzovatel.Rows[slectRow];
                TB_Artikl.Text = row.Cells[1].Value.ToString();
                CB_tovar.Text = row.Cells[2].Value.ToString();
              
                TB_Price.Text = row.Cells[3].Value.ToString();
                TB_MaxDickont.Text = row.Cells[4].Value.ToString();
                CB_Munufact.Text = row.Cells[5].Value.ToString();
                
                CB_Category.Text = row.Cells[6].Value.ToString();
                
                TB_Count.Text = row.Cells[7].Value.ToString();
                TB_Opisanie.Text = row.Cells[8].Value.ToString();
                TB_Image.Text = row.Cells[9].Value.ToString();

            }
        }
    }

}

