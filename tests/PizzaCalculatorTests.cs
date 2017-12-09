using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Pizza.Calculator;
using System.Collections.Generic;

namespace pizza_calculator_tests
{
    [TestClass]
    public class PizzaCalculatorTests
    {
        private Mock<IPizzaRepository> repositoryMock;

        [TestInitialize]
        public void Initialize()
        {
            this.repositoryMock = new Mock<IPizzaRepository>();
            var pizzaStats = new List<PizzaStat>{
                new PizzaStat { PizzaKind = PizzaKind.Regina, AverageSliceCount = 6},
                new PizzaStat { PizzaKind = PizzaKind.Pepperoni, AverageSliceCount = 4},
                new PizzaStat { PizzaKind = PizzaKind.Vegetarian, AverageSliceCount = 7},
            };

            this.repositoryMock.Setup(r => r.GetPizzaStatistics()).Returns(pizzaStats);
        }

        [TestMethod]
        public void When_Requesting_PizzaCount_For_One_Person_Then_PizzaCalculator_Shall_Return_Proper_Pizza_Count()
        {
            var pizzaCalculator = new PizzaCalculator(this.repositoryMock.Object);
            
            int pizzaCount = pizzaCalculator.GetPizzaCount(1, PizzaKind.Regina);
            Assert.AreEqual(1, pizzaCount);
            pizzaCount = pizzaCalculator.GetPizzaCount(1, PizzaKind.Pepperoni);
            Assert.AreEqual(1, pizzaCount);
            pizzaCount = pizzaCalculator.GetPizzaCount(1, PizzaKind.Vegetarian);
            Assert.AreEqual(2, pizzaCount);
        }

        [TestMethod]
        public void When_Requesting_PizzaCount_For_Several_Persons_Then_PizzaCalculator_Shall_Return_Proper_Pizza_Count()
        {
            var pizzaCalculator = new PizzaCalculator(this.repositoryMock.Object);
            
            int pizzaCount = pizzaCalculator.GetPizzaCount(3, PizzaKind.Regina);
            Assert.AreEqual(3, pizzaCount);
            pizzaCount = pizzaCalculator.GetPizzaCount(3, PizzaKind.Pepperoni);
            Assert.AreEqual(2, pizzaCount);
            pizzaCount = pizzaCalculator.GetPizzaCount(3, PizzaKind.Vegetarian);
            Assert.AreEqual(4, pizzaCount);
        }
    }
}
