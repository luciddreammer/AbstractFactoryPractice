using CarFactory.CarInterfaces;
using CarFactory.SportsCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Factories
{
    public class SportsCarFactory : IAbstractFactory
    {
        public IFiat CreateFiat()
        {
            return new FiatSportsCar();
        }

        public IOpel CreateOpel()
        {
            return new OpelSportsCar();
        }
    }
}
