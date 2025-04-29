using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Providers
{
    public interface ITicketProvider
    {
        public abstract Collection<Ticket> SearchTicket(int clientId, DateTime date);


        public abstract bool BuyTicket(int clientId, string cardNo);


        public abstract bool CheckTicket(string qrCode);
       
    }
}
