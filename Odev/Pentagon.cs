using Odev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class Pentagon : Shape, IHasTwoDimension
    {
        public double LineA { get; set; }
        public double LineB { get { return LineA; } set { } }
        public double Height { get; set; }
        public double Radius { get { return Height; }  set { } }
        // RADİUS DİYE TANIMLADIĞIM YARIÇAP, BEŞGENİN İÇİNE ÇİZİLEN İÇ TEĞET ÇEMBERİN MERKEZDEN DİK İNDİRİLEN UZUNLUĞUDUR.

        public Pentagon(double _LineA, double Radius)
        {
            this.LineA = _LineA;
            this.Height = Radius;
        }
        public override double AreaCalculation()
        {

            return 5 * (Radius * LineA / 2);
        }

        public override double Perimeter()
        {
            return LineA * 5;
        }
    }
}
