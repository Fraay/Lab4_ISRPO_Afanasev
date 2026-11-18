﻿String myname = "Афанасьев Глеб";
String mygroup = "ИСП-242";
Console.WriteLine("\nПриветсвую вас! Добро пожаловать в мою программу!");
Console.WriteLine($"ФИО: {myname}");
Console.WriteLine($"Группа: {mygroup}");
Console.WriteLine($"Время прямо сейчас: {DateTime.Now}");
Console.WriteLine();
bool isRunning = true;
while (isRunning)
{
    Console.WriteLine("1 - Показать ФИО");
    Console.WriteLine("2 - Показать группу");
    Console.WriteLine("3 - Показать дату");
    Console.WriteLine("4 - Выход");
    Console.Write("\nВыберите цифру меню: ");
    string num = Console.ReadLine();

switch (num)
{
    case "1":
        Console.WriteLine($"\nФИО: {myname}");
        break;
    case "2":
        Console.WriteLine($"\nГруппа: {mygroup}");
        break;
    case "3":
        Console.WriteLine($"\nВремя прямо сейчас: {DateTime.Now}");
        break;
    case "4":
        isRunning = false;
        break;
    default:
        Console.WriteLine("\nНеправильный ввод, попробуйте ещё раз");
        break;
    }
}