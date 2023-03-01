//Задача 2

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите тертье число: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (b > a)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine($"Максимальное число - {max}");