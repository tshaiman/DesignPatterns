using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PizzaStore
    {
        private IPizzaFactory factory;
        public PizzaStore(IPizzaFactory factory)
        {
            this.factory = factory;
        }
        public Pizza GetPizza(string name)
        {
            return factory.GetPizza(name);
        }
    }
}
