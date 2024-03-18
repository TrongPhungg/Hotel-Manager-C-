using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    [Serializable]
    internal class DoanhThu
    {
        private String _ma;
        private int _soNgay;
        private double _tien;
        public DoanhThu()
        {
            this._ma = "";
            this._soNgay = 0;
            this._tien = 0;
        }
        public DoanhThu(string ma, int soNgay, double tien)
        {
            this._ma = ma;
            this._soNgay = soNgay;
            this._tien = tien;
        }
        public String Ma
        {
            get { return this._ma; }
            set { this._ma = value; }
        }
        public int SoNgay
        {
            get { return this._soNgay; }
            set { this._tien = value; }
        }
        public double Tien
        {
            get { return this._tien; }
            set { this.Tien = value; }
        }
    }
}
