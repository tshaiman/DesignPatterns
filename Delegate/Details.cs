using System;

namespace Delegate
{
    public class Details 
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Details(string name,string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }
        public override bool Equals(object obj)
        {
            var other = obj as Details;
            return other!=null && other.Name.Equals(this.Name,StringComparison.InvariantCultureIgnoreCase);
        }
        public override int GetHashCode()
        {
            var hashCode = 31;
            hashCode = hashCode * 19 + Name.GetHashCode();
            hashCode = hashCode * 37 + Phone.GetHashCode();
            return hashCode;
        }
    }

    public class Customer : IPersonalDetails
    {
        public decimal Balance { get; private set; }
        public Details Details { get; set; }

        public Customer(Details personDetails, decimal balance)
        {
            this.Details = personDetails;
            this.Balance = balance;
        }

        public override string ToString()
        {
            return this.GetType().ToString() + " " + Details.Name + "- " + Balance;
        }
    }

    public class Employee : IPersonalDetails
    {
        public decimal Salary { get; private set; }
        public Details Details { get; set; }

        public Employee(Details personDetails, decimal salary)
        {
            this.Details = personDetails;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return this.GetType().ToString() + " " + Details.Name + "- " + Salary;
        }
    }
}


