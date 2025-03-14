using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.DB;
using Task3.Providers;

namespace Task3
{
    public class Core : ICore
    {
        private readonly CustomerProvider _customerProvider;
        private readonly TicketProvider _ticketProvider;
        private readonly PaymentProvider _paymentProvider;
        private readonly DataBase _dataBase;

        public Core()
        {
            _dataBase = new DataBase();
            _customerProvider = new CustomerProvider(_dataBase);
            _paymentProvider = new PaymentProvider();
            _ticketProvider = new TicketProvider(_dataBase, _paymentProvider);
        }

        public TicketProvider GetTicketProvider()
        {
            return _ticketProvider;
        }
        
        public CustomerProvider GetCustomerProvider()
        {
            return _customerProvider;
        }
    }
}
