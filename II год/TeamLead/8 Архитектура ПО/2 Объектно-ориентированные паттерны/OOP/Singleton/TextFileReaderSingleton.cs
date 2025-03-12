using OOP.Template;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Singleton
{
    public class TextFileReaderSingleton : LogReader
    {
        private static TextFileReaderSingleton instance;
        private string _text;
        
        protected TextFileReaderSingleton(string text)
        {
            _text = text;
        }
        public static TextFileReaderSingleton getInstance(string text)
        {
            if (instance == null)
            {
                instance = new TextFileReaderSingleton(text);
            }
            else
            {
                Console.WriteLine("Экземпляр уже существует, второй создать нельзя");
            }
            return instance;
        }

        public override object GetDataSource()
        {
            return _text;
        }

        public override void SetDataSource(object data)
        {
            _text = data.ToString();
        }

        protected override LogEntry ParseLogEntry(string stringEntry)
        {
            return new LogEntry(stringEntry);
        }

        protected override IEnumerable<string> readEntries(int position)
        {
            List<string> logList = new List<string>();
            int counter = -1;
            using (StreamReader sr = new StreamReader(_text))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    counter++;
                    if (counter >= position)
                    {
                        position = counter;
                        logList.Add(line);
                    }
                    else
                    {
                        continue;
                    }
                }
                sr.Close();
            }
            return logList;
        }
    }
}
