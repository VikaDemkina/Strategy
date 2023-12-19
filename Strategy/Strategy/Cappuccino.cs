public class CappuccinoStrategy : ICoffeeStrategy
{
    public void GrindCoffee()
    {
        Console.WriteLine("Кофе для капучино помолен");
    }

    public void BrewCoffee()
    {
        Console.WriteLine("Кофе для капучино приготовлено");
    }

    public void PourCoffee()
    {
        Console.WriteLine("Кофе для капучино налито в чашку");
    }
}