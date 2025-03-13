using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class Circle : IShape
    {
        private readonly int _radius;

        public int GetRadius() { 
            return _radius; 
        }

        public double GetArea()
        {
            int radius = GetRadius();
            return Math.PI * Math.Pow(radius, 2);
        }

        public Circle(int radius)
        {
            this._radius = radius;
        }
    }
}
