using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage houseBlend = new HouseBlend();
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);

            Console.WriteLine(houseBlend.Description + " : Cost " + houseBlend.Cost());
        }
    }
}
