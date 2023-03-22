class FunctionResultsTable
{
    static void Main(string[] args)
    {
        double x = -5;
        double y;

        Console.WriteLine(" x      y  ");

        while (x <= 5)
        {
            y = 5 - (x * x / 2);
            Console.WriteLine("{0,4:F1} | {1,5:F2}", x, y);
            x += 0.5;
        }

        Console.ReadKey();
    }
}