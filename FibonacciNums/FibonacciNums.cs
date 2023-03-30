class FibonacciNums
{
    static void Main(string[] args)
    {
        CalculateFibonacci(5);
    }

    private static void CalculateFibonacci(int n)
    {
        int a = 0, b = 1, c;

        Console.Write(a + " " + b + " ");

        for (int i = 3; i <= n; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }

        
    }


}