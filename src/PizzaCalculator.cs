using System;
using System.Linq;

namespace Pizza.Calculator
{
    public class PizzaCalculator : IPizzaCalculator
    {
        private const double sliceCountPerPizza = 6;
        private IPizzaRepository pizzaRepository;        

        public PizzaCalculator(IPizzaRepository pizzaRepository)
        {
            this.pizzaRepository = pizzaRepository;
        }

        public int GetPizzaCount(uint personCount, PizzaKind pizzaKind)
        {
            var pizzaStats = this.pizzaRepository.GetPizzaStatistics();
            var foundPizzaStat = pizzaStats.FirstOrDefault(s => s.PizzaKind.Equals(pizzaKind));
            if (foundPizzaStat == null)
            {
                throw new InvalidOperationException("Type de pizza inconnu");
            }

            double pizzaCount = ((double)foundPizzaStat.AverageSliceCount * personCount)/sliceCountPerPizza;
            return (int)Math.Ceiling(pizzaCount);
        }
    }
}