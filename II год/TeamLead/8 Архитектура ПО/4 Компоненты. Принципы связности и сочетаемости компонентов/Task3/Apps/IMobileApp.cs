using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Providers;

namespace Task3.Apps
{
    internal interface IMobileApp
    {

        public abstract Collection<Ticket> GetTickets();


        public abstract void SearchTicket(DateTime date);


        public abstract bool BuyTicket(string cardNo);
        
    }
}
