using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    [Serializable]
    internal class DSDoanhThu
    {
        List<DoanhThu> _ds;
        public DSDoanhThu()
        {
            this._ds = new List<DoanhThu>();
        }
        public DSDoanhThu (List<DoanhThu> ds)
        {
            this._ds = ds;
        }  
        public List<DoanhThu> DanhSachDoanhThu
        {
            get { return this._ds; }
            set { this._ds = value; }
        }
        public bool Them(DoanhThu thu)
        {
            if (thu == null) return false;
            this._ds.Add(thu);
            return true;
        }
        private bool KiemTraMa(String ma)
        {
            DanhSachPhong ds = new DanhSachPhong();
            ds.ReadFile("danhsachphong.dat");
            foreach (Phong p in ds.DSPhong)
            {
                if (p.MaPhong.Equals(ma))
                    return true;
            }
            return false;
        }
        public double TongDoanhThu1Phong(String ma)
        {
            if (ma == null) return 0;
            if (KiemTraMa(ma) == false) return 0; 
            double tong = 0;
            foreach(DoanhThu t in this._ds)
            {
                if (t.Ma.Equals(ma))
                {
                    tong += t.Tien;
                }
            }
            return tong;
        }

        public double TongDoanhThu()
        {
            
            
            double tong = 0;
            foreach (DoanhThu t in this._ds)
            {
                
                    tong += t.Tien;
                
            }
            return tong;
        }
        public String Max()
        {
            DanhSachPhong dsp=new DanhSachPhong();
            dsp.ReadFile("danhsachphong.dat");
            String a="";
            double max = 0;
            foreach(Phong p in dsp.DSPhong)
            {
                if (TongDoanhThu1Phong(p.MaPhong) > max)
                {
                    max = TongDoanhThu1Phong(p.MaPhong);
                    a = p.MaPhong;
                }
            }
            return a;
        }
        public bool GhiFile(String path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this.DanhSachDoanhThu);
            fs.Close();
            return true;
        }
        public bool DocFile(String path)
        {
            FileStream fs =new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            this.DanhSachDoanhThu=bf.Deserialize(fs) as List<DoanhThu>;
            fs.Close();
            return true;
        }
    }
}
