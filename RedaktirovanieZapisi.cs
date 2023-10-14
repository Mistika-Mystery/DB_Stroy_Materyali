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
    public partial class RedaktirovanieZapisi : Form
    {
       
        public RedaktirovanieZapisi()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RedaktirovanieZapisi_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(645, 350);

      
        }
    }
}
