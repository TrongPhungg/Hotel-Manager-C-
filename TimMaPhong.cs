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
    public partial class TimMaPhong : Form
    {
        public TimMaPhong()
        {
            InitializeComponent();
        }

        String path = "danhsachphong.dat";
        DanhSachPhong dsPhong;
        Phong phong;
        private void Find_Load(object sender, EventArgs e)
        {
            dsPhong=new DanhSachPhong();
            dsPhong.ReadFile(path);
        }
        private void HienThi(DataGridView dgv,List<Phong> ds)
        {
            dgv.DataSource = ds;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            bool flag = true;
            String ma = txtTim.Text;
            List <Phong> ds=new List<Phong>();
            foreach (Phong p in dsPhong.DSPhong)
            {
                if (p.MaPhong.Equals(ma))
                { 
                    ds.Add(p);
                    flag = false;
                }             
            }
            if (flag == true)
            {
                MessageBox.Show("Phòng này không có", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HienThi(dgvTim,ds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
