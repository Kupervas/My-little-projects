using System.Diagnostics.Tracing;
int triesCount = 7;
char userInput;
string correctword = "сонце";
bool iswordGuessed = false;
char[] guessedWord = new string('_', correctword.Length).ToCharArray();


Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");
Console.WriteLine($"Кількість літер у слові:{correctword.Length}");
Console.WriteLine($"Кількість можливих невірних спроб:{triesCount}");

while (triesCount > 0 && !iswordGuessed)
{
    Console.WriteLine("Ваша відповідь :");
    userInput = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (correctword.Contains(userInput))
    {
        Console.WriteLine("Правильно, ця літера є у слові!");

        for (int i = 0; i < correctword.Length; i++)
        {
            if (correctword[i] == userInput)
            {
                guessedWord[i] = correctword[i];
            }
        }
        if (new string(guessedWord) == correctword)
        {
            iswordGuessed |= true;
        }
    }
    else
    {
        Console.WriteLine("На жаль такої літери немає, спробуйте іншу");
        triesCount--;
        Console.WriteLine($"Залишилось спроб {triesCount}");
    }

}
if (iswordGuessed)
{
    Console.WriteLine($"Вітаємо! Правильне слово: {correctword}");
}
else
{
    Console.WriteLine($"На жаль, ви не відгадали слово. Правильне слово: {correctword}");
}
