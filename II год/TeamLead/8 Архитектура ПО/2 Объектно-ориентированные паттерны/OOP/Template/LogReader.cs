using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Template
{
    public abstract class LogReader
    {
        private int _currentPosition = 0;
        public int GetCurrentPosition()
        {
            return _currentPosition;
        }

        public void SetCurrentPosition(int currentPosition)
        {
            _currentPosition = currentPosition;
        }

        public IEnumerable<LogEntry> readLogEntry()
        {
            List<LogEntry> logList = new List<LogEntry>();
            foreach (string str in readEntries(_currentPosition))
            {
                logList.Add(ParseLogEntry(str));
            }
            return logList;
        }

        public abstract object GetDataSource();

        public abstract void SetDataSource(object data);

        protected abstract IEnumerable<string> readEntries(int position);

        protected abstract LogEntry ParseLogEntry(string stringEntry);
    }
}
