using System.Collections.Generic;

namespace Pizza.Calculator
{
    public interface IPizzaRepository
    {
         IEnumerable<PizzaStat> GetPizzaStatistics();
    }

    public class PizzaStat
    {
        public PizzaKind PizzaKind { get; set; }
        public int  AverageSliceCount { get; set; }
    }
}