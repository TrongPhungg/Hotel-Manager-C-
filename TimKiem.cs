using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aa
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        private void btnTimTheoMaPhong_Click(object sender, EventArgs e)
        {
            TimMaPhong f=new TimMaPhong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimPhongTrong_Click(object sender, EventArgs e)
        {
            TimPhongTrong f=new TimPhongTrong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTimPhongCoKhach_Click(object sender, EventArgs e)
        {
            PhongCoKhach f =new PhongCoKhach(); 
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


    }
}
