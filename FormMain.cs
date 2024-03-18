using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aa
{
    public partial class FormMain : Form
    {
        private DanhSachPhong dsPhong;
        private Phong phong;
        private S_NoiThat noithat;
        String path = "danhsachphong.dat";
        int vitri = -1;
        public FormMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dsPhong=new DanhSachPhong();
            if (dsPhong.ReadFile(path) == true)
            {
                HienThiDanhSach(dgvDSPhong, dsPhong.DSPhong);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK);
            }
            HienThiDanhSach(dgvDSPhong, dsPhong.DSPhong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                String ma = txtMaPhong.Text;
                String tinhtrang = "Phòng trống";
                int gia = int.Parse(txtGiaTien.Text);
                int ban = int.Parse(txtBan.Text);
                int ghe = int.Parse(txtGhe.Text);
                int tivi = int.Parse(txtTivi.Text);
                int maylanh = int.Parse(txtMayLanh.Text);
                S_NoiThat themnoithat = new S_NoiThat(ban, ghe, tivi, maylanh);
                Phong themphong = new Phong(ma, gia, tinhtrang, themnoithat);
                if (dsPhong.KiemTraTrungMa(ma) == true)
                {
                    MessageBox.Show("Phòng này đã có", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaPhong.Focus();
                }
                else
                {
                    dsPhong.them(themphong);
                    HienThiDanhSach(dgvDSPhong, dsPhong.DSPhong);
                }
            }catch(Exception)
            {
                MessageBox.Show("vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void HienThiDanhSach(DataGridView dgv, List<Phong> list)
        {
            BindingSource bs=new BindingSource();
            bs.DataSource = list;
            dgv.DataSource = bs;
        }
        String map = "";
        private void dgvDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vitri = e.RowIndex;
                DataGridViewRow row = dgvDSPhong.Rows[vitri];
                txtGiaTien.Text = row.Cells[1].Value.ToString();
                txtMaPhong.Text = row.Cells[0].Value.ToString();
                txtBan.Text = row.Cells[3].Value.ToString();
                txtGhe.Text = row.Cells[4].Value.ToString();
                txtMayLanh.Text = row.Cells[6].Value.ToString();
                txtTivi.Text = row.Cells[5].Value.ToString();
                vitri = e.RowIndex;
                map = row.Cells[0].Value.ToString(); ;
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập lại","Thông Báo",MessageBoxButtons.OK);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa phòng " + map + " khong?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    dsPhong.xoa(vitri);
                    HienThiDanhSach(dgvDSPhong, dsPhong.DSPhong);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy phòng","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn ghi file ư?", "Thông Báo", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                if (dsPhong.WriteFile(dsPhong.DSPhong, path) == true)
                {
                    MessageBox.Show("Ghi file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("File chưa được ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row= dgvDSPhong.Rows[vitri];
            String maph = row.Cells[0].Value.ToString();
            Phong A = new Phong();
            Phong B = new Phong();
            A.MaPhong = txtMaPhong.Text;
            if (dsPhong.KiemTraTrungMa(maph) == false)
            {
                A.GiaTien = int.Parse(txtGiaTien.Text);
                A.Ban = int.Parse(txtBan.Text);
                A.Ghe = int.Parse(txtGhe.Text);
                A.Tivi = int.Parse(txtTivi.Text);
                A.MayLanh = int.Parse(txtMayLanh.Text);
                foreach (Phong p in dsPhong.DSPhong)
                {
                    if (p.MaPhong.Equals(maph))
                    {
                        B = p;
                        break;
                    }
                }
                DialogResult kq = MessageBox.Show("Bạn có muốn sửa phòng " + maph + " khong?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    dsPhong.sua(A, B);
                    HienThiDanhSach(dgvDSPhong, dsPhong.DSPhong);
                }
            }
            else
            {
                MessageBox.Show("Phòng này đã có", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //   DialogResult kq= MessageBox.Show("Bạn đã ghi file chưa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //   if(kq == DialogResult.Yes)
        //   {
        //        e.Cancel = false;
        //   }
        //    else
        //    {
        //        e.Cancel = true;
        //    }
        //}

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem f=new TimKiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
            dsPhong.ReadFile(path);
            HienThiDanhSach(dgvDSPhong, dsPhong.DSPhong);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe f=new ThongKe();
            f.ShowDialog();
            f.Close();
            this.Show();
        }


        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoTaiKhoan tk = new TaoTaiKhoan();
            this.Hide();
            tk.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }


}
