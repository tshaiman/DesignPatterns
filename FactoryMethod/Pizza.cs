using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        public abstract void prepare();
        public abstract void bake();
        public abstract void cut();
        public abstract void box();

        public abstract string Name { get; set; }
    }

    public class CheezePizza : Pizza
    {
        public override string Name { get; set; }
        public CheezePizza()
        {
            Name = "Cheese";
        }
        public override void bake()
        {
            Console.WriteLine("Baking Cheese Pizza");
        }

        public override void box()
        {
            Console.WriteLine("Boxing Cheese Pizza");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting Cheese Pizza");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing Cheese Pizza");
        }
    }

    public class GreekPizza : Pizza
    {
        public override string Name { get; set; }

        public GreekPizza()
        {
            Name = "Greek";
        }
        public override void bake()
        {
            Console.WriteLine("Baking Greek Pizza");
        }

        public override void box()
        {
            Console.WriteLine("Boxing Greek Pizza");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting Greek Pizza");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing Greek Pizza");
        }
    }

    public class NYCheesePizza : Pizza
    {
        public override string Name { get; set; }

        public NYCheesePizza()
        {
            Name = "NYCheese";
        }
        public override void bake()
        {
            Console.WriteLine("Baking NWCheese Pizza");
        }

        public override void box()
        {
            Console.WriteLine("Boxing NWCheese Pizza");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting NWCheese Pizza");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing NWCheese Pizza");
        }
    }

    public class PepperoniPizza : Pizza
    {
        public override string Name { get; set; }

        public PepperoniPizza()
        {
            Name = "Pepperoni";
        }
        public override void bake()
        {
            Console.WriteLine("Baking Pepperoni Pizza");
        }

        public override void box()
        {
            Console.WriteLine("Boxing Pepperoni Pizza");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting Pepperoni Pizza");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing Pepperoni Pizza");
        }
    }

}
