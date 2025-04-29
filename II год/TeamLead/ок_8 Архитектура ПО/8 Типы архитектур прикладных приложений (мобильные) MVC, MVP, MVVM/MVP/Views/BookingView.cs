using MVP.Models;
using MVP.Presenters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views
{
    public class BookingView : IView
    {
        private IViewObserver _observer;
        private IModel _model;

        public void SetObserver(IViewObserver observer)
        {
            _observer = observer;
        }
        public void ShowTables(Collection<Table> tables)
        {
            foreach(Table table in tables)
            {
                Console.WriteLine(table.ToString());
            }
        }

        public void ReservationTable(DateOnly orderDate, int tableNo, string name)
        {
            if(_observer != null)
            {
                _observer.OnReservationTable(orderDate, tableNo, name);
            }
        }

        public void ShowReservationTableResult(int reservationNo)
        {
            if(reservationNo > 0)
            {
                Console.WriteLine($"Столик успешно забронирован. Номер вашей брони: #\n{reservationNo}");
            }
            else
            {
                Console.WriteLine("Что-то пошло не так, попробуйте позже.");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldReserva tionId">старый идентификатор брони</param>
        /// <param name="reservationDate">дата бронирования</param>
        /// <param name="tableNo">номер столика</param>
        public void ChangeReservationTable(int oldReservationId, DateOnly reservationDate, int tableNo, string name)
        {
            _observer.ChangeReservationTable(oldReservationId, reservationDate, tableNo, name);
        }
    }
}
