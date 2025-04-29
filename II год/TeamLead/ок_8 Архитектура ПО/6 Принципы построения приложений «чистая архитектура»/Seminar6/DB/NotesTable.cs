using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6.DB
{
    internal class NotesTable
    {
        
        Random random = new Random();
        private Collection<NotesRecord> _records;

        public Collection<NotesRecord> GetRecords() 
        {
            if (_records == null)
            {
                _records = new Collection<NotesRecord>();
                int recordsCount = 5 + random.Next(10);
                for (int i = 0; i < recordsCount; i++)
                {
                    _records.Add(new NotesRecord("title #" + i, "details #" + i));
                }
            }
            return _records; 
        } 
    }
}
