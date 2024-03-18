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
    internal class DSDangNhap
    {
        private List<login> ds;
        public DSDangNhap()
        {
            ds = new List<login>();
        }
        public DSDangNhap(List<login> ds)
        {
            this.ds = ds;
        }
        public List<login> dsDangNhap 
        {
            get { return this.ds; }
            set { this.ds = value; }
        }
        public bool Them(login l)
        {
            if (l == null) return false;
            this.ds.Add(l);
            return true;
        }
        public bool Xoa(login l)
        {
            //if (l == null) return false;
            this.ds.Remove(l);
            return true;
        }
        public bool KiemTraTrung(String taikhoan)
        {
            foreach(login l in ds)
            {
                if(l.TaiKhoan.Equals(taikhoan)) return true;
            }
            return false;
        }
        public bool GhiFile(String path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this.dsDangNhap);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DocFile(String path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                this.dsDangNhap = bf.Deserialize(fs) as List<login>;
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
