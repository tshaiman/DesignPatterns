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
        protected virtual Pizza CreatePizza(string name)
        {
            //return null; //Greek / Cheese//Pepperoni
            if (name.Equals("Cheese"))
                return new CheezePizza();
            else if (name.Equals("Pepperoni"))
                return new PepperoniPizza();
            else if (name.Equals("Greek"))
                return new GreekPizza();
            return null;
        }


    }

    public class NYPizzaFactory : PizzaFactory
    {

        protected override Pizza CreatePizza(string name)
        {
            //return null; //Greek / Cheese//Pepperoni
            if (name.Equals("NYCheese"))
                return new NYCheesePizza();
            return base.CreatePizza(name);
        }


    }
}
