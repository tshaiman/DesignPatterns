using System;
using FactoryMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryTests
{
    [TestClass]
    public class FactoryTest
    {

        [TestMethod]
        public void TestCreateGreek()
        {
            CreatePizzaByName("Greek");
        }

        [TestMethod]
        public void TestCreateCheese()
        {
            CreatePizzaByName("Cheese");
        }


        [TestMethod]
        public void TestCreatePepperoni()
        {
            CreatePizzaByName("Pepperoni");
        }

        [TestMethod]
        public void TestCreateNWFactory()
        {
            PizzaStore pz = new PizzaStore(new FakeFactory());
            var pizza = pz.GetPizza("NYCheese");
            Assert.IsNotNull(pizza);
            Assert.AreEqual("NYCheese", pizza.Name);
        }


        private void CreatePizzaByName(string name)
        {
            PizzaStore pz = new PizzaStore(new PizzaFactory());
            var pizza = pz.GetPizza(name);
            Assert.IsNotNull(pizza);
            Assert.AreEqual(name, pizza.Name);
        }
    }

    public class FakeFactory : IPizzaFactory
    {
        public Pizza GetPizza(string name)
        {
            return new CheezePizza();
        }
    }
}
