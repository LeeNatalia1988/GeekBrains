using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.AboutCars
{
    public abstract class Car
    {
        #region Constructors

        public Car(string make, string model, Color color)
        {
            _make = make;
            _model = model;
            _color = color;
        }

        public Car(string make, string model, Color color, FuelType fuelType)
        {
            _make = make;
            _model = model;
            _color = color;
            _fuelType = fuelType;
        }

        public Car(string make, string model, Color color, FuelType fuelType, WipingType wipingType)
        {
            _make = make;
            _model = model;
            _color = color;
            _fuelType = fuelType;
            _wipingType = wipingType;
        }
        #endregion Constructors

        #region Public Methods

        // Движение
        public abstract void Movement();

        // Обслуживание
        public abstract void Maintenance();

        // Переключение передач
        public abstract bool GearShifting();

        // Включение фар
        public abstract bool SwitchHeadLights();

        // Включение дворников
        public abstract bool SwitchWipers();

        // Включение противотуманных фар
        public bool SwitchFogLights()
        {
            _fogLights = !_fogLights;
            return _fogLights;
        }

        // Перевозка груза
        public bool Shipping()
        {
            _shipping = !_shipping;
            return _shipping;
        }

        protected void SetWheelsCount(int wheelsCount)
        {
            _wheelsCount = wheelsCount;
        }

        protected void SetFuelType(FuelType fuelType)
        {
            _fuelType = fuelType;
        }

        protected void SetWippingType(WipingType wippingType)
        {
            _wipingType = wippingType;
        }


        public int GetWheelsCount()
        {
            return _wheelsCount;
        }

        public string GetMake()
        {
            return _make;
        }

        public string GetModel()
        {
            return _model;
        }

        public Color GetColor()
        {
            return _color;
        }

        #endregion Public Methods

        #region Private fields

        // Марка 
        private string _make { get; }

        // Модель
        private string _model { get; }

        // Цвет
        private Color _color { get; }

        // Тип
        private CarType _type;

        // Число колес
        protected int _wheelsCount;

        // Тип оплива
        protected FuelType _fuelType;

        // Тип мойки
        protected WipingType _wipingType;

        // Тип коробки передач
        private GearboxType _gearboxType;

        // Объем двигателя
        private double _engineCapacity;

        // Противотуманные фары
        private bool _fogLights = false;

        // Перевозка груза
        private bool _shipping = false;


        #endregion Private fields


    }
}
