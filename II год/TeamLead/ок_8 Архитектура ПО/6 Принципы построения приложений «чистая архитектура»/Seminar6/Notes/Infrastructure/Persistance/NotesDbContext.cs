using Microsoft.CodeAnalysis;
using Seminar6.DB;
using Seminar6.Notes.Core.Application.Interfaces;
using Seminar6.Notes.Core.Domain;
using Seminar6.Notes.Infrastructure.Persistance.Configurations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6.Notes.Infrastructure.Persistance
{
    internal class NotesDbContext : DbContext, INotesDatabaseContext
    {
        Collection<Note> notesList = new Collection<Note>();
        public NotesDbContext(IDatabase database) : base(database)
        {
        }

        public bool AddNote(Note item)
        {
            notesList.Add(item);
            return SaveChanges();
        }
        public bool RemoveNote(int id)
        {
            Note temp = new Note(1, 1, "1", "1", new DateOnly());
            foreach (Note note in notesList.Where(i => i.GetId() == id))
            {
                temp = note;
            }
            notesList.Remove(temp);
            return SaveChanges();
        }

        public Collection<Note> GetAll()
        {
            
            //TODO: Этого кастинга быть не должно, тут должен работать внутренний механизм фреймворка
            foreach (NotesRecord record in ((NotesDatabase)_database).GetNotesTable().GetRecords())
            {
                notesList.Add(new Note(
                    record.GetId(),
                    record.GetUserId(),
                    record.GetTitle(),
                    record.GetDetailes(),
                    record.GetCreationDate()
                ));
            }
            return notesList;
        }

        public override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
        }

        
    }
}
