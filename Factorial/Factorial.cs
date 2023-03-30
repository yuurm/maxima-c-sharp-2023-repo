class Factorial
{
    static void Main(string[] args)
    {
        CalculateFactorial(5);
    }

    private static void CalculateFactorial(int n)
    {
        long factorial = 1;

        for (byte i = 2; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("n! = {0}", factorial);
        
    }

}