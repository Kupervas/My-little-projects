Console.WriteLine("Введіть число");
string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    Console.WriteLine($"Ваше число {number}");
}
else
{
    Console.WriteLine("Ваше значення не є числом!");
}