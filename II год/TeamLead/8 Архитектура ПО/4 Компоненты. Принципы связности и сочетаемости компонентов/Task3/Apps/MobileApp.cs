using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Providers;

namespace Task3.Apps
{
    public class MobileApp : IMobileApp
    {
        private readonly Customer _customer;
        private readonly TicketProvider _ticketProvider;
        private readonly CustomerProvider _customerProvider;

        public MobileApp(TicketProvider ticketProvider, CustomerProvider customerProvider)
        {
            _ticketProvider = ticketProvider;
            _customerProvider = customerProvider;
            _customer = _customerProvider.GetCustomer("<login>", "<password>");
        }

        public Collection<Ticket> GetTickets()
        {
            return _customer.GetTickets();
        }

        public void SearchTicket(DateTime date)
        {
            _customer.SetTickets(_ticketProvider.SearchTicket(_customer.GetId(), new DateTime()));
        }

        public bool BuyTicket(string cardNo)
        {
            return _ticketProvider.BuyTicket(_customer.GetId(), cardNo);
        }
    }
}
