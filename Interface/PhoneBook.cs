using System;
using System.Collections.Generic;
using Interface;

namespace Interface
{
    public class PhoneBook
    {
        public List<Person> persons = new List<Person>();
        public delegate bool FilterHandler(Person p);

        public void Add(Person p)
        {
            persons.Add(p);
        }

        internal void Print(FilterFunc filter)
        {
            foreach(var p in persons)
            {
                if(filter(p))
                    Console.WriteLine($"Name = {p.Name} , Phone {p.Phone}");
            }
        }

        internal void Print2()
        {
            foreach (var p in persons)
            {
                if (p.IsMatch())
                    Console.WriteLine($"Name = {p.Name} , Phone {p.Phone}");
            }
        }

    }
}
