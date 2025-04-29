using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seminar5.Entities;

namespace Seminar5.DB
{
    internal interface IDatabase
    {
        abstract void Load();
        abstract void Save();

        Collection<IEntity> GetAll();

        abstract void AddTexture();
        abstract void AddModel();

        abstract void DeleteTexture(int id);
        abstract void DeleteModel(int id);

    }
}
