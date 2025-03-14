using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Providers;

namespace Task3.DB
{
    internal interface IDataBase
    {
        public abstract Collection<Ticket> GetTickets();

        public abstract Collection<Customer> GetCustomers();
        
    }
}
