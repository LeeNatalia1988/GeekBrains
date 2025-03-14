using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    #region ComponentInfo
    public class ComponentInfo
    {
        private int _id { get; }
        private string _description { get; set; }
        public int GetId()
        {
            return _id;
        }

        public string GetDescription()
        {
            return _description;
        }

        public ComponentInfo(int id, string description)
        {
            this._id = id;
            this._description = description;
        }

        public override string ToString()
        {
            return String.Format($"#{_id} - {_description}");
        }
    }
    #endregion ComponentInfo

    #region FactoryProvider

    public class FactoryProvider
    {
        private Collection<ComponentInfo> _components = new Collection<ComponentInfo>();
        public FactoryProvider()
        {
            {
                for (int i = 0; i < 10; i++)
                {
                    _components.Add(new ComponentInfo(900000 + i, String.Format("component description " + (900000 + i))));
                }

                for (int i = 0; i < 5; i++)
                {
                    _components.Add(new ComponentInfo(1000 + i, String.Format("component description " + (1000 + i))));
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Идентификатор детали</param>
        /// <returns>Информация о детали</returns>
        public ComponentInfo GetComponentInfo(int id)
        {
            // Предусловие

            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Некорректный номер детали");
            }

            if (Convert.ToString(id).Length < 6)
            {
                throw new ArgumentOutOfRangeException("Некорректный номер детали. Деталь существует, но устарела и более не производится.");
            }

            // Выполнение основного кода программы
            ComponentInfo searchComponent = null;

            foreach (ComponentInfo componentInfo in _components)
            {
                if(componentInfo.GetId() == id)
                {
                    searchComponent = componentInfo;
                    break;
                }
            }

            // Постусловие
            if (searchComponent == null)
            {
                throw new InvalidOperationException("Деталь не найдена.");
            }

            return searchComponent;
        }
}

    #endregion FactoryProvider

    #region DealerProvider

    public class DealerProvider
    {
        private readonly FactoryProvider _factoryProvider;

        public DealerProvider(FactoryProvider factoryProvider)
        {
            this._factoryProvider = factoryProvider;
        }

        public ComponentInfo GetComponent(int id)
        {
            // Предусловие...
            //if (id < 0 || Convert.ToString(id).Length < 6)
            //    throw new Exception("Некорректный номер детали");
            //return _factoryProvider.GetComponentInfo(id);

            // Выполнение основного кода подпрограммы
            ComponentInfo componentInfo = _factoryProvider.GetComponentInfo(id);

            // Постусловие
            if (componentInfo == null)
            {
                throw new Exception("Деталь не найдена.");
            }

            return componentInfo;
        }
    }
    #endregion DealerProvider
}
