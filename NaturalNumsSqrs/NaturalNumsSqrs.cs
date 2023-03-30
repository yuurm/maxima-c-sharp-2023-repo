class NaturalNumsSqrs
{
    static void Main(string[] args)
    {
        CalculateNatNumsSqrs(3);
    }

    private static void CalculateNatNumsSqrs(int n)
    {
        int x = 1;

        int y = 1;

        while (y < n)
        {
            Console.Write($"{y} ");
            x++;
            y = (int) Math.Pow(x, 2);
        }
    }

}                              