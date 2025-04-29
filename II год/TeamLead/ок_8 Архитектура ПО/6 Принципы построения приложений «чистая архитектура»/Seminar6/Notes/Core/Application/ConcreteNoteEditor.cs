using Microsoft.CodeAnalysis;
using Seminar6.Notes.Core.Application.Interfaces;
using Seminar6.Notes.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6.Notes.Core.Application
{
    internal class ConcreteNoteEditor : INoteEditor
    {

        private readonly INotesDatabaseContext _dbContext;
        private readonly INotePresenter _notesPresenter;

        public ConcreteNoteEditor(INotesDatabaseContext dbContext, INotePresenter notesPresenter)
        {
            _dbContext = dbContext;
            _notesPresenter = notesPresenter;
        }

        public bool AddNote(Note item)
        {
            //_dbContext.GetAll().Add(item);
            _dbContext.AddNote(item);
            return _dbContext.SaveChanges();
        }
        public bool RemoveNote(int id)
        {
            //Note note = _dbContext.GetAll().Where(p => p.GetId() == id).FirstOrDefault();
            //_dbContext.GetAll().Remove(note);
            _dbContext.RemoveNote(id);
            return _dbContext.SaveChanges();
        }

        public bool EditNote(Note item)
        {
            if(item == null)
            {
                return false;
            }
            Optional<Note> note = GetById(item.GetId());
            if (!note.HasValue)
            {
                return false;
            }
            
            
            note.Value.SetTitle(item.GetTitle());
            note.Value.SetDetails(item.GetDetailes());
            note.Value.SetEditDate(new DateOnly());
            return _dbContext.SaveChanges();
        }

        public Collection<Note> GetAll()
        {
            return _dbContext.GetAll();
        }

        public Optional<Note> GetById(int id)
        {
            return _dbContext.GetAll().Where(p => p.GetId() == id).FirstOrDefault();
        }

        public void PrintAll()
        {
            _notesPresenter.PrintAll(GetAll());
        }

        
    }
}
