internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 4
        // Задача 2
        Console.Clear();
        Console.Write("Введите первое число");
        int x = int.Parse(Console.ReadLine()!);
        Console.Write("Введите второе число");
        int y = int.Parse(Console.ReadLine()!);
        Console.Write("Введите третье число");
        int z = int.Parse(Console.ReadLine()!);
        int m = x;
        if (x > y)
        {
            m = x;
        }
        if (z > m)
        {
            m = z;
            Console.WriteLine(m);
        }
    }
}