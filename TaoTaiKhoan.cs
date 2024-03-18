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
    public partial class TaoTaiKhoan : Form
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }
        DSDangNhap ds;
        String path = "login.dat";
        private void btnOK_Click(object sender, EventArgs e)
        {
            String tk = txtTaiKhoan.Text;
            String mk = txtMatKhau.Text;
            String mk1=txtMatKhau1.Text;
            if (ds.KiemTraTrung(tk) == true)
            {
                MessageBox.Show("Đã có tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(tk == string.Empty || mk== string.Empty || mk1==string.Empty)
                MessageBox.Show("Mời bạn nhập dữ liệu ","Thông báo ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {
                if (mk.Equals(mk1))
                {
                    login l = new login(tk, mk);
                    this.ds.Them(l);
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ds.GhiFile(path);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản mật khẩu không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
            
        }

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            ds = new DSDangNhap();
            ds.DocFile(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (login l in this.ds.dsDangNhap)
            {
                if (l.TaiKhoan.Equals(txtTaiKhoan.Text))
                {
                    DialogResult kq = MessageBox.Show("Bạn có muốn xóa tài khoản " + txtTaiKhoan.Text + " không ?", "Thông Báo", MessageBoxButtons.YesNo);
                    if (kq == DialogResult.Yes)
                    {
                        this.ds.Xoa(l);
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                        this.Hide();
                        break;
                    }   
                    else break;
                }
            }
            MessageBox.Show("Không tìm thấy tài khoản " + txtTaiKhoan.Text , "Thông Báo", MessageBoxButtons.YesNo);

            this.ds.GhiFile(path);
        }
    }
}
