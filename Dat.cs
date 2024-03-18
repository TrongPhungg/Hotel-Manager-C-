using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aa
{
    [Serializable]
    public partial class Dat : Form
    {
        
        public Dat()
        {
            InitializeComponent();
        }
        private String path = "danhsachphong.dat";
        private String ten = "dskh.dat";
        private String temp = "temp.dat";
        private CXuli _datPhong;
        private CKhachhang _khachhang;
        private String ma;
        private int vitri = -1;
        private void docma()
        {
            FileStream fs = new FileStream(temp, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            this.ma = bf.Deserialize(fs) as String;
            fs.Close();
        }
        private void KH_Load(object sender, EventArgs e)
        {
            docma();
            this._datPhong=new CXuli();
            this._khachhang = new CKhachhang(); 
            this.Text = "Phòng "+this.ma;
        }
        private void Hienthi(DataGridView dgv,CKhachhang ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            dgv.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this._khachhang.Ma = this.ma;
            this._khachhang.Hoten = txtHoten.Text;
            this._khachhang.Ngaysinh = dTpNgaysinh.Value;
            if (rdoNam.Checked == true) this._khachhang.Gioitinh = "Nam";
            else this._khachhang.Gioitinh = "Nữ";
            this._khachhang.Soluong = int.Parse(txtSoluong.Text);
            this._khachhang.ThoiGianVao = dTpBD.Value;
            this._khachhang.ThoiGianRa = dTpKT.Value;
            Hienthi(dGV, this._khachhang);
        }
        private void capnhat()
        {
            DanhSachPhong dsp = new DanhSachPhong();
            dsp.ReadFile(path);
            foreach (Phong p in dsp.DSPhong)
            {
                if (p.MaPhong.Equals(this.ma))
                {
                    p.TinhTrang = "Phòng có khách";
                    break;
                }
            }
            dsp.WriteFile(dsp.DSPhong,path);
        }

        private void btnGhifile_Click(object sender, EventArgs e)
        {
            if (this._datPhong.DocFile(ten) == false)
                MessageBox.Show("Không có thông tin", "Thông báo", MessageBoxButtons.OK);
            this._datPhong.them(this._khachhang);
            if (this._datPhong.GhiFile(ten )==true)
            {
                MessageBox.Show("Đặt phòng thành công! ", "Thông báo", MessageBoxButtons.OK);
                capnhat();
                Close();
            }
            else
            {
                MessageBox.Show("Đặt phòng không thành công", "Thông báo", MessageBoxButtons.OK);  
            }

        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
