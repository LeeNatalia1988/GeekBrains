using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Models
{
    public class Reservation
    {
        private static int _counter = 1000;
        private readonly int _id;

        private Table _table { get; }

        private DateOnly _date;
        private string _name;
        

        public Reservation(Table table, DateOnly date, string name)
        {
            _id = ++_counter;
            _date = date;
            _name = name;
            _table = table;
        }

        public int GetId()
        {
            return _id;
        }
        public Table GetTable()
        {
            return _table;
        }
        
        
    }
}
