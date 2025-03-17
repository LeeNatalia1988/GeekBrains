using NPOI.SS.Formula.Functions;
using Seminar6.Notes.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6.Notes.Core.Application.Interfaces
{
    public interface INoteEditor : IEditor<Note, int>
    {
        void PrintAll();
        Boolean AddNote(Note note);
        Boolean EditNote(Note note);
        Boolean RemoveNote(int id);
    }
}
