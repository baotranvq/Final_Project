using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projcet1
{
    internal class PRODUCT
    {
        private string ma;
        private string ten;
        private string size;
        private string mau;
        private int sl;
        private double gia;
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Size { get; set; }
        public string Mau { get; set; }
        public int Sl { get; set; }
        public double Gia { get; set; }

        public PRODUCT()
        {

        }
        public PRODUCT(string ma, string ten, string size, string mau, int sl, double gia)
        {
            this.ma = ma;
            this.ten = ten;
            this.size = size;
            this.mau = mau;
            this.sl = sl;
            this.gia = gia;
        }
    }
}
