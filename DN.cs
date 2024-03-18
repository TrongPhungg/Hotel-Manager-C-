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
    public partial class DN : Form
    {
        public DN()
        {
            InitializeComponent();
        }
        DSDangNhap ds;
        String path = "login.dat";
        String tk = "";
        private void DN_Load(object sender, EventArgs e)
        {
            ds=new DSDangNhap();
            ds.DocFile(path);
            HienThi(cboTaiKhoan);
        }
        private void HienThi(ComboBox cb)
        {
            List<string> list= new List<string>();
            foreach(login l in this.ds.dsDangNhap)
            {
                list.Add(l.TaiKhoan);
            }
            cb.DataSource = list;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String mk=txtMatKhau.Text;
            FormMain f = new FormMain();
            foreach (login l in ds.dsDangNhap)
            {
                if (l.TaiKhoan.Equals(tk) && l.MatKhau.Equals(mk))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    txtMatKhau.Clear();
                    break;
                }
                
            }
            
            this.Show();    
        }

        private void cboTaiKhoan_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb=sender as ComboBox;
            tk=cb.SelectedValue.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ds.DocFile(path);
            HienThi(cboTaiKhoan);
        }
    }
}
