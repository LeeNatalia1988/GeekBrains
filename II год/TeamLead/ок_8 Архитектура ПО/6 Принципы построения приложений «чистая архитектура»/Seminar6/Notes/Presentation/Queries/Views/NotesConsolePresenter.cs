using Seminar6.Notes.Core.Application.Interfaces;
using Seminar6.Notes.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6.Notes.Presentation.Queries.Views
{
    public class NotesConsolePresenter : INotePresenter
    {
      

        public void PrintAll(Collection<Note> notes)
        {
            foreach (Note note in notes)
            {
                Console.WriteLine(note.ToString());
            }
        }

        
    }
}
