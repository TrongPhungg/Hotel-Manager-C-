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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        DSDoanhThu ds;
        List<DoanhThu> dsdt;
        private String DT = "doanhthu.dat";
        private void HienThi(DataGridView dgv,List<DoanhThu> list)
        {
            BindingSource bs=new BindingSource();   
            bs.DataSource = list;
            dgv.DataSource = bs;
        }
        private void ThongKe_Load(object sender, EventArgs e)
        {
            ds=new DSDoanhThu();
            if (ds.DocFile(DT) == true)
            {
                HienThi(dgvDoanhThu, ds.DanhSachDoanhThu);
            }
            lbDoanhThu.Text = "Tổng doanh thu của khách sạn là: "+this.ds.TongDoanhThu().ToString();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnDoanhThuPhong_Click(object sender, EventArgs e)
        {
            String ma=txtDoanhThuPhong.Text;
            double tong=this.ds.TongDoanhThu1Phong(ma);
            if(tong>0)
            {
                MessageBox.Show("Tổng doanh thu phòng " + ma + " là: " + tong, "Thông báo", MessageBoxButtons.OK);

            }
            else MessageBox.Show("Mời bạn nhập mã phòng muốn tính doanh thu", "Thông báo", MessageBoxButtons.OK);

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            String ma = ds.Max();
            MessageBox.Show("Tổng doanh thu lớn nhất là phòng " + ma + " : " + ds.TongDoanhThu1Phong(ma)+" VNĐ ", "Thông báo", MessageBoxButtons.OK);

        }

        //private void btnTong_Click(object sender, EventArgs e)
        //{
        //    double tong = this.ds.TongDoanhThu();
        //    if (tong > 0)
        //    {
        //        MessageBox.Show("Tổng doanh thu của khách sạn là: " + tong+" VNĐ ", "Thông báo", MessageBoxButtons.OK);

        //    }
        //    else MessageBox.Show("Không hợp lệ ", "Thông báo", MessageBoxButtons.OK);
        //}

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ds.DanhSachDoanhThu.Clear();
            HienThi(dgvDoanhThu, ds.DanhSachDoanhThu);
            ds.GhiFile(DT);
        }
    }
}
