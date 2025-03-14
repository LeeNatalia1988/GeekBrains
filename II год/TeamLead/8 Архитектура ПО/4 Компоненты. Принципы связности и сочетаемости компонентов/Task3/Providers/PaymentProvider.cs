using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Providers
{
    public class PaymentProvider
    {
        public bool BuyTicket(int orderId, string cardNo, double amount)
        {
            //TODO: Обращение к платежному шлюзу, попытка выполнить списание средств
            return true;
        }
    }
}
