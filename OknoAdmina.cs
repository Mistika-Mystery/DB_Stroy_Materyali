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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;
using System.Xml.Linq;

namespace DB_Stroy_Materyali
{

    enum RowState
    {
        Existed,
        New,
        Modified,
        Deleted,
        ModifiedNew
    }

    public partial class OknoAdmina : Form 
    {
        BD db = new BD();
        int slectRow;
        public OknoAdmina()
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
       
        private void OknoAdmina_Load(object sender, EventArgs e) 
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(Btn_bakc, "Вернуться на главную страницу");
            toolTip.SetToolTip(Btn_close, "Закрыть приложение");
            this.MinimumSize = new Size(700, 500);
            CreateColumns();
            RefreshDataGrid(DGV_Admin);
            TB_Artikl.MaxLength = 50;




        }

        private void CreateColumns()
        {
            DGV_Admin.Columns.Add("id", "id");
            DGV_Admin.Columns.Add("Artikl", "артикул");
            DGV_Admin.Columns.Add("NameId", "товар");
            DGV_Admin.Columns.Add("UnitId", "единицы");
            DGV_Admin.Columns.Add("Price", "цена");
            DGV_Admin.Columns.Add("Max_discount", "мах-скидка");
            DGV_Admin.Columns.Add("ManufacterId", "производитель");
            DGV_Admin.Columns.Add("ProviderId", "поставщик");
            DGV_Admin.Columns.Add("Product_categoryId", "категория");
            DGV_Admin.Columns.Add("Current_discount", "скидка");
            DGV_Admin.Columns.Add("Quantity_in_stock", "остаток");
            DGV_Admin.Columns.Add("Description", "Примечания");
            DGV_Admin.Columns.Add("Image", "картинка");
            DGV_Admin.Columns.Add("IsNew", String.Empty);

            DGV_Admin.Columns[13].Visible = false;

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), 
                record.GetInt32(4), record.GetInt32(5), record.GetInt32(6), record.GetInt32(7),
                record.GetInt32(8), record.GetInt32(9), record.GetInt32(10), record.GetString(11), 
                record.GetString(12), RowState.ModifiedNew);///проверить, пока все равботает
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from ProductAll";
            SqlCommand command = new SqlCommand(queryString, db.GetSqlConnection());
            db.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            db.closeConnection();
            CleaTextBox();
        }

        private void deletRow()
        {
            int index = DGV_Admin.CurrentCell.RowIndex;
            DGV_Admin.Rows[index].Visible = false;
            if (DGV_Admin.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                DGV_Admin.Rows[index].Cells[0].Value = RowState.Deleted;
                return;

            }
            DGV_Admin.Rows[index].Cells[13].Value = RowState.Deleted;
        }

        private void Updet()
        {
            db.openConnection();
            for (int index = 0; index < DGV_Admin.Rows.Count; index++)
            {
                var rowState = (RowState)DGV_Admin.Rows[index].Cells[13].Value; 
                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(DGV_Admin.Rows[index].Cells[0].Value);
                    var deletqv = $"delete from ProductAll where Id = {id}";
                    var command = new SqlCommand(deletqv, db.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified
                    )
                {
                    var id = DGV_Admin.Rows[index].Cells[0].Value.ToString();
                    var Artikl = DGV_Admin.Rows[index].Cells[1].Value.ToString();
                    var NameId = DGV_Admin.Rows[index].Cells[2].Value.ToString();
                    var UnitId = DGV_Admin.Rows[index].Cells[3].Value.ToString();
                    var Price = DGV_Admin.Rows[index].Cells[4].Value.ToString();
                    var Max_discount = DGV_Admin.Rows[index].Cells[5].Value.ToString();
                    var ManufacterId = DGV_Admin.Rows[index].Cells[6].Value.ToString();
                    var ProviderId = DGV_Admin.Rows[index].Cells[7].Value.ToString();
                    var Product_categoryId = DGV_Admin.Rows[index].Cells[8].Value.ToString();
                    var Current_discount = DGV_Admin.Rows[index].Cells[9].Value.ToString();
                    var Quantity_in_stock = DGV_Admin.Rows[index].Cells[10].Value.ToString();
                    var Description = DGV_Admin.Rows[index].Cells[11].Value.ToString();
                    var Image = DGV_Admin.Rows[index].Cells[12].Value.ToString();

                    var cheqv = $"update ProductAll set Artikl = N'{Artikl}', NameId = N'{NameId}', UnitId = N'{UnitId}',Price = N'{Price}', Max_discount = N'{Max_discount}',ManufacterId = N'{ManufacterId}', ProviderId = N'{ProviderId}', Product_categoryId = N'{Product_categoryId}', Current_discount = N'{Current_discount}', Quantity_in_stock = N'{Quantity_in_stock}', Description = N'{Description}', Image = N'{Image}' where Id ={id}";
                    var command = new SqlCommand(cheqv, db.GetSqlConnection());
                    command.ExecuteNonQuery();


                }
            }
            db.closeConnection();
        }

        private void Cheng()
        {
            var selectRow = DGV_Admin.CurrentCell.RowIndex;


            var id = Convert.ToInt32(DGV_Admin.Rows[selectRow].Cells[0].Value);
            var Artikl = TB_Artikl.Text;
            var NameId = CB_tovar.Text;
            var UnitId = CB_Unit.Text;
            var Price = TB_Price.Text;
            var Max_discount = TB_MaxDickont.Text;
            var ManufacterId = CB_Munufact.Text;
            var ProviderId = CB_Provader.Text;
            var Product_categoryId = CB_Category.Text;
            var Current_discount = TB_TekDiskont.Text;
            var Quantity_in_stock = TB_Count.Text;
            var Description = TB_Opisanie.Text;
            var Image = TB_Image.Text;

            if (!(Artikl == "" || NameId == "" || UnitId == "" || Price == "" || Max_discount == "" || ManufacterId == "" || ProviderId == "" || Product_categoryId == "" || Current_discount == "" || Quantity_in_stock == "" || Description == "" || Image == ""))
            {

                if (DGV_Admin.Rows[selectRow].Cells[0].Value.ToString() != string.Empty)
                {
                    DGV_Admin.Rows[selectRow].SetValues(id, Artikl, NameId, UnitId, Price, Max_discount, ManufacterId, ProviderId, Product_categoryId, Current_discount, Quantity_in_stock, Description, Image); ///тут может быть!

                    DGV_Admin.Rows[selectRow].Cells[13].Value = RowState.Modified;

                }
            }
            else
            {
                MessageBox.Show("Ошибка:\nЗаполнены не все поля!");
            }

        }


        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_bakc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav_stranica glav_Stranica = new Glav_stranica();
            glav_Stranica.ShowDialog();
        }
        
        Point lastPoint;

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

        private void Btn_DobavitZapis_Click(object sender, EventArgs e)
        {
            var Artikl = TB_Artikl.Text;
            var NameId = CB_tovar.Text;
            var UnitId = CB_Unit.Text;
            var Price = TB_Price.Text;
            var Max_discount = TB_MaxDickont.Text;
            var ManufacterId = CB_Munufact.Text;
            var ProviderId = CB_Provader.Text;
            var Product_categoryId = CB_Category.Text;
            var Current_discount = TB_TekDiskont.Text;
            var Quantity_in_stock = TB_Count.Text;
            var Description = TB_Opisanie.Text;
            string Image = TB_Image.Text;
            if (ChekArtikl())
            {
                return;
                    }
                

            if (!(Artikl == "" || NameId == "" || UnitId == "" || Price == "" || Max_discount == "" || ManufacterId == "" || ProviderId == "" || Product_categoryId == "" || Current_discount == "" || Quantity_in_stock == "" || Description == "" || Image == "" || ChekArtikl()==true))
            {
               

            db.openConnection();
            var addqv = $" insert into ProductAll (Artikl, NameId, UnitId, Price, Max_discount, ManufacterId, ProviderId, Product_categoryId, Current_discount, Quantity_in_stock, Description, Image) values ( N'{Artikl}', N'{NameId}', N'{UnitId}', N'{Price}', N'{Max_discount}', N'{ManufacterId}', N'{ProviderId}', N'{Product_categoryId}', N'{Current_discount}', N'{Quantity_in_stock}', N'{Description}', N'{Image}')";///переделать тут добавить перечисления столбцов
            SqlCommand command = new SqlCommand(addqv, db.GetSqlConnection());
            command.ExecuteNonQuery();
            db.closeConnection();
            Updet();
            RefreshDataGrid(DGV_Admin);
            }
            else
            {
                MessageBox.Show("Ошибка:\nЗаполнены не все поля!");
            }

        }

        private void DGV_Admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            slectRow = e.RowIndex;
            if (slectRow >= 0)
            {
                DataGridViewRow row = DGV_Admin.Rows[slectRow];
                TB_Artikl.Text = row.Cells[1].Value.ToString();
                CB_tovar.Text = row.Cells[2].Value.ToString();
                CB_Unit.Text = row.Cells[3].Value.ToString();
                TB_Price.Text = row.Cells[4].Value.ToString();
                TB_MaxDickont.Text = row.Cells[5].Value.ToString();
                CB_Munufact.Text = row.Cells[6].Value.ToString();
                CB_Provader.Text = row.Cells[7].Value.ToString();
                CB_Category.Text = row.Cells[8].Value.ToString();
                TB_TekDiskont.Text = row.Cells[9].Value.ToString();
                TB_Count.Text = row.Cells[10].Value.ToString();
                TB_Opisanie.Text = row.Cells[11].Value.ToString();
                TB_Image.Text = row.Cells[12].Value.ToString();
                
            }
        }

      /*  private void IdCategorCB()
        {
            if ( CB_Category.Text== "Общестроительные материалы")
            {
                CB_Category.value == "1";
            }
            if (CB_Category.Text == "Стеновые и фасадные материалы")
            {
                CB_Category.Text == "2";
            }
            if (CB_Category.Text == "Сухие строительные смеси и гидроизоляция")
            {
                CB_Category.Text == "3";
            }
            if (CB_Category.Text == "Ручной инструмент")
            {
                CB_Category.Text == "4";
            }
            if (CB_Category.Text == "Защита лица, глаз, головы")
            {
                CB_Category.Text == "5";
            }
            else
            {
                MessageBox.Show("Такой категории нет");
            }
        }*/

        private void CleaTextBox()
        {
            TB_Artikl.Text = "";
            CB_Unit.Text = "";
            CB_tovar.Text = "";
            TB_Price.Text = "";
            TB_MaxDickont.Text = "";
            CB_Munufact.Text = "";
            CB_Provader.Text = "";
            CB_Category.Text = "";
            TB_TekDiskont.Text = "";
            TB_Count.Text = "";
            TB_Opisanie.Text = "";
            TB_Image.Text = "";
        }


        private bool ArtiklProv()/// tozhe poka net
        {
            if (TB_Artikl.MaxLength > 50)
            {

                MessageBox.Show(" Максимальное значение символов 50 ");
                return true;
            }
            else
                return false;
        }
        


        private void Btn_RedaktirovatZapis_Click(object sender, EventArgs e)
        {
            
                Cheng();
                Updet();
                RefreshDataGrid(DGV_Admin);
            
        }

        private void Btn_DelitZapis_Click(object sender, EventArgs e)
        {
            deletRow();
            Updet();
            RefreshDataGrid(DGV_Admin);
        }

        
        private void CB_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CB_Unit.SelectedIndex)///пока не работает
            {
                case 0:
                    CB_Unit.Text = "1";
        
                    break;
                default:
                    MessageBox.Show("Только шт.");
                    CB_Unit.Text = "1";
                    break;
            }
        }

        private bool ChekArtikl()
        {

            string art = TB_Artikl.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select Artikl from ProductAll where Artikl = N'{art}'";
            SqlCommand command = new SqlCommand(querystring, db.GetSqlConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой Артикль уже есть");
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
