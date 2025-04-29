
using NPOI.SS.Formula.Functions;
using Seminar6.Notes.Core.Application.Interfaces;
using Seminar6.Notes.Core.Domain;
using Seminar6.Notes.Presentation.Queries.Views;
using Seminar6.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6.Notes.Presentation.Queries.Controllers
{
    public class NotesController : Controller
    {
        private readonly INoteEditor _noteEditor;
        public override IPresenter View(T IPresenter)
        {
            throw new NotImplementedException();
        }

        public NotesController(INoteEditor noteEditor)
        {
            _noteEditor = noteEditor;
        }

        public void RouteAddNote(Note item)
        {
            this._noteEditor.AddNote(item);
        }

        public void RouteRemoveNote(int id)
        {
            this._noteEditor.RemoveNote(id);
        }

        public void RouteGetAll()
        {
            this._noteEditor.PrintAll();
        }
    }
}
