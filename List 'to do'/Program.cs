using System;

class Program
{
    static void Main()
    {
        List<string> ToDoList = new List<string>();
        while (true)
        {
            Console.WriteLine("Виберіть опцію: ");
            Console.WriteLine("1. Додати справу");
            Console.WriteLine("2. Показати усі справи");
            Console.WriteLine("3. Відмітити виконану справу");
            Console.WriteLine("4. Видалити справу");
            Console.WriteLine("5. Вихід");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTask(ToDoList);
                    break;
                case "2":
                    ShowTasks(ToDoList);
                    break;
                case "3":
                    MarkTask(ToDoList);
                    break;
                case "4":
                    DeleteTask(ToDoList);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Некоректний ввід, спробуйте ще раз");
                    break;
            }
        }
            
    }
    static void AddTask(List<string> ToDoList)
    {
        Console.Write("Введіть назву справи: ");
        string task = Console.ReadLine();
        ToDoList.Add(task);
        Console.WriteLine("Справу додано");

    }
    static void ShowTasks(List<string> ToDoList)
    {
        if (ToDoList.Count == 0)
        {
            Console.WriteLine("Список справ порожній");
        }
        else
        {
            Console.WriteLine("Список справ: ");
            for (int i = 0; i < ToDoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ToDoList[i]} ");
            }
        }
    }
    static void MarkTask(List<string> ToDoList)
    {
        Console.WriteLine("Введіть номер справи, яку ви хочете позначити як виконану");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= ToDoList.Count)
        {
            ToDoList[taskNumber - 1]  += (" - виконано"); 
            Console.WriteLine("Справу позначену як виконану");
        }
        else
        {
            Console.WriteLine("Некоректний ввід номер або спрaви не існує");
        }
    }
    static void DeleteTask(List<string> ToDoList)
    {
        Console.WriteLine("Введіть номер справи яку потрібно видалити");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= ToDoList.Count)
        {
            ToDoList.RemoveAt(taskNumber - 1);
            Console.WriteLine("Справу успішно видалено");
        }
        else
        {
            Console.WriteLine("Некоректний ввід номер або спрaви не існує");
        }
    }
}
        