using Odev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class Square : Shape,IHasTwoDimension
    {
        public double LineA { get; set ; }
        public double LineB { get { return LineA; } set { } }

        public double Height { get { return LineA; } set { } }

        public Square(double Line_A)
        {
            this.LineA = Line_A;
           
        }

        public override double AreaCalculation()
        {
            return LineA * LineB;
        }

        public override double Perimeter()
        {
            return 4 * LineA;
        }
    }
}
