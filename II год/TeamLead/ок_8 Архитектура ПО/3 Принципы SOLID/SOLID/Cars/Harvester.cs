using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.AboutCars;
using SOLID.AboutMaintenance;
using SOLID.AboutWiping;
using SOLID.Fuel;

namespace SOLID.Cars
{
    public class Harvester : Car, IFueling, IWiping, IMaintenance
    {
        private IRefueling _refueling;
        private IWipingStation _wipingStation;
        private IMaintenanceStation _maintenanceStation;
        public Harvester(string make, string model, Color color, FuelType fuelType, WipingType wipingType) : base(make, model, color, fuelType, wipingType)
        {
            SetWheelsCount(6);
            SetFuelType(FuelType.Diesel);
            SetWippingType(wipingType);
        }

        public void SetRefuelingStation(IRefueling refueling)
        {
            _refueling = refueling;
        }

        public void Fuel()
        {
            if (_refueling != null)
            {
                _refueling.Fuel(_fuelType);
            };
        }

        public void SetWipingStation(IWipingStation wipingStation)
        {
            _wipingStation = wipingStation;
        }

        public void Wiping()
        {
            if (_wipingStation != null)
            {
                _wipingStation.Wiping(_wipingType);
            };
        }

        public void SetMaintenanceStation(IMaintenanceStation maintenanceStation)
        {
            _maintenanceStation = maintenanceStation;
        }

        public void Maintenance(int wheelsCount)
        {
            if (_maintenanceStation != null)
            {
                _maintenanceStation.CalculateMaintenance(_wheelsCount);
            };
        }

        public override bool GearShifting()
        {
            throw new NotImplementedException();
        }

        public override void Maintenance()
        {
            throw new NotImplementedException();
        }

        public override void Movement()
        {
            throw new NotImplementedException();
        }

        public override bool SwitchHeadLights()
        {
            throw new NotImplementedException();
        }

        public override bool SwitchWipers()
        {
            throw new NotImplementedException();
        }

        public void Sweeping()
        {
            Console.WriteLine("Уборщик метет улицу.");
        }






    }
}
