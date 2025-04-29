using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Sample1
{
    public class Bird
    {
        private Boolean _canFly = true;

        public Bird(Boolean canFly)
        {
            this._canFly = canFly;
        }

        public Bird()
        {

        }

        public Boolean IsCanFly()
        {
            return _canFly;
        }

        public void Fly()
        {
            Console.WriteLine("Птица летит");
        }
    }
}
