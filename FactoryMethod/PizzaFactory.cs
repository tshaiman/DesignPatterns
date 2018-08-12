using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IPizzaFactory
    {
        Pizza GetPizza(string name);
    }

    public class PizzaFactory : IPizzaFactory
    {
        public Pizza GetPizza(string name)
        {
            var pizza = CreatePizza(name);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        protected Dictionary<String, Func<Pizza>> _factories;

        public PizzaFactory()
        {
            _factories = new Dictionary<string, Func<Pizza>>();
            _factories.Add("Cheese", () => new CheezePizza());
            _factories.Add("Pepperoni", () => new PepperoniPizza());
            _factories.Add("Greek", () => new GreekPizza());

        }
        protected virtual Pizza CreatePizza(string name)
        {
            try
            {
                return _factories[name]();
            }
            catch(Exception e)
            {
                return null;
            }
        }
        
    }

    public class NYPizzaFactory : PizzaFactory
    {
        public NYPizzaFactory()
        {
            _factories.Add("NYCheese", () => new NYCheesePizza());
        }
    }
}
