using MVP.Models;
using MVP.Presenters;
using MVP.Views;

namespace MVP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IView view = new BookingView();
            IModel model = new TableModel();
            BookingPresenter presenter = new BookingPresenter(model, view);
            Boolean f = true;
            while (f)
            {
                Console.WriteLine("*** Резервирование столика ***");
                Console.WriteLine("=======================");
                Console.WriteLine("1. Отобразить столики");
                Console.WriteLine("2. Забронировать столик");
                Console.WriteLine("3. Изменить бронь");
                Console.WriteLine("0. Завершение работы приложения");

                Console.WriteLine("Пожалуйста, выберите пункт меню: ");

                if (int.TryParse(Console.ReadLine(), out int no))
                {
                    try
                    {
                        switch (no)
                        {
                            case 0:
                                Console.WriteLine("Завершение работы приложения.");
                                f = false;
                                break;
                            case 1:
                                Console.WriteLine("============================");
                                presenter.UpdateUIShowTables();
                                Console.WriteLine("============================");
                                break;
                            case 2:
                                Console.WriteLine("Введите номер столика: ");
                                if(int.TryParse(Console.ReadLine(), out int noTable))
                                {
                                    Console.WriteLine("Введите ваше имя: ");
                                    string name = Console.ReadLine();
                                    view.ReservationTable(new DateOnly(), noTable, name);
                                }
                                else
                                {
                                    throw new Exception("Вы ввели некорректный номер столика.");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Введите Id брони, которую хотите удалить: ");
                                if (int.TryParse(Console.ReadLine(), out int id) && id > 0)
                                {
                                    Console.WriteLine("Введите номер столика, который хотите забронировать: ");
                                    if (int.TryParse(Console.ReadLine(), out int noNewTable))
                                    {
                                        Console.WriteLine("Введите ваше имя: ");
                                        string name = Console.ReadLine();
                                        view.ChangeReservationTable(id, new DateOnly(), noNewTable, name);
                                    }
                                    else
                                    {
                                        throw new Exception("Вы ввели некорректный номер столика.");
                                    }
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели неверный формат данных, попробуйте еще раз.");
                                }
                                break;
                            default:
                                Console.WriteLine("Укажите корректный номер меню");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Укажите корректный пункт меню");
                    Console.ReadLine();
                }
            }
        }
    }
}
