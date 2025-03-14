using System.Collections.ObjectModel;
using Task3.Apps;
using Task3.Providers;
using Task3.BusStations;
using Task3.DB;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Разработать контракты и компоненты системы "Покупка онлайн билетов на автобус в час пик"
             * 5, 6, 7, 8, 10 - необзательные, опциональные задания.
             * 
             * 1. Предусловия.
             * 2. Постусловия.
             * 3. Инвариант.
             * 4. Определить абстрактные и конкетные классы.
             * 5. Определить интерфейсы.
             * 6. Реализовать наследование.
             * 7. Выявить компоненты.
             * 8. Разработать диаграмму компонент используя нотацию UML 2.0. Общая без деталей.
             * **/

            Core core = new Core();
            MobileApp mobileApp = new MobileApp(core.GetTicketProvider(), core.GetCustomerProvider());
            BusStation busStation = new BusStation(core.GetTicketProvider());
            if (mobileApp.BuyTicket("11000000221"))
            {
                Console.WriteLine("Клиент успешно купил билет.");
                mobileApp.SearchTicket(new DateTime());
                Collection<Ticket> tickets = mobileApp.GetTickets();
                
                if (busStation.CheckTicket(tickets.FirstOrDefault().GetQrCode()))
                {
                    Console.WriteLine("Клиент успешно прошел в автобус.");
                }

            }

        }

    }
}
