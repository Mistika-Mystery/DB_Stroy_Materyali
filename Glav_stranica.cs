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

namespace DB_Stroy_Materyali
{
    public partial class Glav_stranica : Form
    {

        public Glav_stranica()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Avtorizacia avtorizacia= new Avtorizacia();
            avtorizacia.ShowDialog();
        }

        private void Glav_stranica_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(Btn_Admin, "Просмотр БД, \nс возможностью редактирования, создания и удаления полей.\nНеобходимо пройти авторизацию");
            toolTip.SetToolTip(Btn_Polzovatel, "Просмотр БД,\n без возможности редактирования");
            toolTip.SetToolTip(Btn_close, "Закрыть приложение");
            
        }

        private void Btn_Polzovatel_Click(object sender, EventArgs e)
        {
            this.Hide();
            OknoPolzovatelya oknoPolzovatelya = new OknoPolzovatelya();
            oknoPolzovatelya.ShowDialog();
            
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void Glav_stranica_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void Glav_stranica_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
