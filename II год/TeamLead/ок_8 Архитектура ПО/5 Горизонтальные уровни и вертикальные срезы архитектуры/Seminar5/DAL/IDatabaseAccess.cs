using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seminar5.Entities;

namespace Seminar5.DAL
{
    interface IDatabaseAccess
    {
        //abstract void AddEntity(IEntity entity);

        //abstract void RemoveEntity(IEntity entity);
        abstract void AddTexture();
        abstract void RemoveTexture(int id);
        abstract void AddModel();
        abstract void RemoveModel(int id);
        abstract Collection<Texture> GetAllTextures();

        abstract Collection<Model3D> GetAllModels();


    }
}
