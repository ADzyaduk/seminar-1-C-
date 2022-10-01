// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите число");
int x = int.Parse(Console.ReadLine()!);
int y = -x;
while(y <= x)
{
Console.Write($"{y} ");
y = y+1; 
}

