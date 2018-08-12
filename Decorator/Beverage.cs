using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Beverage
    {
        public String Description { get; protected set; }

        public Beverage()
        {
            Description = "Unknown Beverage";
        }

        public abstract double Cost();
    }


    public abstract class BeverageDecorator :Beverage
    {
        protected Beverage beverage { get; set; }
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }


    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }

    public class Mocha : BeverageDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description = this.beverage.Description + " , Mocha";
        }

        public override double Cost()
        {
            return 0.2 + beverage.Cost();
        }
    }


    public class Whip : BeverageDecorator
    {

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            this.Description = beverage.Description + " ,Whip";
        }

        public override double Cost()
        {
            return 0.3 + beverage.Cost();
        }
    }




}
