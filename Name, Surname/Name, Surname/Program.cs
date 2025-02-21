string name = "Ruslan";
Console.WriteLine($"name = {name}");

string surname = "Rupervas";
Console.WriteLine($"surname = {surname}");

if (name[0] == surname[0])
{
    Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я.");
}
else
{
    Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я.");
}