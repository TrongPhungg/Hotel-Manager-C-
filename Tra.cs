using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aa
{
    [Serializable]
    public partial class Tra : Form
    {
        public Tra()
        {
            InitializeComponent();
        }
        private String path = "danhsachphong.dat";
        private String ten = "tam.dat";
        private String khach = "dskh.dat";
        private String DT = "doanhthu.dat";
        private String ma;
        private DanhSachPhong dsPhong;
        private CXuli datphong;
        
        private void Tra_Load(object sender, EventArgs e)
        {
            this.Text="Trả Phòng "+this.ma;
            dsPhong=new DanhSachPhong();
            datphong=new CXuli();
            DocMa();
            DocDanhSachKH();
            HienThiDSKH(dgvKhachHang, HienThiKH());

            DocDanhSachPhong();
            HienThiDSP(dgvDSPhong, HienThiPhong());
            lbTienphong.Text = (Tien * Thoigian).ToString();
        }
        private void DocMa()
        {
            FileStream fs = new FileStream(ten, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            this.ma = bf.Deserialize(fs) as String;
            fs.Close();
        }
        private void DocDanhSachPhong()
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            this.dsPhong.DSPhong = bf.Deserialize(fs) as List<Phong>;
            fs.Close();
        }
        private void HienThiDSP(DataGridView dgv, Phong p)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = p;
            dgv.DataSource = bs;
        }
        private Phong HienThiPhong()
        {
            foreach(Phong p in this.dsPhong.DSPhong)
            {
                if (p.MaPhong.Equals(this.ma))
                {
                    Tien = p.GiaTien;
                    return p;
                }
            }
            return null;
        }
        private void DocDanhSachKH()
        {
            FileStream fs = new FileStream(khach, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            this.datphong.DSKhachHang = bf.Deserialize(fs) as List<CKhachhang>;
            fs.Close();
        }
        private void HienThiDSKH(DataGridView dgv,CKhachhang d)
        {
            BindingSource bs=new BindingSource();
            bs.DataSource = d;
            dgv.DataSource = bs; 
        }
        private CKhachhang HienThiKH()
        {
            foreach(CKhachhang c in datphong.DSKhachHang)
            {
                if(c.Ma.Equals(this.ma))
                {
                    Thoigian = (c.ThoiGianRa - c.ThoiGianVao).Days+1;
                    return c;
                }
            }
            return null;
        }
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Close();
        }
        private int Thoigian = 0;
        private int Tien = 0;

        private void btnTraPhong_Click(object sender, EventArgs e)
        {

            DoanhThu d = new DoanhThu(HienThiPhong().MaPhong, Thoigian, (Tien * Thoigian)+tongDichvu());
            DSDoanhThu a = new DSDoanhThu();
            a.DocFile(DT);
            a.Them(d);
            a.GhiFile(DT);
            // dieu kien tra phong
            if (datphong.Xoa(HienThiKH()) == false || dsPhong.TraPhong(HienThiPhong()) == false)
            {
                MessageBox.Show("Không thể xóa", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult kq = MessageBox.Show("Tiền Phòng: " + (Tien*Thoigian).ToString()+" VNĐ "+ " || Thời gian: "+Thoigian.ToString()+" ngày "+" || Dịch vụ thêm: " + tongDichvu().ToString() +" VNĐ" , "Thông Báo", MessageBoxButtons.YesNo);
                if(kq == DialogResult.Yes)
                {
                    MessageBox.Show("Trả phòng thành công", "Thông Báo", MessageBoxButtons.OK);
                    GhiDSKH();
                    GhiDSP();
                    Close();
                }
            }

        }

        public double tongDichvu()
        {
            double tongDV = 0;
            if (cb_Goidau.Checked == true)
                tongDV = Convert.ToDouble(250000 * slGoidau.Value);
            if (cb_Massage.Checked == true)
                tongDV += Convert.ToDouble(350000 * slMassage.Value);
            if (cb_Giatui.Checked == true)
                tongDV += Convert.ToDouble(50000 * slGiatui.Value);
            return tongDV;
        }
        private void GhiDSP()
        {
            FileStream fs=new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf=new BinaryFormatter();   
            bf.Serialize(fs, dsPhong.DSPhong);
            fs.Close();
        }
        private void GhiDSKH()
        {
            FileStream fs = new FileStream(khach, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, datphong.DSKhachHang);
            fs.Close();
        }

        private void lbTongtien_Click(object sender, EventArgs e)
        {
            
        }

        private void slGoidau_ValueChanged(object sender, EventArgs e)
        {
            lbTongtien.Text = tongDichvu().ToString();
        }

        private void slMassage_ValueChanged(object sender, EventArgs e)
        {
            lbTongtien.Text = tongDichvu().ToString();
        }

        private void slGiatui_ValueChanged(object sender, EventArgs e)
        {
            lbTongtien.Text = tongDichvu().ToString();
        }
    }
}
