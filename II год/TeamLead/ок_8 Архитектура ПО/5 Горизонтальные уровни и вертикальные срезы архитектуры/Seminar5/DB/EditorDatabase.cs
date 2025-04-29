using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seminar5.Entities;

namespace Seminar5.DB
{
    internal class EditorDatabase : IDatabase
    {
        private Random random = new Random();
        private readonly ProjectFile _projectFile;

        private Collection<IEntity> _entities;

        public EditorDatabase(ProjectFile projectFile)
        {
            _projectFile = projectFile;
            Load();
        }

        public Collection<IEntity> GetAll()
        {
            if(_entities == null)
            {
                _entities = new Collection<IEntity>();
                
                int entCount = random.Next(5, 7);
                for (int i = 0; i < entCount; i++)
                {
                    GenerateModelAndTextures();
                }

            }
            return _entities;
        }

        private void GenerateModelAndTextures()
        {
            Model3D model3D = new Model3D();
            int txCount = random.Next(3);
            for (int i = 0; i < txCount; i++)
            {
                Texture texture = new Texture();
                model3D.GetTextures().Add(texture);
                _entities.Add(texture);
            }
            _entities.Add(model3D);
        }

        public void Load()
        {

        }

        public void Save()
        {

        }

        public void AddTexture()
        {
            int txCount = random.Next(10);
            for (int i = 0; i < txCount; i++)
            {
                Texture texture = new Texture();
                _entities.Add(texture);
            }
        }

        public void AddModel()
        {
            Model3D model3D = new Model3D();
            int txCount = random.Next(3);
            for (int i = 0; i < txCount; i++)
            {
                Texture texture = new Texture();
                model3D.GetTextures().Add(texture);
                _entities.Add(texture);
            }
            _entities.Add(model3D);
        }

        public void DeleteTexture(int id)
        {
            Collection<IEntity> findEntities = new Collection<IEntity>();
            foreach (IEntity entity in _entities)
            {
                if(entity is Texture && entity.GetId() == id)
                {
                    _entities.Remove(entity);
                    findEntities.Add(entity);
                    break;
                }
                
            }
            if (findEntities == null)
            {
                throw new Exception("Текстура с указанным id не найдена.");
            }
        }

        public void DeleteModel(int id)
        {
            Collection<IEntity> findEntities = new Collection<IEntity>(); 
            foreach (IEntity entity in _entities)
            {
                if (entity is Model3D && entity.GetId() == id)
                {
                    _entities.Remove(entity);
                    break;
                }
            }
            if (findEntities == null)
            {
                throw new Exception("Текстура с указанным id не найдена.");
            }
        }
    }
}
