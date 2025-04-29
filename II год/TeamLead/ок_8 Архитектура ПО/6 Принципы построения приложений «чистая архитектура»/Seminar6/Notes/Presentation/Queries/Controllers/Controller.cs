using NPOI.SS.Formula.Functions;
using Seminar6.Notes.Presentation.Queries.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6.Notes.Presentation.Queries.Controllers
{
    public abstract class Controller
    {
        //TODO: не уверена, в семинаре по другому
        public abstract IPresenter View(T IPresenter);
    }
}
