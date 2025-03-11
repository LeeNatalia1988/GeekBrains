using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStore3D.ModelElements
{
    internal class Poligon
    {
        private List<Point3D> Points { get; }

        private Poligon (List<Point3D> points)
        {
            this.Points = points;
        }
    }
}
