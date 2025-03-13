using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class Square : IShape
    {
        private readonly int _side;

        public Square(int side)
        {
            this._side = side;
        }

        public double GetArea()
        {
            int side = GetSide();
            return Math.Pow(side, 2);
        }

        public int GetSide()
        {
            return _side;
        }
    }
}
