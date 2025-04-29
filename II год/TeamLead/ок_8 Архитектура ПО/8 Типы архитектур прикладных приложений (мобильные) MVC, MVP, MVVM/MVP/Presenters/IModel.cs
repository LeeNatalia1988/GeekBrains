using MVP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public interface IModel
    {
        abstract Collection<Table> LoadTables();
        abstract int ReservationTable(DateOnly reservationDate, int tableNo, string name);
        abstract int ChangeReservationTable(int oldReservationId, DateOnly reservationDate, int tableNo, string name);
    }
}
