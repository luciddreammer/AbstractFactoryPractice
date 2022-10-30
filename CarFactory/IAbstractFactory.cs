using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.CarInterfaces;

namespace CarFactory
{
    public interface IAbstractFactory
    {
        IOpel CreateOpel();
        IFiat CreateFiat();
    }
}
