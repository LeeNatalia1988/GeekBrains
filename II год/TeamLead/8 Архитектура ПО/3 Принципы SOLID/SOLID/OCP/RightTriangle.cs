using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class RightTriangle : IShape
    {
        private readonly int _katet1;
        private readonly int _katet2;
        private readonly double _gipotenuza;

        public RightTriangle(int katet1, int katet2)
        {
            this._katet1 = katet1;
            this._katet2 = katet2;
            this._gipotenuza = Math.Sqrt((Math.Pow(katet1, 2) + Math.Pow(katet2, 2)));
        }

        public int GetKatet1()
        {
            return _katet1;
        }
        public int GetKatet2()
        {
            return _katet2;
        }

        public double GetGipotenuza()
        {
            return _gipotenuza;
        }

        public double GetArea()
        {
            int katet1 = GetKatet1();
            int katet2 = GetKatet2();
            return katet1 * katet2 / 2;
        }
    }
}
