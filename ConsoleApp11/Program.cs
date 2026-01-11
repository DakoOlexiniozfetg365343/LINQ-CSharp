using ConsoleApp11.Tasks;
using ConsoleApp11.Tasks.Task1;
using ConsoleApp11.Tasks.Task2;
using ConsoleApp11.Tasks.Task3;
//using ConsoleApp10.Tasks.Task4; 
//using ConsoleApp10.Tasks.Task5;
//using ConsoleApp10.Tasks.Task6;

Console.WriteLine("Виберіть завдання (1–6):");
var choice = Console.ReadLine();

switch (choice)
{
    case "1": Task1.Run(); break;
    case "2": Task2.Run(); break;
    case "3": Task3.Run(); break;
    
    default:
        Console.WriteLine("Невідоме завдання");
        break;
};