using OOP_principles_2;

class Program
{
    static void Main(string[] args)
    {
        List<MusicalInstrument> instruments = new List<MusicalInstrument>
            {
                new Violin("Скрипка", "Струнний смичковий інструмент з 4 струнами."),
                new Trombone("Тромбон", "Мідний духовий інструмент з висувною кулісою."),
                new Ukulele("Укулеле", "Невеликий гітароподібний інструмент з 4 струнами."),
                new Chelo("Віолончель", "Великий струнний інструмент, який тримають між колінами.")
            };

        foreach (var instrument in instruments)
        {
            Console.WriteLine("=================================");
            instrument.Show();
            instrument.Desc();
            instrument.History();
            instrument.Sound();
            Console.WriteLine();
        }
    }
}