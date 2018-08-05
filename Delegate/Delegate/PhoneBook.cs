using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class PhoneBook
    {
        List<IPersonalDetails> list;
        List<Details> detailList;
        public PhoneBook()
        {
            list = new List<IPersonalDetails>();
            detailList = new List<Details>();
        }

        public void Add(IPersonalDetails person)
        {
            //1. get the details and compare if exists
            var details = person.Details;
            var personDetails = checkIfExists(details);
            if (personDetails == null)
            {
                detailList.Add(person.Details);
            }
            else
            {
                person.Details = personDetails;
            }

            //add user
            list.Add(person);

        }

        public void Print()
        {
            foreach (IPersonalDetails per in list)

                Console.WriteLine(per.Details.GetHashCode() + ":" + per.ToString());
        }

        private Details checkIfExists(Details detail)
        {
            return detailList.FirstOrDefault(x=> x.Equals(detail));
        }
    }
}
