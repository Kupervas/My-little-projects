int user_write, user_write2;
double result = 0;
Console.WriteLine("Введіть перше число:");
user_write = int.Parse(Console.ReadLine());
do
{
    Console.WriteLine("Введіть друге число:");
    user_write2 = int.Parse(Console.ReadLine());
    if (user_write2 == 0)
        Console.WriteLine("Ділити на нуль не можна, введіть інше число!");
    else
    {
        result = user_write / user_write2;
    }
}

while (user_write2 ==0);
Console.WriteLine($"Результат:{result}");