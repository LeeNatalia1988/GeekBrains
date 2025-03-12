using OOP.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Factory
{
    internal class ConcreteReaderCreator : BaseLogReaderCreator
    {
        protected override LogReader CreateLogReaderInstance(LogType logType, string data)
        {
            switch (logType)
            {
                case LogType.Poem: 
                    return new PoemReader(data);
                    
                case LogType.Text:
                    return new TextFileReaderSingleton(data);

                default: break;
            }
            return null;
        }
    }
}
