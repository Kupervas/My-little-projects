using OOP_principles;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Демонстрація роботи програми...");

            Money price = new Money(100, 50);
            Console.WriteLine("Початкова ціна:");
            price.Display();

            Product product = new Product("Смартфон", price);
            Console.WriteLine("\nІнформація про продукт:");
            product.Display();

            Money discount = new Money(20, 75);
            Console.WriteLine($"\nЗнижка: {discount.WholePart}.{discount.FractionPart:D2}");
            product.ReducePrice(discount);

            Console.WriteLine("\nЦіна після знижки:");
            product.Display();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nПомилка: {ex.Message}");
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}