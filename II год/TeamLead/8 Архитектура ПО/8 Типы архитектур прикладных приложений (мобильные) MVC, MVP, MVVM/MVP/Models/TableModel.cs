using MVP.Presenters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Models
{
    public class TableModel : IModel
    {
        private Collection<Table> _tables;
        //private static Reservation _reservation;

        public Collection<Table> LoadTables()
        {
            if (_tables == null)
            {
                _tables = new Collection<Table>();
                _tables.Add(new Table());
                _tables.Add(new Table());
                _tables.Add(new Table());
                _tables.Add(new Table());
                _tables.Add(new Table());
            }
            return _tables;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservationDate"></param>
        /// <param name="tableNo"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int ReservationTable(DateOnly reservationDate, int tableNo, string name)
        {
            foreach (Table table in _tables)
            {
                if (table.GetNo() == tableNo)
                {
                    if (table.GetIsFree() == true)
                    {
                        Reservation reservation = new Reservation(table, reservationDate, name);
                        table.GetReservations().Add(reservation);
                        table.SetIsFree(false);
                        return reservation.GetId();
                    }
                    else
                    {
                        throw new Exception("Столик уже занят.");
                    }
                }

            }
            throw new Exception("Такого столика у нас нет.");
        }

        public int ChangeReservationTable(int oldReservationId, DateOnly reservationDate, int tableNo, string name)
        {
            foreach (Table table in _tables)
            {
                if (table.GetReservations().Count > 0 && table.GetReservations().Last().GetId() == oldReservationId)
                {
                    table.GetReservations().Remove(table.GetReservations().Last());
                    table.SetIsFree(true);
                    ReservationTable(reservationDate, tableNo, name);
                    return _tables[tableNo - 1].GetReservations().Last().GetId();
                }
            }
            return -1;
        }
    }
}
