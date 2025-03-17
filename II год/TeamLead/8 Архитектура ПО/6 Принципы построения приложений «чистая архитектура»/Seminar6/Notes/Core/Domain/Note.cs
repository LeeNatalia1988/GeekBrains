using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6.Notes.Core.Domain
{
    public class Note
    {
        public override string ToString()
        {
            return "Note{" +
                    "id = " + _id +
                    ", title = " + _title + '\'' +
                    ", details = " + _detailes + '\'' +
                    '}';

        }

        #region Constructors

        public Note(int id, int userId, string title, string detailes, DateOnly creationDate)
        {
            _id = id;
            _userId = userId;
            _title = title;
            _detailes = detailes;
            _creationDate = creationDate;
        }

        #endregion

        #region Fields
        private static int counter = 1000;
        private int _id { get; }
        private int _userId { get; }

        private string _title { get; set; }
        private string _detailes { get; set; }
        private DateOnly _creationDate { get; }
        private DateOnly _editDate { get; set; }
        #endregion

        #region Getters
        public int GetId()
        {
            return _id;
        }

        public int GetUserId()
        {
            return _userId;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetDetailes()
        {
            return _detailes;
        }

        public DateOnly GetCreationDate()
        {
            return _creationDate;
        }

        public DateOnly GetEditDate()
        {
            return _editDate;
        }
        #endregion

        #region Setters
        public void SetTitle(string title)
        {
            _title = title;
        }

        public void SetDetails(string details)
        {
            _detailes = details;
        }

        public void SetEditDate(DateOnly editDate)
        {
            _editDate = editDate;
        }
        #endregion
    }
}
