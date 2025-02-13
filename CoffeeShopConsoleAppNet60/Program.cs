using CoffeeShopConsoleAppNet60;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Coffee blackcoffee = new Blackcoffee(discount: 3);
            Coffee latte = new Latte(discount: 5);
            Coffee cortado = new Cortado(discount: 6);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Coffee blackcoffeeValid = new Blackcoffee(discount: 3);
        Coffee latteValid = new Latte(discount: 5);
        Coffee cortadoValid = new Cortado(discount: 2);

        List<Coffee> coffeeDrinks = new List<Coffee>
        {
            blackcoffeeValid,
            latteValid,
            cortadoValid
        };

        foreach (var coffee in coffeeDrinks)
        {
            Console.WriteLine($"{coffee.GetType().Name} - Price: {coffee.Price()} DKK, Strength: {coffee.Strength()}");
        }
    }
}