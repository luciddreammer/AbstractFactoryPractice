using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.CarInterfaces;

namespace CarFactory
{
    public class FiatSportsCar : IFiat
    {
        public string CarDescription()
        {
            return "I'm Fiat sports car";
        }
    }
}
