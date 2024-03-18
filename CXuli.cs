using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    [Serializable]
    class CXuli
    {
        List<CKhachhang> dskh;

        public CXuli()
        {
            this.dskh = new List<CKhachhang>();
        }
        public CXuli(List<CKhachhang> dsk)
        {
            this.dskh = dsk;
        }
        public List<CKhachhang> DSKhachHang
        {
            get { return this.dskh; }
            set { this.dskh = value; }
        }

        public CKhachhang timKH(string ma)
        {
            foreach (CKhachhang h in dskh)
                if (h.Ma == ma)
                    return h;
            return null;
        }

        public bool them(CKhachhang kh)
        {
            if (kh == null) return false;
            dskh.Add(kh);
            return true;
        }

        public bool Sua(CKhachhang kh)
        {
            CKhachhang h = timKH(kh.Ma);
            if (kh == null) return false;
            if (h == null) return false;
            else
            {
                kh.Hoten = h.Hoten;
                kh.Ngaysinh = h.Ngaysinh;
                kh.Gioitinh = h.Gioitinh;
                kh.Soluong = h.Soluong;
                kh.ThoiGianRa = h.ThoiGianRa;
                kh.ThoiGianVao = h.ThoiGianVao;
                kh.Ma = h.Ma;
                return true;
            }
        }
        public bool DocFile(String path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            if (fs == null) return false;
            BinaryFormatter bf = new BinaryFormatter();
            this.dskh = bf.Deserialize(fs) as List<CKhachhang>;
            fs.Close();
            return true;
        }
        public bool GhiFile(String path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            if (fs == null) return false;
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this.dskh);
            fs.Close();
            return true;

        }
        public bool Xoa(int vitri)
        {
            dskh.RemoveAt(vitri);
            return true;
        }
        public bool Xoa(CKhachhang kh)
        {
            if (kh == null) return false;
            this.dskh.Remove(kh);
            return true;
        }
    } 
}
