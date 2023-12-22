using Odev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class Triangle : Shape, IHasThreeDimension
    {
      

        
       
        public double LineA { get; set; }
        public double LineB { get; set; }
        public double LineC { get; set; }
        public double Height { get { return LineC; } set { } }

        public Triangle(double Line_A, double Line_B, double Line_C)
        {
            this.LineA = Line_A;
            this.LineB = Line_B;
            this.LineC = Line_C;
        }

        public override double AreaCalculation()
        {
            return 0.5 * Height * LineA;
        }

        public override double Perimeter()
        {
            return LineA + LineB + LineC;
        }
    }
}
