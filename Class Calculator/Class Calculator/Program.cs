using Class_Calculator;
using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Введіть перше число");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть операцію: +, -, *, / ");
        char operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Введіть друге число");
        double y = Convert.ToDouble(Console.ReadLine());
        double result = 0;
        try
        {
            switch (operation)
            {
                case '+':
                    result = calc.Add(x, y);
                    break;
                case '-':
                    result = calc.Substract(x, y);
                    break;
                case '*':
                    result = calc.Multiply(x, y);
                    break;
                case '/':
                    result = calc.Divide(x, y);
                    break;
            }
            Console.WriteLine($"Результат: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }

    }
}