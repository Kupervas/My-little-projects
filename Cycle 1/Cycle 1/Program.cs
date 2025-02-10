
/*Console.WriteLine("Введіть кількість працівників");
int employee = Convert.ToInt32(Console.ReadLine());
int Allsalary = 0;
for (int i = 0; i < employee; i++)
{
    Console.WriteLine($"Введіть зарплату працівника : {i + 1}");
    int salary = Convert.ToInt32(Console.ReadLine());
    Allsalary += salary;
}

 double Avaragesalary = Allsalary / employee;
Console.WriteLine($"Середня зарпалата становить {Avaragesalary}");                                  1 domashka  */




/*Console.WriteLine("Введіть кількість рядків :");
int rows = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < rows; i++) 
{
    Console.WriteLine(new string('*', i));
}                                                                                                      2 domashka */


/*Console.WriteLine("Введіть кінцеве число");
int number =Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < number; i+=2)
{
    Console.WriteLine(i);
}                                                                                                     3 domashka */


/*
using System.ComponentModel.DataAnnotations;
using System.Numerics;

Console.WriteLine("Введіть пароль: ");
string password = Console.ReadLine();

if(Validpassword(password))
{
    Console.WriteLine("Correct password");
}
else
{
    Console.WriteLine("Invalid password, try again....");
}

static bool Validpassword(string password)
{
    if (password.Length < 8)
    {
        return false;
    }
    if (!password.Any(char.IsDigit))
    {
        return false;
    }
    if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
    {
        return false;
    }
    return true;
}                                                                                                      4 domashka*/


/*
using System.ComponentModel.Design;

Console.WriteLine("Введіть кількість чисел Фібоначі");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < number; i++) 
{
    Console.WriteLine(Fibonacci(i) + "");
}
int a = 0;
static int Fibonacci(int a)
{
    if (a <= 1) 
       return a;
    else
    {
        return Fibonacci(a - 1) + Fibonacci(a - 2);
    }
}                                                                                               5 domashka*/


/*
Console.WriteLine("Введіть кількість відпрацьованих годин");
double hours =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введіть оплату за годину");
double wage = Convert.ToDouble(Console.ReadLine());
double paymentforday = hours * wage;
Console.WriteLine($"Ви заробили: {paymentforday} грн. ");
                                                                                                6 domashka*/

/*
Console.WriteLine("Введіть число");
int number =Convert.ToInt32(Console.ReadLine());
for (; ; )
{
    for (int j = 0; j < 11; j++)
    {
        Console.WriteLine($"{j * number}");
    }
    Console.WriteLine( );
    break;
}                                                                                       7 domashka */

/*
Console.WriteLine("Введіть число");
int number =Convert.ToInt32(Console.ReadLine());
if (number %2 == 0)
{
    Console.WriteLine($"Число {number} не є простим"); 
}
else
{
    Console.WriteLine($"Число {number} є простим");
}                                                                                        8 domashka */