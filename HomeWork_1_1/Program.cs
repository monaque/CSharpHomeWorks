// Задача 1

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Первое число больше {a} > {b}");
}
else if (a < b)
{
    Console.WriteLine($"Второе число больше {a} < {b}");
}
else
{
    Console.WriteLine("Числа равны");
}
