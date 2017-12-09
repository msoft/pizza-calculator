using System;

namespace Pizza.Calculator.Application
{
    public class ConsoleAdapter
    {
        private IPizzaCalculator pizzaCalculator;

        public ConsoleAdapter(IPizzaCalculator pizzaCalculator)
        {
            this.pizzaCalculator = pizzaCalculator;
        }

        public void LaunchPizzaCalculation()
        {
            Console.WriteLine("Entrez le nombre de personnes: ?");
            uint personCount = uint.Parse(Console.ReadLine());

            Console.WriteLine(@"Entrez le type de pizza: 
            1-Vegetarian  
            2-Peperoni
            3-Regina");
            int pizzaKindAsInt = int.Parse(Console.ReadLine());
            PizzaKind pizzaKind;
            switch (pizzaKindAsInt)
            {
                case 1:
                    pizzaKind = PizzaKind.Vegetarian;
                    break;
                case 2:
                    pizzaKind = PizzaKind.Pepperoni;
                    break;
                case 3:
                    pizzaKind = PizzaKind.Regina;
                    break;
                default:
                    throw new InvalidOperationException("Le type de pizza n'a pas été compris");
            }

            int pizzaCount = this.pizzaCalculator.GetPizzaCount(personCount, pizzaKind);

            Console.WriteLine("Il faudra {0} pizza(s).", pizzaCount);
        }
    }
}