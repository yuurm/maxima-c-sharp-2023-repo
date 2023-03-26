class NumInPow
{
    static void Main(string[] args)
    {
        CalculateNumInPow();
    }

    private static void CalculateNumInPow()
    {
        int deg;
        double num, res = 1;
        byte i;

        Console.Write("Число: ");
        num = double.Parse(Console.ReadLine());

        Console.Write("Степень: ");
        deg = int.Parse(Console.ReadLine());

        for (i = 1; i <= Math.Abs(deg); i++)
        {
            res *= num;
        }

        if (deg < 0)
        {
            res = 1 / res;
        }

        Console.WriteLine(res.ToString("0.000"));

        Console.ReadKey();
    }
}