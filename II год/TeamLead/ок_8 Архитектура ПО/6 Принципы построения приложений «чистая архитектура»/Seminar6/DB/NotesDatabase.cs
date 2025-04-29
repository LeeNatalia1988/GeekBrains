using Seminar6.Notes.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6.DB
{
    internal class NotesDatabase : IDatabase
    {
        private NotesTable _notesTable;

        public NotesTable GetNotesTable() 
        {
            if (_notesTable == null)
            {
                _notesTable = new NotesTable();
            }
            return _notesTable;
        }
    }
}
