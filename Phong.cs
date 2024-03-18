using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices.ComTypes;

namespace aa

{
    [Serializable]
    struct S_NoiThat
    {
        private int _ban;
        private int _ghe;
        private int _tivi;
        private int _mayLanh;
        public S_NoiThat(int ban, int ghe, int tivi, int maylanh)
        {
            this._ban = ban;
            this._ghe = ghe;
            this._tivi = tivi;
            this._mayLanh = maylanh;
        }
        public int Ban
        {
            get { return this._ban; }
            set { this._ban = value; }
        }
        public int Ghe
        {
            get { return this._ghe; }
            set { this._ghe = value; }
        }
        public int Tivi
        {
            get { return this._tivi; }
            set { this._tivi = value; }
        }
        public int MayLanh
        {
            get { return this._mayLanh; }
            set { this._mayLanh = value; }
        }

    }
    [Serializable]
    internal class Phong 
    {  
        private S_NoiThat _noiThat;
        private String _maPhong;
        private String _tinhTrang;
        public int _giaTien;
        public Phong()
        {
            this._maPhong = null;
            this._tinhTrang = "";
            this._giaTien = 0;
            this._noiThat.Ban = 0;
            this._noiThat.Ghe = 0;
            this._noiThat.MayLanh = 0;
            this._noiThat.Tivi = 0;
        }
        public Phong(String maphong, int giatien, String tinhtrang, S_NoiThat noithat)
        {
            this._maPhong = maphong;
            this._tinhTrang = tinhtrang;
            this._giaTien = giatien;
            this._noiThat=noithat;
        }
        public String MaPhong
        {
            get { return this._maPhong; }
            set { this._maPhong = value; }
        }
        
        public int GiaTien
        {
            get { return this._giaTien; }
            set { this._giaTien = value; }
        }
        public String TinhTrang
        {
            get { return this._tinhTrang; }
            set { this._tinhTrang = value; }
        }
        public int Ban
        {
            get { return this._noiThat.Ban; }
            set { this._noiThat.Ban = value; }
        }
        public int Ghe
        {
            get { return this._noiThat.Ghe; }
            set { this._noiThat.Ghe = value; }
        }
        public int Tivi
        {
            get { return this._noiThat.Tivi; }
            set { this._noiThat.Tivi = value; }
        }
        public int MayLanh
        {
            get { return this._noiThat.MayLanh; }
            set { this._noiThat.MayLanh = value;}
        }
    }

}