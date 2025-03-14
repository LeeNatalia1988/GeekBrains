using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Providers
{
    public class Ticket
    {
        private int _id { get; }

        private int _customerId { get; set; }
        private DateTime _date { get; }
        private string _qrCode { get; set; }
        private bool enable = true;

        public Ticket()
        {

        }
        public Ticket(int customerId, string qrCode)
        {
            Random rand = new Random();
            _id = rand.Next(1, 1000);
            _customerId = customerId;
            _date = DateTime.Now;
            _qrCode = qrCode;
        }
        public int GetId()
        {
            return _id;
        }

        public int GetCustomerId()
        {
            return _customerId;
        }
        public DateTime GetDate()
        {
            return _date;
        }
        public string GetQrCode()
        {
            return _qrCode;
        }

        public bool IsEnable()
        {
            return enable;
        }

        public void SetEnable(bool enable)
        {
            this.enable = enable;
        }



    }
}
