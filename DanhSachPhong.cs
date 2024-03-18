using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aa
{
    [Serializable]
    internal class DanhSachPhong
    {
        List<Phong> _dsPhong;

        public DanhSachPhong()
        {
            this._dsPhong = new List<Phong>();
        }
        public DanhSachPhong(List<Phong> dsphong)
        {
            this._dsPhong = dsphong;
        }
        public List<Phong> DSPhong
        {
            get { return this._dsPhong; }
            set { this._dsPhong = value; }
        }
        //kiem tra trung ma
        public bool KiemTraTrungMa(String ma)
        {
            foreach (Phong p in this._dsPhong)
            {
                if (p.MaPhong.Equals(ma))
                {
                    return true;
                }
            }
            return false;
        }
        public void them(Phong themphong)
        {
            this._dsPhong.Add(themphong);
        }
        public bool xoa(int a)
        {
            this._dsPhong.RemoveAt(a);
            return true;
        }
        public bool TraPhong(Phong p)
        {
            p.TinhTrang = "Phòng trống";
            return true;
        }
        public bool sua(Phong A,Phong B)
        {
            B.MaPhong=A.MaPhong;
            B.GiaTien=A.GiaTien;
            B.Ban=A.Ban;
            B.Ghe=A.Ghe;
            B.Tivi=A.Tivi;
            B.MayLanh=A.MayLanh;
            return true;
        }
        public bool ReadFile(String path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            if (fs == null) return false;
            BinaryFormatter bf = new BinaryFormatter();
            this.DSPhong = bf.Deserialize(fs) as List<Phong>;
            fs.Close();
            return true;
        }

        public bool WriteFile(List<Phong> dsphong, String path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            if (fs == null) return false;
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, dsphong);
            fs.Close();
            return true;
        }
        public Phong Tim(String ma)
        {
            Phong phong = new Phong();
            foreach(Phong p in this._dsPhong)
            {
                if (p.MaPhong == ma)
                    return p;
            }
            return null;
        }
       

    }
            
}

