using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Stroy_Materyali
{
    public partial class DobavlenieZapisi : Form
    {
        public DobavlenieZapisi()
        {
            InitializeComponent();
        }

        private void DobavlenieZapisi_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(645, 350);
            TB_Artikl.MaxLength = 50;
        }

        private void Btn_bakc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav_stranica glav_Stranica = new Glav_stranica();
            glav_Stranica.ShowDialog();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void PSTR_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PSTR_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void DobavlenieZapisi_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void DobavlenieZapisi_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Btn_NovZapis_Click(object sender, EventArgs e)
        {
            var artikl = TB_Artikl.Text;
            var unit = CB_Unit.Text;
            var price = TB_Price.Text;
            var maxDiskont = TB_MaxDickont.Text;
            var diskont = TB_TekDiskont.Text;
            var ostatok = TB_Count.Text;
            var tovar = CB_tovar.Text;
            var postavshik = CB_Provader.Text;
            var category = CB_Category.Text;
            var manufacture = CB_Provader.Text;
            var opisanie = TB_Opisanie.Text;
            var image = TB_Image.Text;
        }
    }
}
