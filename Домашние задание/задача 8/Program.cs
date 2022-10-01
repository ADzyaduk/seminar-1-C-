// See Задача 8
Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
int y = 0;
while (y <= x)
{
   if (y % 2 == 0)
   Console.WriteLine($"{y}");
   y = y+1; 
}
