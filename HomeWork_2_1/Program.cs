//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

string UserEnter()
{
Console.WriteLine("Введите трёхзначное число: ");
var userEnter = Console.ReadLine()!;
return userEnter;
}

string input = UserEnter();

if (input.Length != 3)
{
Console.WriteLine("Вы ввели не трёхзначное число");
input = UserEnter();
}

Console.WriteLine($"Вторая цифра вашего числа -> {input[1]}");