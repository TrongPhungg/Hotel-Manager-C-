using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    [Serializable]
    class CKhachhang
    {
        String _ma;
        private string m_Hoten;
        private DateTime m_Ngaysinh;
        private String m_Gioitinh;
        private int m_Soluong;
        private DateTime _thoiGianVao;
        private DateTime _thoiGianRa;

        public CKhachhang() 
        {
            this._ma = "";
            this.m_Hoten = "";
            this.m_Ngaysinh = DateTime.Now;
            this.m_Gioitinh = "";
            this.m_Soluong = 0;
            this._thoiGianVao = DateTime.Now;
            this._thoiGianRa = DateTime.Now;
        }

        public CKhachhang(String ma, string hoten, DateTime ngaysinh, String gioitinh, int soluong, DateTime thoiGianVao, DateTime thoigianra)
        {
            this._ma = ma;
            m_Hoten = hoten;
            m_Ngaysinh = ngaysinh;
            m_Gioitinh = gioitinh;
            m_Soluong = soluong;
            this._thoiGianVao = thoiGianVao;
            this._thoiGianVao = thoigianra;
        }
        public String Ma
        {
            get { return this._ma; }
            set { this._ma = value;}
        }
        public DateTime ThoiGianVao
        {
            get { return this._thoiGianVao; }
            set { this._thoiGianVao = value; }
        }
        public DateTime ThoiGianRa
        {
            get { return this._thoiGianRa; }
            set { this._thoiGianRa = value; }
        }

        public string Hoten
        {
            set { m_Hoten = value; }
            get { return m_Hoten; }
        }

        public DateTime Ngaysinh
        {
            set { m_Ngaysinh = value; }
            get { return m_Ngaysinh; }
        }

        public String Gioitinh
        {
            set { m_Gioitinh = value;}
            get { return m_Gioitinh;}
        }

        public int Soluong
        {
            set { m_Soluong = value; }
            get { return m_Soluong; }
        }


    }
}
