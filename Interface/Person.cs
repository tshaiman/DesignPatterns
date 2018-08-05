using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Person
    {
        public Person(String name,String phone)
        {
            Name = name;
            Phone = phone;
        }
        public String Name { get; set; }
        public String Phone { get; set; }

        
    }
}
