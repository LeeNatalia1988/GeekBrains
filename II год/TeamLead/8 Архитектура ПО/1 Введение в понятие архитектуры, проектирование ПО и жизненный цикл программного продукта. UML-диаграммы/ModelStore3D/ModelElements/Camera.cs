using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStore3D.ModelElements
{
    internal class Camera
    {
        Point3D Location { get; }
        Angle3D Angle { get; }
        public Camera(Point3D location, Angle3D angle)
        {
            this.Location = location;
            this.Angle = angle;
        }

        public void Rotate(Angle3D angle)
        {
            
        }

        public void Move(Point3D point)
        {
            
        }
    }
}
