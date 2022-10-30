using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.CarInterfaces;

namespace CarFactory.VanCars
{
    internal class FiatVan : IFiat
    {
        string IFiat.CarDescription()
        {
            return "I'm Fiat van";
        }
    }
}
