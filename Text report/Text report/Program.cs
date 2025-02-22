using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder report = new StringBuilder();

        Console.WriteLine("Enter a title");
        string title = Console.ReadLine();

        report.AppendLine($"Звіт: {title}");
        report.AppendLine($"Дата {DateTime.Now:dd.MM.yyyy}");
        report.AppendLine(new string ('*', 25));

        Console.WriteLine("Введіть подію");
        int eventCount = 1;
        while(true)
        {
        Console.WriteLine($"Подія {eventCount}");
        string eventDesc = Console.ReadLine();
            if (string.IsNullOrEmpty(eventDesc))
            {
                break;
            }
            report.AppendLine($"{eventCount}.  {eventDesc}");
        eventCount++;
        }
        report.AppendLine(new string('*', 25));
        Console.WriteLine("Згенерований звіт: ");
        Console.WriteLine(report.ToString());
        

    }
}