public class EspressoStrategy : ICoffeeStrategy
{
    public void GrindCoffee()
    {
        Console.WriteLine("Кофе для эспрессо помолен");
    }

    public void BrewCoffee()
    {
        Console.WriteLine("Кофе для эспрессо приготовлено");
    }

    public void PourCoffee()
    {
        Console.WriteLine("Кофе для эспрессо налито в чашку");
    }
}