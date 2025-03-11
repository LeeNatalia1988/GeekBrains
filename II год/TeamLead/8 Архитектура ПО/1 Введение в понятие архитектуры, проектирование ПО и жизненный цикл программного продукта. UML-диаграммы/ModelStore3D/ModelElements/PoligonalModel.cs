using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStore3D.ModelElements
{
    internal class PoligonalModel
    {
        private List<Poligon> Poligons { get; }
        private List<Texture> Textures { get; }

        public PoligonalModel(List<Poligon> poligons)
        {
            this.Poligons = poligons;
        }

        public PoligonalModel(List<Poligon> poligons, List<Texture> textures)
        {
            this.Poligons = poligons; 
            this.Textures = textures;
        }
    }
}
