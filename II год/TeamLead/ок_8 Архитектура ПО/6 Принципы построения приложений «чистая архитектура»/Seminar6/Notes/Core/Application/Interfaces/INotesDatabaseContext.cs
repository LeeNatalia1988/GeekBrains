using Seminar6.Notes.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6.Notes.Core.Application.Interfaces
{
    internal interface INotesDatabaseContext
    {
        Collection<Note> GetAll();
        Boolean SaveChanges();
        Boolean AddNote(Note item);
        Boolean RemoveNote(int id);

    }
}
