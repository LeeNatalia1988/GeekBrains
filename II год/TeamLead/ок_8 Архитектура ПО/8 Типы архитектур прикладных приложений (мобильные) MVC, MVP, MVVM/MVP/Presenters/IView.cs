using MVP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public interface IView
    {
        abstract void ShowTables(Collection<Table> tables);

        abstract void ShowReservationTableResult(int reservationNo);
        abstract void ReservationTable(DateOnly orderDate, int tableNo, string name);

        abstract void SetObserver(IViewObserver observer);
        abstract void ChangeReservationTable(int oldReservationId, DateOnly reservationDate, int tableNo, string name);
    }
}
