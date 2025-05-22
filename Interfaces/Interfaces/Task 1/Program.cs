using Interfaces;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 24, 3, 18, 5 };
        MyArray myArray = new MyArray(numbers);

        myArray.Show();

        myArray.Show("Just a messagge");


        Console.WriteLine($"Max value: {myArray.Max()}");
        Console.WriteLine($"Min value: {myArray.Min()}");
        Console.WriteLine($"Average value: {myArray.Avg()}");
        Console.WriteLine($"Search 3: {myArray.Search(3)}");
        Console.WriteLine($"Search 11: {myArray.Search(11)}");
        Console.WriteLine();
        Console.WriteLine("Початковий масив");
        myArray.Show();

        myArray.SortAsc();
        Console.WriteLine("Масив за зростанням");
        myArray.Show();

        myArray.SortDesc();
        Console.WriteLine("Масив за спаданням");
        myArray.Show();

        Console.WriteLine();
        myArray.SortByParam(true);
        myArray.Show();

        Console.WriteLine();
        myArray.SortByParam(false);
        myArray.Show();
    }

}