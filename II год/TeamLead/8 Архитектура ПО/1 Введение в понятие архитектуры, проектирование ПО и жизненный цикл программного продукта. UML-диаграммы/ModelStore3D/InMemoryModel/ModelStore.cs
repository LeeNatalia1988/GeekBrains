using ModelStore3D.ModelElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStore3D.InMemoryModel
{
    internal class ModelStore: IModelChanger
    {
        private List<PoligonalModel> Models {  get; }
        private List<Scene> Scenes { get; }
        private List<Flash> Flashes { get; }
        private List<Camera> Cameras { get; }
        private readonly List<IModelChangedObserver> _changeObserver = new List<IModelChangedObserver>();

        public ModelStore(List<PoligonalModel> models, List<Scene> scenes, List<Flash> flashes, List<Camera> cameras)
        {
            this.Models = models;
            this.Scenes = scenes;
            this.Cameras = cameras;
            this.Flashes = flashes;
        }

        public int GetScena(Scene scene)
        {
            return scene.GetScenaId(scene);
        }

        public void add(PoligonalModel poligonalModel)
        {
            Models.Add(poligonalModel);
            NotifyChange();
        }

        public void NotifyChange()
        {
            foreach (IModelChangedObserver modelChangedObserver in _changeObserver)
            {
                modelChangedObserver.applyUpdateModel();
            }
        }
    }
}
