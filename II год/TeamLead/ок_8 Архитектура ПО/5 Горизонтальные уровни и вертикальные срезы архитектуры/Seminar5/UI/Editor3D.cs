using Seminar5.BLL;
using Seminar5.DAL;
using Seminar5.DB;
using Seminar5.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar5.UI
{
    internal class Editor3D : IUILayer
    {

        private ProjectFile _projectFile;
        private IBusinessLogicalLayer _businessLogicalLayer;

        private IDatabaseAccess _databaseAccess;
        private IDatabase _database;

        public Editor3D()
        {
        }

        public Editor3D(IBusinessLogicalLayer businessLogicalLayer)
        {
            _businessLogicalLayer = businessLogicalLayer;
        }

        private void Initialize()
        {
            
            _database = new EditorDatabase(_projectFile);
            _databaseAccess = new EditorDatabaseAccess(_database);
            _businessLogicalLayer = new EditorBusinessLogicalLayer(_databaseAccess);
        }

        private void CheckProjectFile()
        {
            if (_projectFile == null)
            {
                throw new InvalidOperationException("Файл проекта не найден.");
            }
        }
        public void OpenProject(string FileName)
        {
            this._projectFile = new ProjectFile(FileName);
            Initialize();
        }

        public void PrintAllModels()
        {
            CheckProjectFile();

            Collection<Model3D> models = (Collection<Model3D>)_businessLogicalLayer.GetAllModels();
            for (int i = 0; i < models.Count; i++)
            {
                Console.WriteLine($"==={i}===\n");
                Console.WriteLine(models.ElementAt(i));
                foreach (Texture texture in models.ElementAt(i).GetTextures())
                {
                    Console.WriteLine($"  {texture}\n");
                }
            }
        }

        public void PrintAllTextures()
        {
            Collection<Texture> textures = (Collection<Texture>)_businessLogicalLayer.GetAllTextures();
            for (int i = 0; i < textures.Count; i++)
            {
                Console.WriteLine($"==={i}===\n");
                Console.WriteLine(textures.ElementAt(i));
            }
        }

        public void RenderAll()
        {
            CheckProjectFile();
            DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            Console.WriteLine("Подождите...");
            long startTime = (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
            _businessLogicalLayer.RenderAllModels();
            long endTime = (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds - startTime;
            Console.WriteLine($"Операция выполнена за {endTime} мс.\n");
        }

        public void RenderModel(int i)
        {
            CheckProjectFile();

            Collection<Model3D> models = (Collection<Model3D>)_businessLogicalLayer.GetAllModels();
            if (i < 0 || i > models.Count - 1)
            {
                throw new Exception("Номер модели указан некорректно.");
            }
            Console.WriteLine("Подождите...");
            DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long startTime = (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
            _businessLogicalLayer.RenderModel(models.ElementAt(i));
            long endTime = (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds - startTime;
            Console.WriteLine($"Операция выполнена за {endTime} мс.\n");
        }

        public void SaveProject()
        {
            _database.Save();
            Console.WriteLine("Изменения успешно сохранены.");
        }

        public void ShowProjectSettings()
        {
            CheckProjectFile();
            Console.WriteLine("*** Project v1 ***");
            Console.WriteLine("******************");
            Console.WriteLine("filename: ", _projectFile.GetFileName(), "\n");
            Console.WriteLine("setting1: ", _projectFile.GetSetting1(), "\n");
            Console.WriteLine("setting2: ", _projectFile.GetSetting2(), "\n");
            Console.WriteLine("setting3: ", _projectFile.GetSetting3(), "\n");
            Console.WriteLine("******************");
        }

        public void AddTexture()
        {
            _businessLogicalLayer.AddTexture();
        }

        public void AddModel()
        {
            _businessLogicalLayer.AddModel();
        }

        public void RemoveTexture()
        {
            Console.WriteLine("Веедите id текстуры, которую хотите удалить: ");
            if(int.TryParse(Console.ReadLine(), out int no))
            {
                _businessLogicalLayer.RemoveTexture(no);
            }
            else
            {
                throw new NotImplementedException("Вы ввели некорректный id текстуры.");
            }
        }

        public void RemoveModel()
        {
            Console.WriteLine("Веедите id модели, которую хотите удалить: ");
            if (int.TryParse(Console.ReadLine(), out int no))
            {
                _businessLogicalLayer.RemoveModel(no);
            }
            else
            {
                throw new NotImplementedException("Вы ввели некорректный id модели.");
            }
        }
    }
}
