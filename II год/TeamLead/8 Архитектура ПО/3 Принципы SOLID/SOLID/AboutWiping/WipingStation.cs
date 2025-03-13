using SOLID.AboutCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.AboutWiping
{
    internal class WipingStation : IWipingStation
    {
        public void Wiping(WipingType wipingType)
        {
            switch(wipingType)
            {
                case WipingType.Mirrors:
                    Console.WriteLine("Протерли зеркала.");
                    break;
                case WipingType.Windshields:
                    Console.WriteLine("Протерли окна.");
                    break;
                case WipingType.Headlights:
                    Console.WriteLine("Протерли фары");
                    break;
            }
        }
    }
}
