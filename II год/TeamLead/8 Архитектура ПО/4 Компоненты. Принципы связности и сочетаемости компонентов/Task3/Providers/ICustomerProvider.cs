using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.DB;

namespace Task3.Providers
{
    internal interface ICustomerProvider
    {

        public abstract Customer GetCustomer(string login, string password);
        
    }
}
