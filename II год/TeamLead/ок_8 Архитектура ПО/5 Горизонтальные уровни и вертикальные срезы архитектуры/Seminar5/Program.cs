using Seminar5.UI;

namespace Seminar5
{
    internal class Program
    {
        /*
         * Необходимо разделить на горизонтальные уровни "Редактор 3Д графики."
         * Один пользователь. Программа работает на одном компьютере, без выхода в сеть.
         * Что видит пользователь? Как взаимодействует? (Панель загрузки, блок редактирования, блок просмотра).
         * Какие задачи можно делать - функции системы? (Загрузить 3Д модель, рассмотреть 3Д модель, создать новую, 
         * редактировать вершины, текстуры, сделать рендер, сохранить рендер).
         * Какие и где хранятся данные? (файлы 3Д моделей, рендеры, анимация ..., в файловой системе компьютера).
         * 
         * Предложить вариант связывания всех уровней - сценарии использования. 3-4 сценария. 
         * Сквозная функция - создать новую 3Д модель, сделать рендер для печати на принтере.
         */

        static void Main(string[] args)
        {
            Editor3D editor3D = new Editor3D();
            Boolean f = true;
            while (f)
            {
                Console.WriteLine("*** Мой 3D редактор ***");
                Console.WriteLine("=======================");
                Console.WriteLine("1. Открыть проект");
                Console.WriteLine("2. Сохранить проект");
                Console.WriteLine("3. Отобразить параметры проекта");
                Console.WriteLine("4. Отобразить все модели проекта");
                Console.WriteLine("5. Отобразить все текстуры проекта");
                Console.WriteLine("6. Выполнить рендер всех моделей проекта");
                Console.WriteLine("7. Выполнить рендер модели");
                Console.WriteLine("8. Добавить модель");
                Console.WriteLine("9. Удалить модель");
                Console.WriteLine("10. Добавить текстуру");
                Console.WriteLine("11. Удалить текстуру");
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
                                Console.WriteLine("Укажите наименование файла проекта");
                                String fileName = Console.ReadLine();
                                editor3D.OpenProject(fileName);
                                Console.WriteLine("Проект успешно открыт");
                                break;
                            case 2:
                                editor3D.SaveProject();
                                break;
                            case 3:
                                editor3D.ShowProjectSettings();
                                break;
                            case 4:
                                editor3D.PrintAllModels();
                                break;
                            case 5:
                                editor3D.PrintAllTextures();
                                break;
                            case 6:
                                editor3D.RenderAll();
                                break;
                            case 7:
                                Console.WriteLine("Укажите номер модели");
                                if (int.TryParse(Console.ReadLine(), out int noModel))
                                {
                                    editor3D.RenderModel(noModel);
                                }
                                else
                                {
                                    Console.WriteLine("Номер модели указан некорректно");
                                }
                                break;
                            case 8:
                                editor3D.AddModel();
                                Console.WriteLine("Модель успешно создана.");
                                break;
                            case 9:
                                editor3D.RemoveModel();
                                Console.WriteLine("Модель успешно удалена.");
                                break;
                            case 10:
                                editor3D.AddTexture();
                                Console.WriteLine("Текстура успешно создана.");
                                break;
                            case 11:
                                editor3D.RemoveTexture();
                                Console.WriteLine("Текстура успешно удалена.");
                                break;
                            default:
                                Console.WriteLine("Укажите корректный номер меню");
                                break;

                        }


                    }

                    catch (Exception e)
                    {
                        Console.WriteLine($"Error: {e}");
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

