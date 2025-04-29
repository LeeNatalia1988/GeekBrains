using OOP.Factory;
using OOP.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Singleton
{
    internal class ConcreteReaderCreatorSingleton : BaseLogReaderCreatorSingleton
    {
        protected override LogReader CreateLogReaderInstanceSingleton(LogType logType, string data)
        {
            switch (logType)
            {
                case LogType.Poem: 
                    return new PoemReader(data);
                    
                case LogType.Text:
                    return TextFileReaderSingleton.getInstance(data);

                default:
                    return null;
            }
        }
    }
}
