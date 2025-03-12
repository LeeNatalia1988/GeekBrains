using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Template;

namespace OOP.Factory
{
    public abstract class BaseLogReaderCreator
    {
        public LogReader CreateLogReader(LogType logType, string data)
        {
            LogReader logReader = CreateLogReaderInstance(logType, data);
            //TODO Выполнение подготовительных действий
            //logReader.SetDataSource(this что нибудь);
            //logReader.SetCurrentPosition(0 что нибудь);
            return logReader;
        }

        protected abstract LogReader CreateLogReaderInstance(LogType logType, string data);
    }
}
