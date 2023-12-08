using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class Rectangle : Shape
    {
        public string Parameter { get; private set; }}

        public override double AreaCalculation()
        {
            throw new NotImplementedException();
        }

        public override double Perimeter()
        {
            throw new NotImplementedException();
        }

        public override string GetName()
        {
            return "Gamze";
        }
    }
}
