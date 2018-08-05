using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    delegate bool FilterFunc(Person p);
    class Program
    {
        
        public static void Main(string[] args)
        {
            PhoneBook pb = new PhoneBook();

            pb.Add(new Person("Hana", "03-987564"));
            pb.Add(new Person("Avi", "03-1234567"));
            pb.Add(new Person("Ron", "03-135790"));
            pb.Add(new Person("Sharon", "03-246800"));
            pb.Add(new Person("arnon", "06-666800"));
            pb.Print(Utils.IsMatch);
            //pb.Print(new PhoneBook.FilterHandler(match));
            //pb.Print(match);

            //pb.Print((p) => p.Name.StartsWith("A",StringComparison.OrdinalIgnoreCase));

            pb.Print(x => x.Phone.StartsWith("06"));
            Console.Read();
        }


       
    }
}
