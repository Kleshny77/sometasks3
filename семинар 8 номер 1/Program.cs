namespace семинар_8_номер_1;
class Program
{
    public static double PI1()
    {
        double PI = 0;
        double PI1 = 1;
        for (int i = 0; Math.Abs(PI1 - PI) > double.Epsilon; i++)
        {
            PI1 = PI;
            PI += Math.Pow(16, -i) * (4.0 / (8 * i + 1) - 2.0 / (8 * i + 4) - 1.0 / (8 * i + 5) - 1.0 / (8 * i + 6));
        }
        return PI;
    }
    public static double PI2()
    {
        double PI = 0;
        double PI1 = 1;
        for (int k = 1; Math.Abs(PI - PI1) > double.Epsilon; k++)
        {
            for (int m = 1; m <= k; m++)
            {
                PI += 1 / (m * Math.Pow(k + 1, 3));
            }
            PI1 = PI;
        }
        
        PI = Math.Pow(PI * 360, 1.0 / 4);
        return PI; //ВЫДАЕТ НЕПРАВИЛЬНОЕ ЗНАЧЕНИЕ PI
    }
    static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Нажмите A, чтобы вычислить PI по формуле приближённого вычисления π Бэйли-Боруэйна-Плаффа, или нажмите S, чтобы вычислить PI по формуле приближённого вычисления π с использованием кратных рядов");
            if (Console.ReadKey().Key == ConsoleKey.A)
            {
                Console.WriteLine();
                Console.WriteLine(PI1());
            }
            else if (Console.ReadKey().Key == ConsoleKey.S)
            {
                Console.WriteLine();
                Console.WriteLine(PI2());
            }
            Console.WriteLine(PI2());
            Console.WriteLine("Нажмите Escape, чтобы завершить программу, или любую другую клавишу, чтобы перезапустить её");
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}

