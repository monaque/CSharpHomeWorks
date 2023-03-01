Console.WriteLine("Введиет число: ");
int user = int.Parse(Console.ReadLine());

for (int i = 1; i <= user; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
}