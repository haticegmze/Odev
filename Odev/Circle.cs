using Odev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class Circle : Shape,IHasTwoDimension
    {
        public double LineA { get { return LineB; } set { } }
        public double LineB { get; set; }
        public double Height { get; set; }
        

        public Circle(double Radius)
        {
            this.LineB = Radius;  
        }
        public override double AreaCalculation()
        {
            return Math.PI * LineB * LineB;
         
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * LineB;
        }
    }
}
