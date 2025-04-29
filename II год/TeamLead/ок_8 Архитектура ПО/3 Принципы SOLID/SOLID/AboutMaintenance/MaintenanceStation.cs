using SOLID.AboutCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.AboutMaintenance
{
    public class MaintenanceStation : IMaintenanceStation
    {
        public void CalculateMaintenance(int wheelsCount)
        {
            if (wheelsCount == 6)
            {
                Console.WriteLine("Стоимость замены колес составляет: " + 1500 * 6);
            }
            else
            {
                Console.WriteLine("Стоимость замены колес составляет: " + 1000 * 4);
            }
        }
    }
}
