using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.CarInterfaces;

namespace CarFactory.VanCars
{
    internal class OpelVan : IOpel
    {
        string IOpel.CarDescription()
        {
            return "I'm Opel van";
        }
    }
}
