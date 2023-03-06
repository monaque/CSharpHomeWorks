//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int input = int.Parse(Console.ReadLine()!);

if (input > 0 && input <= 5)
{
    Console.WriteLine("Это будний день");
}

else if (input > 5 && input <= 7)
{
    Console.WriteLine("Это будний день");
}
else if (input < 0 && input > 7)
{
    Console.WriteLine("Такого дня не существует.");
}