using Seminar5.DAL;
using Seminar5.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar5.BLL
{
    internal class EditorBusinessLogicalLayer : IBusinessLogicalLayer
    {

        private IDatabaseAccess _databaseAccess;

        private Random _random = new Random();

        public EditorBusinessLogicalLayer(IDatabaseAccess databaseAccess)
        {
            this._databaseAccess = databaseAccess;
        }

        

        public Collection<Model3D> GetAllModels()
        {
            return _databaseAccess.GetAllModels();
        }

        public Collection<Texture> GetAllTextures()
        {
            return _databaseAccess.GetAllTextures();
        }

        public void AddModel()
        {
            _databaseAccess.AddModel();
        }

        public void AddTexture()
        {
            _databaseAccess.AddTexture();
        }
        
        public void RemoveModel(int id)
        {
            _databaseAccess.RemoveModel(id);
        }

        public void RemoveTexture(int id)
        {
            _databaseAccess.RemoveTexture(id);
        }

        public void RenderAllModels()
        {
            foreach(Model3D model in GetAllModels())
            {
                ProcessRender(model);
            }
        }

        public void RenderModel(Model3D model)
        {
            ProcessRender(model);
        }

        private void ProcessRender(Model3D model)
        {
            try
            {
                Thread.Sleep(2500 - _random.Next(2000));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }
    }
}
