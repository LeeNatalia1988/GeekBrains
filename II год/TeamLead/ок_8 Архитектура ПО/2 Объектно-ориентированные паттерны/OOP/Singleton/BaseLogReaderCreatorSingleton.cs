using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Factory;
using OOP.Template;

namespace OOP.Singleton
{
    public abstract class BaseLogReaderCreatorSingleton
    {
        public LogReader CreateLogReaderSingleton(LogType logType, string data)
        {
            LogReader logReader = CreateLogReaderInstanceSingleton(logType, data);
            
            return logReader;
        }

        protected abstract LogReader CreateLogReaderInstanceSingleton(LogType logType, string data);
    }
}
