// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите трехзначное число");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{x%10}");
