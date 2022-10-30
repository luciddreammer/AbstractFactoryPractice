using CarFactory.CarInterfaces;
using CarFactory.VanCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Factories
{
    public class VanFactory : IAbstractFactory
    {
        public IFiat CreateFiat()
        {
            return new FiatVan();
        }

        public IOpel CreateOpel()
        {
            return new OpelVan();
        }
    }
}
