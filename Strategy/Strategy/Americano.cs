public class AmericanoStrategy : ICoffeeStrategy
{
    public void GrindCoffee()
    {
        Console.WriteLine("Кофе для американо помолен");
    }

    public void BrewCoffee()
    {
        Console.WriteLine("Кофе для американо приготовлено");
    }

    public void PourCoffee()
    {
        Console.WriteLine("Кофе для американо налито в чашку");
    }
}