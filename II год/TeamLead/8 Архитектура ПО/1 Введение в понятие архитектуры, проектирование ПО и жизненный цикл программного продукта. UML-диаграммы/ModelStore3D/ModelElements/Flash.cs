using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStore3D.ModelElements
{
    internal class Flash
    {
        Point3D Location { get; }
        Angle3D Angle { get; }
        Color Color { get; }
        private float Power { get; set; }

        public Flash(Point3D location, Angle3D angle, Color color, float power)
        {
            this.Location = location;
            this.Angle = angle;
            this.Color = color;
            this.Power = power;
        }

        public void Rotate(Angle3D angle)
        {
            
        }

        public void Move(Point3D point)
        {
            
        }



    }
}
