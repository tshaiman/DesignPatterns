using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook pb = new PhoneBook();
            pb.Add(new Employee(new Details("Avi", "03-1234567"), 1000));
            pb.Add(new Customer(new Details("Hana", "03-987564"), -700));
            pb.Add(new Customer(new Details("Ron", "03-135790"), +50));
            pb.Add(new Customer(new Details("Sharon", "03-246800"), 20));
            pb.Add(new Employee(new Details("Avi", "03-1234567"), 5));


            pb.Print();
            Console.Read();
        }
    }
}
