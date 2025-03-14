using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.DB;

namespace Task3.Providers
{
    public class Customer
    {
        private static int _counter { get; set; }
        private static DataBase _dataBase = new DataBase();
        private readonly int _id = ++_counter;
        private Collection<Ticket> _tickets;

        public Customer(int counter)
        {
            _counter = counter;
            _id = ++_counter;
        }
        public Customer()
        {

        }

        public Collection<Ticket> GetTickets()
        {
            return _dataBase.GetTickets();
            //return _tickets;
        }

        public void SetTickets(Collection<Ticket> tickets)
        {
            _tickets = tickets;
        }

        public int GetId()
        {
            return _id;
        }


    }
}
