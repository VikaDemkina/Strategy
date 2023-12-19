// Контекст, который использует стратегию приготовления кофе
public class CoffeeShop
{
    private ICoffeeStrategy coffeeStrategy;

    public void SetCoffeeStrategy(ICoffeeStrategy strategy)
    {
        coffeeStrategy = strategy;
    }

    public void PrepareCoffee()
    {
        coffeeStrategy.GrindCoffee();
        coffeeStrategy.BrewCoffee();
        coffeeStrategy.PourCoffee();
        Console.WriteLine("Кофе готово!\n");
    }
}