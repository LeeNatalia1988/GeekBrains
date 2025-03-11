using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStore3D.InMemoryModel
{
    internal class Observer2 : IModelChangedObserver
    {
        public void applyUpdateModel()
        {
            Console.WriteLine("Была доавлена запись.");
        }
    }
}
