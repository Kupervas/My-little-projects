/*int [] MyArray = new int [10];
Random random = new Random ();
for (int i = 0; i < MyArray.Length; i++)
{
    MyArray[i] = random.Next(-10,11);
    Console.WriteLine(MyArray[i]);
}                                                                                            1 dom zavd*/


/* int[] MyArray = new int[10];
Random random = new Random();
int sum = 0;
for (int i = 0; i < MyArray.Length; i++)
{
    MyArray[i] = random.Next(-10, 11);
    Console.WriteLine(MyArray[i]);
    sum += MyArray[i];
}
if (sum >= 0)
{
    Console.WriteLine("Сума не є від'ємною");
}
else
{
    Console.WriteLine("Сума від'ємна");
}
                                                                                                2 dom zavd*/




/* int[,] myArray = new int[9,9];
for (int i = 0; i < 9; i++)
{
   for (int j = 0; j < 9; j++)
   {
       myArray[i,j]= (i+1) * (j+1); 
   }
}
for (int i = 0;i < 9; i++)
{
   for (int j = 0; j < 9; j++)
   {
       Console.Write($"{myArray[i, j], 4}");
   }
   Console.WriteLine( );
}                                                                                                   3 dom zavd    */

/*int[,] myArray = new int[5, 5];
Random random = new Random();
int maxElement = int.MinValue;
int minElement = int.MaxValue;
int maxRow = 0, minRow = 0, maxCol = 0, minCol = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        myArray[i, j] = random.Next(1,50);
        Console.Write($"{myArray[i, j],4}");  
        if (myArray[i, j] > maxElement)
        {
            maxElement = myArray[i, j];
            maxRow = j;
            maxCol = i;
        }
        else if(myArray[i, j] < minElement)
        {
            minElement = myArray[i, j];
            minRow = j; 
            minCol = i;
        }

    }
    Console.WriteLine( );
}
Console.WriteLine($"Максимальне число: {maxElement}");
Console.WriteLine($"Мінімальне число: {minElement}");
Console.WriteLine($"Координати максимального числа {maxRow + 1},{maxCol + 1}");
Console.WriteLine($"Координати мінімального  числа {minRow + 1},{minCol + 1}");
                                                                                                                4 dom zavd*/


enum weekDays
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday,
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть кількість днів");
        int days = Convert.ToInt32(Console.ReadLine());
        weekDays startDay = weekDays.Monday;
        weekDays endDay = (weekDays)((int)(startDay + days % 7) % 7);
        Console.WriteLine($"Через {days} днів буде {endDay}");
    }
}

