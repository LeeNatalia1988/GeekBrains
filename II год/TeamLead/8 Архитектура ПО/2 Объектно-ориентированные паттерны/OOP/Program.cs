using OOP.Factory;
using OOP.Template;
using OOP.Singleton;

namespace OOP
{

    public class Program
    {

        public static string Data = "C:\\GeekBrains\\II год\\TeamLead\\8 Архитектура ПО\\2 Объектно-ориентированные паттерны\\OOP\\Template\\Poem.txt";
        public static string Text = "C:\\GeekBrains\\II год\\TeamLead\\8 Архитектура ПО\\2 Объектно-ориентированные паттерны\\OOP\\Template\\Text.txt";
        public static string TextNew = "C:\\GeekBrains\\II год\\TeamLead\\8 Архитектура ПО\\2 Объектно-ориентированные паттерны\\OOP\\Singleton\\Text.txt";
        public static void Main(string[] args)
        {
            /*Template
             * LogReader logReader = new PoemReader(Data);
            //logReader.SetCurrentPosition(1);
            foreach (LogEntry log in logReader.readLogEntry())
            {
                Console.WriteLine(log.GetText());
            }*/


            /*Factory*/
            LogReader logReader = new ConcreteReaderCreator().CreateLogReader(LogType.Poem, Data);
            foreach (LogEntry log in logReader.readLogEntry())
            {
                Console.WriteLine(log.GetText());
            }

            Console.WriteLine("___________________________________________________________");

            LogReader textReader = new ConcreteReaderCreator().CreateLogReader(LogType.Text, Text);
            foreach (LogEntry log in textReader.readLogEntry())
            {
                Console.WriteLine(log.GetText());
            }
            Console.WriteLine("___________________________________________________________");
            /*Singleton*/
            LogReader textReader1 = new ConcreteReaderCreatorSingleton().CreateLogReaderSingleton(LogType.Text, Text);
            foreach (LogEntry log in textReader1.readLogEntry())
            {
                Console.WriteLine(log.GetText());
            }
            Console.WriteLine("___________________________________________________________");
            LogReader textReader2 = new ConcreteReaderCreatorSingleton().CreateLogReaderSingleton(LogType.Text, TextNew);
            foreach (LogEntry log in textReader2.readLogEntry())
            {
               Console.WriteLine(log.GetText());
            }
        }
    }
}
