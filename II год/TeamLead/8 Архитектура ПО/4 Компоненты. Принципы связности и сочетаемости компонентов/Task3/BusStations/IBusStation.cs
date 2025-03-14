using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Providers;

namespace Task3.BusStations
{
    internal interface IBusStation
    {
        public abstract bool CheckTicket(string qrCode);
       
    }
}
