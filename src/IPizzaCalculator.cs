namespace Pizza.Calculator
{
    public interface IPizzaCalculator
    {
         int GetPizzaCount(uint personCount, PizzaKind pizzaKind);
    }

    public enum PizzaKind
    {
        Regina,
        Vegetarian,
        Pepperoni
    }
}