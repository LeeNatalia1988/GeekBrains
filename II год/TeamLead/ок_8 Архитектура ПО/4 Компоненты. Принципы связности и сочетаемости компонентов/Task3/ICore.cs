using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Providers;

namespace Task3
{
    internal interface ICore
    {
        public abstract TicketProvider GetTicketProvider();


        public abstract CustomerProvider GetCustomerProvider();
        
    }
}
