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
    public partial class PhongCoKhach : Form
    {
        public PhongCoKhach()
        {
            InitializeComponent();
        }
        DanhSachPhong dsPhong;
        String path = "danhsachphong.dat";
        String ten = "tam.dat";
       
        private void HienThi(DataGridView dgv,List<Phong> ds)
        {
            BindingSource bs=new BindingSource();
            bs.DataSource = ds;
            dgv.DataSource = bs;
        }
        private void CoKhach()
        {
            List<Phong> ds= new List<Phong>();
            foreach (Phong p in dsPhong.DSPhong)
            {
                if (p.TinhTrang =="Phòng có khách")
                {
                    ds.Add(p);
                }
            }
            HienThi(dgvds, ds);
        }
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Close();
        }
        private int vitri = -1;
        private void dgvds_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvds.Rows[vitri];
                String ma = row.Cells[0].Value.ToString();
                FileStream fs = new FileStream(ten, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ma);
                fs.Close();
                Tra t = new Tra();
                this.Hide();
                t.ShowDialog();
                this.Show();
                dsPhong.ReadFile(path);
                CoKhach();
            }
            catch (Exception) { }
        }

        private void dgvds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
        }

        private void PhongCoKhach_Load_1(object sender, EventArgs e)
        {   
                dsPhong = new DanhSachPhong();
                dsPhong.ReadFile(path);
                CoKhach();
        }
    }
}
