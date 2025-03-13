using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.AboutCars;

namespace SOLID.Fuel
{
    public class RefuelingStation : IRefueling
    {
        public void Fuel(FuelType fuelType)
        {
            switch (fuelType)
            {
                case FuelType.Diesel:
                    Console.WriteLine("Заправка дизельным топливом.");
                    break;
                case FuelType.Gasoline:
                    Console.WriteLine("Заправка бензином.");
                    break;
            }
        }
    }
}
