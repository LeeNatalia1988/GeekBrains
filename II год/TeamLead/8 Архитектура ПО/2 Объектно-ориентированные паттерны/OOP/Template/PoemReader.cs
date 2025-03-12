using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Template
{
    internal class PoemReader : LogReader
    {

        private string _data;

        public PoemReader()
        {

        }
        public PoemReader(string data)
        {
            _data = data;
        }
        public override object GetDataSource()
        {
            return _data;
        }

        public override void SetDataSource(object data)
        {
            _data = data.ToString();
        }

        protected override LogEntry ParseLogEntry(string stringEntry)
        {
            return new LogEntry(stringEntry);
        }

        protected override IEnumerable<string> readEntries(int position)
        {
            List<string> logList = new List<string>();
            int counter = -1;
            using (StreamReader sr = new StreamReader(_data))
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
