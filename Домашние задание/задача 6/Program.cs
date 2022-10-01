// Задача 6

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите число: ");
        int x = int.Parse(Console.ReadLine()!);
        if (x % 2 == 0)
            Console.WriteLine("Четное");
        else
            Console.WriteLine("Нечетное");
        
    }
}