using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Providers;

namespace Task3.BusStations
{
    public class BusStation : IBusStation
    {
        private readonly TicketProvider _ticketProvider;
        public BusStation(TicketProvider ticketProvider)
        {
            _ticketProvider = ticketProvider;
        }

        public bool CheckTicket(string qrCode)
        {
            return _ticketProvider.CheckTicket(qrCode);
        }
    }
}
