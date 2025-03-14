using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Providers;

namespace Task3.DB
{
    public class DataBase : IDataBase
    {
        private static int _counter;
        private Collection<Ticket> _tickets = new Collection<Ticket>();
        private Collection<Customer> _customers = new Collection<Customer>();

        public void SetCustomers()
        {
            _customers.Add(new Customer(1));
            _customers.Add(new Customer(2));
        }

        public void SetTickets()
        {
            _tickets.Add(new Ticket(1, "AAA"));
            _tickets.Add(new Ticket(1, "BBB"));
            _tickets.Add(new Ticket(2, "CCC"));
            _tickets.Add(new Ticket(2, "DDD"));
        }
        public DataBase()
        {
            SetCustomers();
            SetTickets();
        }
        public Collection<Ticket> GetTickets()
        {
            return _tickets;
        }
        public Collection<Customer> GetCustomers()
        {
            return _customers;
        }

        /// <summary>
        /// Получить актуальную стоимость билета
        /// </summary>
        /// <returns></returns>

        public double GetTicketAmount()
        {
            return 45;
        }

        ///Получить идентификатор заявки на покупку билета 
        ///
        public int CreateTicketOrder(int clientId)
        {
            return ++_counter;
        }
    }
}
