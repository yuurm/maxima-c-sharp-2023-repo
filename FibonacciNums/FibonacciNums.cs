class FibonacciNums
{
    static void Main(string[] args)
    {
        CalculateFibonacci();
    }

    private static void CalculateFibonacci()
    {
        int a = 0, b = 1, c, n;

        Console.Write("n = ");
        n = int.Parse(Console.ReadLine() ?? string.Empty);

        Console.Write(a + " " + b + " ");

        for (int i = 3; i <= n; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }

        Console.ReadKey();
    }
}