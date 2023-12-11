using Odev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class Rectangle : Shape,IHasTwoDimension
    {
        public double LineA { get; set; }
        public double LineB { get ; set; }
        public double Height { get { return LineA; } set { } }
        public Rectangle(double Line_A, double Line_B)
        {
            this .LineA = Line_A;
            this .LineB = Line_B;
        }
        public override double AreaCalculation()
        {
            return LineA * LineB;
        }

        public override double Perimeter()
        {
            return 2*(LineB + LineA);
        }
    }

       
        
    }

