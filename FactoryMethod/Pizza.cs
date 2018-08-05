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
    }

    public class CheezePizza : Pizza
    {
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

    public class PepperoniPizza : Pizza
    {
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
