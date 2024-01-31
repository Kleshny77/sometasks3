namespace семинар_8_номер_2;
class Program
{
    public static double InputDouble(string x)
    {
        bool flag;
        double result;
        do
        {
            Console.Write($"{x} = ");
            if (!double.TryParse(Console.ReadLine(), out result))
            {
                flag = false;
                Console.WriteLine("Некорректный ввод, попробуйте еще раз");
            }
            else
            {
                flag = true;
            }
        }
        while (!flag);
        return result;
    }
    public static bool Triangle(double x, double y, double z, out double p, out double s)
    {
        p = x + z + y;
        double p1 = p / 2.0;
        s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        if (x + y <= z || x + z <= y || y + z <= x)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            double a = InputDouble("a");
            double b = InputDouble("b");
            double c = InputDouble("c");
            double s;
            double p = Triangle(a, b, c, out p, out s);
        }
    }
}

