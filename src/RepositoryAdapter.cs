using System.Collections.Generic;

namespace Pizza.Calculator.Application
{
    public class RepositoryAdapter : IPizzaRepository
    {
        private readonly List<PizzaStat> pizzaStats = new List<PizzaStat>{
                new PizzaStat { PizzaKind = PizzaKind.Regina, AverageSliceCount = 6},
                new PizzaStat { PizzaKind = PizzaKind.Pepperoni, AverageSliceCount = 4},
                new PizzaStat { PizzaKind = PizzaKind.Vegetarian, AverageSliceCount = 7},
            };

        public IEnumerable<PizzaStat> GetPizzaStatistics()
        {
            return this.pizzaStats;
        }
    }
}