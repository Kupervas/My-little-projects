Console.WriteLine("Виберіть опцію 1-7");
char op = Convert.ToChar((Console.ReadLine()));
switch (op)
{
    case '1':
        Console.WriteLine("Понеділок");
        break;
    case '2':
        Console.WriteLine("Вівторок");
        break;
    case '3':
        Console.WriteLine("Середа");
        break;
    case '4':
        Console.WriteLine("Четвер");
        break;
    case '5':
        Console.WriteLine("П'ятниця");
        break;
    case '6':
        Console.WriteLine("Субота");
        break;
    case '7':
        Console.WriteLine("Неділя");
        break;
}
