using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.DB;

namespace Task3.Providers
{
    public class TicketProvider : ITicketProvider
    {
        private DataBase _dataBase;
        private readonly PaymentProvider _paymentProvider;
        public TicketProvider(DataBase dataBase, PaymentProvider paymentProvider)
        {
            _dataBase = dataBase;
            _paymentProvider = paymentProvider;
        }

        public Collection<Ticket> SearchTicket(int clientId, DateTime date)
        {
            Collection<Ticket> tickets = new Collection<Ticket>();
            foreach (Ticket ticket in _dataBase.GetTickets())
            {
                if (ticket.GetCustomerId() == clientId && ticket.GetDate().Equals(date))
                    tickets.Add(ticket);
            }
            return tickets;
        }

        public bool BuyTicket(int clientId, string cardNo)
        {
            int orderId = _dataBase.CreateTicketOrder(clientId);
            double amount = _dataBase.GetTicketAmount();
            return _paymentProvider.BuyTicket(orderId, cardNo, amount);
        }

        public bool CheckTicket(string qrCode)
        {
            foreach (Ticket ticket in _dataBase.GetTickets())
            {
                if (ticket.GetQrCode().Equals(qrCode))
                {
                    ticket.SetEnable(false);
                    //Save DB
                    return true;
                }
            }
            return false;
        }
    }
}
