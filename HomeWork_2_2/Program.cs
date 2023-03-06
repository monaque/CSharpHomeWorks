//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string UserEnter()
{
Console.WriteLine("Введите число: ");
var userEnter = Console.ReadLine()!;
return userEnter;
}

string input = UserEnter();

if (input.Length < 3)
{
Console.WriteLine("Третьей цифры нет");
}

Console.WriteLine($"Вторая цифра вашего числа -> {input[2]}");