using Seminar6.Notes.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6.Notes.Infrastructure.Persistance.Configurations
{
    internal class NoteConfiguration : IModelConfiguration<Note>
    {
        //TODO: Описываем конкретный маппинг типа Note к объекту БД
        public NoteConfiguration()
        {
        }
    }
}
