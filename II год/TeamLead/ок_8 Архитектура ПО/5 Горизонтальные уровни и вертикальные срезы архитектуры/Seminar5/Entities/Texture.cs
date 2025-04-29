using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar5.Entities
{
    internal class Texture : IEntity
    {

        private static int _counter = 500000;

        private readonly int _id;
        public int GetId()
        {
            return _id;
        }

        public override string ToString()
        {
            return string.Format($"Texture #{_id}");
        }

        public Texture()
        {
            _id = ++_counter;
        }
    }
}
