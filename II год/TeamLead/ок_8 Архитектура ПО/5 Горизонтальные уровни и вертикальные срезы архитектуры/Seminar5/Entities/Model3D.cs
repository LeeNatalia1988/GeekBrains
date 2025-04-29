using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar5.Entities
{
    internal class Model3D : IEntity
    {
        private static int _counter = 10000;
        private readonly int _id;

        private Collection<Texture> _textures = new Collection<Texture>();
        public int GetId()
        {
            return _id;
        }

        public Model3D()
        {
            _id = ++_counter;
        }

        public Model3D(Collection<Texture> textures)
        {
            _textures = textures;
            _id = ++_counter;
        }

        public Collection<Texture> GetTextures()
        {
            return _textures;
        }

        public override string ToString()
        {
            return string.Format($"Model #{_id}");
        }
    }
}
