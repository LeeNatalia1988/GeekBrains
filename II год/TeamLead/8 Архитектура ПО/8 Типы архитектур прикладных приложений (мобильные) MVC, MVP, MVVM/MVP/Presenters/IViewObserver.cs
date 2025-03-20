using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVP.Presenters
{
    public interface IViewObserver
    {
        abstract void OnReservationTable(DateOnly orderDate, int tanleNo, string name);
        abstract void ChangeReservationTable(int oldReservationId, DateOnly reservationDate, int tableNo, string name);
    }
}
