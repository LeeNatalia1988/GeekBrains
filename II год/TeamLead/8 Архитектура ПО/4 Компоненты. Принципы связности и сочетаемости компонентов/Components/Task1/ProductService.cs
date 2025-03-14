using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Task1
{
    public class ProductService : IReadable
    {
        private Collection<String>? res;
        public void Process1()
        {
            
        }

        public void Process2()
        {
            res?.Clear();
        }

        public Collection<String> ReadTextFile(FileInfo file)
        {
            // Предуспловие: 1-е свойство контракта

            if(file.Exists)
            {
                if(file.Length > 5120)
                {
                    throw new Exception("Размер файла более 5 Мб. Чтение файла запрещено.");
                }
            }
            else
            {
                throw new Exception("Файл не найден.");
            }
            //TODO: Считывание данных
            //TODO: Выполнение основного кода
            // Инвариант - проверка по ходу выполнения основного кода объекта на валидность,
            // вызываются после методов для проверки состояния объекта. Например, что process1 или process2 не res == null
            // проверка ниже - ValidateResult


            #region Работа с данными
            res = new Collection<String>();
            res.Add("AAAAA");
            res.Add("BBBB");

            Process1();
            // Инвариант1
            ValidateResult(res);

            Process2();
            // Инвариант2
            ValidateResult(res);

            #endregion Работа с данными


            // Постусловие: 2-е свойство контракта

            if(res == null)
            {
                throw new Exception("Ошибка обработки данных.");
            }
            //TODO: Возвращаем результат выполнения задачи

            return res;
        }

        private void ValidateResult(Collection<String> res)
        {
            if(res == null || res.Count == 0)
            {
                throw new Exception("Некорректное состояние объекта.");
            }
        }
    }

    /*
     * Позволяет считывать данные*/

    public interface IReadable
    {
        /// <summary>
        /// Считывание и обработка данных
        /// </summary>
        /// <param>file файл</param>
        /// <returns>коллекция данных</returns>
        Collection<string> ReadTextFile(FileInfo file) => throw new Exception();
    }
}
