using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStore3D.InMemoryModel
{
    internal interface IModelChangedObserver
    {
        void applyUpdateModel();
    }
}
