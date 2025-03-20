using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Models
{
    public class Table
    {
        private static int _counter = 0;
        private readonly int _no;
        private Boolean _isFree = true;
        private readonly Collection<Reservation> _reservations = new Collection<Reservation>();

        public Table()
        {
            _no = ++_counter;
        }

        public Boolean GetIsFree()
        {
            return _isFree;
        }

        public void SetIsFree(bool isFree)
        {
            _isFree = isFree;
        }
        public int GetNo()
        {
            return _no;
        }

        public Collection<Reservation> GetReservations()
        {
            return _reservations;
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, $"Столик #{_no}");
        }
    }
}
