using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введіть число: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        int result = Fibonacci.getFibonacci(inputNumber);
        Console.WriteLine($"Число Фібоначчі для {inputNumber}: {result} ");
    }
}
public static class Fibonacci
{
    public static int getFibonacci(int number)
    {
        if (number == 0)
        {
            return 0;
        }
        else if (number == 1)
        {
            return 1;
        }
        else
        {
            return getFibonacci(number - 1) + getFibonacci(number - 2);
        }
    }

}