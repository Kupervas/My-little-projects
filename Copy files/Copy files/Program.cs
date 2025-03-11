using System;
using System.IO;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введіть шлях до вихідного файлу: ");
            string sourcePath = Console.ReadLine();

            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Вихідний файл не існує ");
                return;
            }
            Console.Write("Введіть шлях до файлу, в який потрібно скопіювати дані: ");
            string destinationPath = Console.ReadLine();

            File.Copy(sourcePath, destinationPath, true);
            Console.WriteLine("Файл успішно скопійовано ");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}"); 
        }
    }
}
