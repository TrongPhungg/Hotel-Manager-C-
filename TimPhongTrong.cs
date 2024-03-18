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
    public partial class TimPhongTrong : Form
    {
        public TimPhongTrong()
        {
            InitializeComponent();
        }
        DanhSachPhong dsPhong;
        Phong phong;
        String path = "danhsachphong.dat";
        String temp = "temp.dat";
        private void TimPhongTrong_Load(object sender, EventArgs e)
        {
            dsPhong= new DanhSachPhong();
            if (dsPhong.ReadFile(path) == true)
                HienThiPhongTrong();
            else
                MessageBox.Show("Không có thông tin", "Thông báo", MessageBoxButtons.OK);
            
        }
        private void HienThiDanhSach(DataGridView dgv,List<Phong> ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            dgv.DataSource = bs;
        }
        
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void HienThiPhongTrong()
        {
            List<Phong> ds= new List<Phong>();
            foreach(Phong p in dsPhong.DSPhong)
            {
                if (p.TinhTrang.Equals("Phòng trống"))
                {
                    ds.Add(p);
                }
            }
            HienThiDanhSach(dgvHienThi, ds);
        }
        private int vitri = -1;
        private Phong p = new Phong();


        private void dgvHienThi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vitri = e.RowIndex;
                Phong p = new Phong();
                DataGridViewRow row = dgvHienThi.Rows[vitri];
                p.MaPhong = row.Cells[0].Value.ToString();
                p.GiaTien = int.Parse(row.Cells[1].Value.ToString());
                p.TinhTrang = row.Cells[2].Value.ToString();
                p.Ban = int.Parse(row.Cells[3].Value.ToString());
                p.Ghe = int.Parse(row.Cells[4].Value.ToString());
                p.Tivi = int.Parse(row.Cells[5].Value.ToString());
                p.MayLanh = int.Parse(row.Cells[6].Value.ToString());
            }catch(Exception ex) { }
        }

        private void dgvHienThi_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvHienThi.Rows[vitri];
                String ma = row.Cells[0].Value.ToString();
                FileStream fs = new FileStream(temp, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ma);
                fs.Close();
                Dat k = new Dat();
                this.Hide();
                k.ShowDialog();
                this.Show();
                dsPhong.ReadFile(path);
                HienThiPhongTrong();
            }catch(Exception ex) { }
        }


    }
}
