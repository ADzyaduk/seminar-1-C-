internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите число");

        int x = int.Parse(Console.ReadLine()!);

        if (x == 1)
        {
            Console.WriteLine("Понедельник");
        }
        else if (x == 2)
        {
            Console.WriteLine("Вторник");
        }
        else if (x == 3)
        {
            Console.WriteLine("Среда");
        }
        else if (x == 4)
        {
            Console.WriteLine("Четверг");
        }
        else if (x == 5)

        {
            Console.WriteLine("Пятница");
        }
        else if (x == 6)
        {
            Console.WriteLine("Суббота");
        }
        else if (x == 7)
        {
            Console.WriteLine("Воскресенье");
        }
        else
        {
            Console.WriteLine("Не сегодня!");
        }
    }
}