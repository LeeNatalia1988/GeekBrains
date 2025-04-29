using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seminar5.Entities;

namespace Seminar5.BLL
{
    internal interface IBusinessLogicalLayer
    {
        Collection<Model3D> GetAllModels();
        Collection<Texture> GetAllTextures();

        abstract void RenderModel(Model3D model);
        abstract void RenderAllModels();
        abstract void AddTexture();
        abstract void RemoveTexture(int id);
        abstract void AddModel();
        abstract void RemoveModel(int id);

    }
}
