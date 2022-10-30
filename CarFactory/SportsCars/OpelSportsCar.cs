using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.CarInterfaces;

namespace CarFactory.SportsCars
{
    public class OpelSportsCar : IOpel
    {
        public string CarDescription()
        {
            return "I'm Opel sports car";
        }
    }
}
