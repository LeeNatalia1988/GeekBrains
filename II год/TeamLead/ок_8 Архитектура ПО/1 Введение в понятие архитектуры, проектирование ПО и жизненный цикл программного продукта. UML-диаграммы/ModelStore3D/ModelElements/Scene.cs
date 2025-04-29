using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStore3D.ModelElements
{
    internal class Scene
    {
        //Добавила свойство Camera и два конструктора согласно схеме
        private int Id { get; set; }
        private int temp = 0;
        private List<PoligonalModel> Models { get; }
        private List<Flash> Flashes { get; }
        Camera Camera { get; }
        public Scene(List<PoligonalModel> models, Camera camera)
        {
            this.Models = models;
            this.Camera = camera;
            temp += 1;
            this.Id = temp;
        }
        public Scene(List<PoligonalModel> models, Camera camera, List<Flash> flashes) 
        { 
            this.Models = models;
            this.Camera = camera;
            this.Flashes = flashes;
            temp += 1;
            this.Id = temp;
        }
        Type Method1 (Type type)
        {
            return type;
        }
        Type Method2 (Type type1, Type type2)
        {
            return type1;
        }

        public int GetScenaId(Scene scene)
        {
            return scene.Id;
        }
    }
}
