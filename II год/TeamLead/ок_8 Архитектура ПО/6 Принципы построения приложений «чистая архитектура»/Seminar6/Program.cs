using Seminar6.DB;
using Seminar6.Notes.Core.Application;
using Seminar6.Notes.Core.Domain;
using Seminar6.Notes.Infrastructure.Persistance;
using Seminar6.Notes.Presentation.Queries.Controllers;
using Seminar6.Notes.Presentation.Queries.Views;

namespace Seminar6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotesController controller = new NotesController(
                new ConcreteNoteEditor(new NotesDbContext(new NotesDatabase()), new NotesConsolePresenter()));
            Boolean f = true;
            while (f)
            {
                Console.WriteLine("*** Мои заметки ***");
                Console.WriteLine("=======================");
                Console.WriteLine("1. Отобразить заметки");
                Console.WriteLine("2. Добавить заметку");
                Console.WriteLine("3. Удалить заметку");
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
                                controller.RouteGetAll();
                                Console.WriteLine("============================");
                                break;
                            case 2:
                                Console.WriteLine("Введите title: ");
                                string title = Console.ReadLine();
                                Console.WriteLine("Введите detailes: ");
                                string detailes = Console.ReadLine();
                                Note note = new Note(new NotesRecord(title, detailes).GetId(), 1, title, detailes, new DateOnly());
                                controller.RouteAddNote(note);
                                break;
                            case 3:
                                Console.WriteLine("Введите Id заметки, которую хотите удалить: ");
                                if (int.TryParse(Console.ReadLine(), out int id) && id > 0)
                                {
                                    controller.RouteRemoveNote(id);
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
