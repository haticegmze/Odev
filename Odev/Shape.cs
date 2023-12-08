using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public int LineA { get; set; }


        public abstract double AreaCalculation();
        public abstract double Perimeter();
        public virtual string GetName()
        {
            return Name;
        }
        
        // test yorum satırı
    }
}
