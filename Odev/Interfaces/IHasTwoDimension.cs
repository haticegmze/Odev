using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Interfaces
{
    public interface IHasTwoDimension:IHasHeight
    {
        double LineA {  get; set; }
        double LineB { get; set; }

    }
}
