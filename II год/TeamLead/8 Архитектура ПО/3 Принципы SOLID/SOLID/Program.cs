using SOLID.AboutMaintenance;
using SOLID.AboutWiping;
using SOLID.Cars;
using SOLID.Fuel;

namespace SOLID
{
    internal class Program
    {

        /**
         * 1. Спроектировать абстрактный класс "Car", у которого должны быть свойства:
         * марка, модель, цвет, тип кузова, число колес, тип топлива, тип коробки передач,
         * объем двигателя; методы: движение, обслуживание, переключение передач, 
         * включение фар, включение дворников.
         * 2. Создать конкретный автомобиль путем наследования класса "Car".
         * 3. Расширить абстрактный класс "Car", добавить метод: подметать улицу. Создать
         * конкретный автомобиль путем наследования класса "Car". Провести проверку принципа 
         * SRP. 
         * 4. Расширить абстрактный класс "Car", добавить метод: включение противотуманных фар,
         * перевозка груза. Провести проверку принципа OCP.
         * 5. Создать конкретный автомобиль путем наследования класса "Car", определить число
         * колес = 3. Провести проверку LSP.
         * 6. Создать конкретный автомобиль путем наследования класса "Car", определить метод 
         * движения - "полет". Провести проверку принципа LSP.
         * 7. Создать интерфейс "Заправочная станция", создать метод: заправка топливом.
         * 8. Имплементировать метод интерфейса "Заправочная станция" в конкретный класс "Car".
         * 
         * 9. Добавить в интерфейс "Заправочная станция" методы: протирка лобового стекла, 
         * протирка фар, протирка зеркал.
         * 10. Имплементровать все методы интерфейса "Заправочная станция" в конкретный класс "Car".
         * Провести проверку принципа ISP. Создать дополнительный\е интерфейс и имплементировать 
         * их в конкретный класс "Car". Провести проверку принципа ISP.
         * 11. Создать путем наследования класса "Car" два автомобиля: с бензиновым и дизельным 
         * двигателями, имплементировать метод "Заправка топливом" интерфейса "Заправочная станция".
         * Реализовать заправку каждого автомобиля подходящим топливом. Провести проверку принципа DIP.
         * 
         */
        static void Main(string[] args)
        {

            Harvester harvester = new Harvester("Уборщик", "Самый главный", System.Drawing.Color.Green, AboutCars.FuelType.Diesel, AboutCars.WipingType.Headlights);
            RefuelingStation refuelingStation = new RefuelingStation();
            WipingStation wipingStation = new WipingStation();
            MaintenanceStation maintenanceStation = new MaintenanceStation();

            harvester.SetRefuelingStation(refuelingStation);
            harvester.SetWipingStation(wipingStation);
            harvester.SetMaintenanceStation(maintenanceStation);

            Console.WriteLine($"Машина: {harvester.GetMake()}, марки: {harvester.GetModel()}, цвета: {harvester.GetColor()} совершает следующие действия: ");
            harvester.Fuel();
            harvester.Wiping();
            harvester.Maintenance(6);

            SportCar sportCar = new SportCar("Гонщик", "Самый быстрый", System.Drawing.Color.Black, AboutCars.FuelType.Gasoline, AboutCars.WipingType.Mirrors);
            
            sportCar.SetRefuelingStation(refuelingStation);
            sportCar.SetWipingStation(wipingStation);
            sportCar.SetMaintenanceStation(maintenanceStation);

            Console.WriteLine($"Машина: {sportCar.GetMake()}, марки: {sportCar.GetModel()}, цвета: {sportCar.GetColor()} совершает следующие действия: ");
            sportCar.Fuel();
            sportCar.Wiping();
            sportCar.Maintenance(6);

        }

       
    }
}
