using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.AboutCars
{
    public class FlyCar : Car
    {
        public FlyCar(string make, string model, Color color) : base(make, model, color)
        {
            SetWheelsCount(4);
        }

        public void Fly()
        {
            Console.WriteLine("Автомобиль летит.");
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
            Fly();
        }

        public override bool SwitchHeadLights()
        {
            throw new NotImplementedException();
        }

        public override bool SwitchWipers()
        {
            throw new NotImplementedException();
        }
    }
}
