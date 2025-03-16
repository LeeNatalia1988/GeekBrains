using Seminar5.DB;
using Seminar5.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar5.DAL
{
    internal class EditorDatabaseAccess : IDatabaseAccess
    {

        private readonly IDatabase _database;

        public EditorDatabaseAccess(IDatabase editorDatabase)
        {
            this._database = editorDatabase;
        }

        

        public Collection<Model3D> GetAllModels()
        {
            Collection<Model3D> models = new Collection<Model3D>();
            foreach(IEntity entity in _database.GetAll())
            {
                if(entity is Model3D)
                {  
                    models.Add((Model3D)entity);
                }
            }
            return models;
        }

        public Collection<Texture> GetAllTextures()
        {
            Collection<Texture> textures = new Collection<Texture>();
            foreach (IEntity entity in _database.GetAll())
            {
                if (entity is Texture)
                {
                    textures.Add((Texture)entity);
                }
            }
            return textures;
        }

        public void AddModel()
        {
            _database.AddModel();
        }

        public void AddTexture()
        {
            _database.AddTexture();  
        }
        
        public void RemoveModel(int idModel)
        {
            _database.DeleteModel(idModel);
        }

        public void RemoveTexture(int idTexture)
        {
            _database.DeleteTexture(idTexture);
        }


        /*public void AddEntity(IEntity entity)
        {
            _database.GetAll().Add(entity);
        }

        public void RemoveEntity(IEntity entity)
        {
            _database.GetAll().Remove(entity);
        }*/
    }
}
