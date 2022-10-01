// Задача 2
Console.Clear();
Console.Write("Введите первое число");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число");
int y = int.Parse(Console.ReadLine()!);
if (x<y)
{
    Console.WriteLine($"{y}");
}
if (x>y)
{
    Console.WriteLine($"{x}");
}
