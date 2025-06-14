using BarberShop;
using Threading;

public class Program
{
    public static void Main()
    {
        using var cts = new CancellationTokenSource();
        var barber = new Barber(3, cts.Token);
        var barberThread = new Thread(barber.StartWork);
        barberThread.Start();


        string[] names = { "Іван", "Петро", "Марія", "Олена", "Олександр",
                             "Наталія", "Андрій", "Катерина", "Микола", "Тетяна" };

        for (int i = 0; i < 10; i++)
        {
            if (cts.Token.IsCancellationRequested)
                break;

            var customer = new Customer(i + 1, names[i]);
            if (barber.AddCustomer(customer))
            {
                Console.WriteLine($"Клієнт {customer.Name} зайшов у перукарню");
            }
            else
            {
                Console.WriteLine($"Клієнт {customer.Name} пішов, бо немає вільних місць");
            }
            try
            {
                Thread.Sleep(500);
            }
            catch (ThreadInterruptedException)
            {
                break;
            }
        }

        Console.WriteLine("\nНатисніть Enter для завершення роботи перукарні...");
        Console.ReadLine();

        cts.Cancel();
        barberThread.Interrupt();
        barberThread.Join();

        Console.WriteLine("Перукарня закрита.");
    }
}