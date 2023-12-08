using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class Circle : Shape
    {
        public double Pi
        {
            get { return Math.PI; }
        }


        //public double Radius { get; set; }

        //public double AreaCalculation()
        //{
        //    return Math.PI * Radius * Radius;
        //}

        //public double Perimeter()
        //{
        //    return 2 * Math.PI * Radius;
        //}
        public override double AreaCalculation()
        {
            throw new NotImplementedException();
        }

        public override double Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
