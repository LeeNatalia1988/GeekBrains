using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.DB;

namespace Task3.Providers
{
    public class CustomerProvider : ICustomerProvider
    {
        private DataBase _dataBase;
        public CustomerProvider(DataBase dataBase)
        {
            _dataBase = dataBase;
        }

        public Customer GetCustomer(string login, string password)
        {
            return new Customer();
        }
    }
}
