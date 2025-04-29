using MVP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public class BookingPresenter : IViewObserver
    {
        private readonly IModel _model;
        private readonly IView _view;

        public BookingPresenter(IModel model, IView view)
        {
            _model = model;
            _view = view;
            _view.SetObserver(this);
        }

        public Collection<Table> LoadTables()
        {
            return _model.LoadTables();
        }

        public void UpdateUIShowReservationTableResult(int reservationNo)
        {
            _view.ShowReservationTableResult(reservationNo);
        }

        public void OnReservationTable(DateOnly orderDate, int tableNo, string name)
        {
            int reservationNo = _model.ReservationTable(orderDate, tableNo, name);
            UpdateUIShowReservationTableResult(reservationNo);
        }

        public void UpdateUIShowTables()
        {
            _view.ShowTables(LoadTables());
        }

        public void ChangeReservationTable(int oldReservationId, DateOnly reservationDate, int tableNo, string name)
        {
            int reservationNo = _model.ChangeReservationTable(oldReservationId, reservationDate, tableNo, name);
            UpdateUIShowReservationTableResult(reservationNo);
        }
    }
}
