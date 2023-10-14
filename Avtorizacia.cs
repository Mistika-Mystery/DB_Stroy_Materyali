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
    public partial class Avtorizacia : Form
    {
        BD db = new BD();
        public Avtorizacia()
        {
            InitializeComponent();

        }

        private void Avtorizacia_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(Btn_Nazad, "Вернуться на главную страницу");
            toolTip.SetToolTip(Btn_Vhod, "Авторизоваться");
            toolTip.SetToolTip(Btn_close, "Закрыть приложение");
            toolTip.SetToolTip(LPodskazka, "Нажми меня");
            TB_login.MaxLength = 50;
            TB_pass.MaxLength = 50;
            TB_login.Text = "Введите";
            TB_login.ForeColor = Color.Gray;
            
        }



        private void LPodskazka_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login: admin \nPassword: 111");
        }

        private void Btn_Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav_stranica glav_Stranica = new Glav_stranica();
            glav_Stranica.ShowDialog();
        }

        private void Btn_Vhod_Click(object sender, EventArgs e)
        {
            var login = TB_login.Text;
            var pass = TB_pass.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string querystring = $" select id, login, pass from Users where login='{login}' and pass='{pass}'";
            SqlCommand sqlCommand = new SqlCommand(querystring, db.GetSqlConnection());
            adapter.SelectCommand = sqlCommand;
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                this.Hide();
                MessageBox.Show("Вы успешно авторизированны!");
                OknoAdmina oknoAdmina = new OknoAdmina();
                oknoAdmina.ShowDialog();

            }
            else
            {
                MessageBox.Show("Не правильный логин/пароль\nПосмотри Подсказку");
            }

            db.closeConnection();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void Avtorizacia_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Avtorizacia_MouseDown(object sender, MouseEventArgs e)
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

        private void PB_yes2_Click(object sender, EventArgs e)
        {
            TB_pass.UseSystemPasswordChar = false;
            PB_yes2.Visible = false;
            PB_yes.Visible = true;
        }

        private void PB_yes_Click(object sender, EventArgs e)
        {
            TB_pass.UseSystemPasswordChar = true;
            PB_yes2.Visible = true;
            PB_yes.Visible = false;
        }

        private void TB_login_Enter(object sender, EventArgs e)
        {
            if (TB_login.Text == "Введите")
            {
                {
                    TB_login.Text = "";
                    TB_login.ForeColor = Color.Black;
                }
            }

        }


        private void TB_login_Leave(object sender, EventArgs e)
        {
            if (TB_login.Text == "")
            {
                {
                    TB_login.Text = "Введите";
                    TB_login.ForeColor= Color.Gray;
                }
            }
        }


    }
}

