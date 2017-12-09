using System;

namespace Pizza.Calculator.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adaptateur secondaire
            var repositoryAdapter = new RepositoryAdapter();

            // Instanciation de l'hexagone et injection de l'adaptateur secondaire
            var pizzaCalculator = new PizzaCalculator(repositoryAdapter);

            // Adaptateur primaire
            var consoleAdapter = new ConsoleAdapter(pizzaCalculator);

            consoleAdapter.LaunchPizzaCalculation();
        }
    }
}
