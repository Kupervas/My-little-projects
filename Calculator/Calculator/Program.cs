Console.WriteLine("Введіть перше число");
double num1 = Convert.ToDouble((Console.ReadLine()));
Console.WriteLine("Виберіть опцію + - * /");
char op = Convert.ToChar((Console.ReadLine()));
Console.WriteLine("Введіть друге число");
double num2 = Convert.ToDouble((Console.ReadLine()));
double result = 0;
switch (op)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        if (num2 == 0)
        {
            Console.WriteLine("Ділити на нуль не можна!");
            return;
        }
        result = num1 / num2;
        break;
}
Console.WriteLine($"Відповідь: {result}");