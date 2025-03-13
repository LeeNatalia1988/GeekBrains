using SOLID.AboutCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.AboutMaintenance
{
    public interface IMaintenanceStation
    {
        public void CalculateMaintenance(int wheelsCount);
       
    }
}
