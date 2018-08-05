using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    public class Device
    {
        private readonly String SerialNumber ;
        private readonly DateTime ManufactureDate;
        

        public double Price { get; set; }

        public Device(string serial,DateTime date,double price)
        {
            this.SerialNumber = serial;
            ManufactureDate = date;
            this.Price = price;
        }

        public Device Discount()
        {
            return new Device(this.SerialNumber, this.ManufactureDate, Price * 0.9);
        }

    }
}
