using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.AboutCars;

namespace SOLID.Fuel
{
    public interface IRefueling
    {
        void Fuel(FuelType fuelType);

    }
}
