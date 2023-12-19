class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляра кофейни
        CoffeeShop coffeeShop = new CoffeeShop();

        // Установка стратегии приготовления эспрессо
        coffeeShop.SetCoffeeStrategy(new EspressoStrategy());

        // Приготовление эспрессо
        coffeeShop.PrepareCoffee();

        // Установка стратегии приготовления капучино
        coffeeShop.SetCoffeeStrategy(new CappuccinoStrategy());

        // Приготовление капучино
        coffeeShop.PrepareCoffee();

        // Установка стратегии приготовления американо
        coffeeShop.SetCoffeeStrategy(new AmericanoStrategy());

        // Приготовление американо
        coffeeShop.PrepareCoffee();


    }
}