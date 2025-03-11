using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStore3D.ModelElements
{
    internal class Type
    {
        //Добавлен для описания методов в Scene, так как в схеме не указан тип
        private string Name { get; set; }
        public Type(string Name)
        {
            this.Name = Name;
        }
    }
}
