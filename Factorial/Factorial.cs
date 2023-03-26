class Factorial
{
    static void Main(string[] args)
    {
        CalculateFactorial();
    }

    private static void CalculateFactorial()
    {
        byte n;
        long factorial = 1;

        Console.Write("n = ");
        n = byte.Parse(Console.ReadLine()!);

        for (byte i = 2; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("n! = {0}", factorial);
        Console.ReadKey();
    }
}