class NumInPow
{
    static void Main(string[] args)
    {
        CalculateNumInPow(25, 2);
    }
    
    
    
    private static void CalculateNumInPow(double num, int deg)
    {
        double res = 1;
        int i;

        for (i = 1; i <= Math.Abs(deg); i++)
        {
            res *= num;
        }

        if (deg < 0)
        {
            res = 1 / res;
        }

        Console.WriteLine(res.ToString("0.000"));

        
    }


    
}