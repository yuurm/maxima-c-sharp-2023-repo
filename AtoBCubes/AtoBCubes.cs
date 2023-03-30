class AtoBCubes
{
    static void Main(string[] args)
    {
        CalculateAToBCubes(3, 8);
    }

    private static void CalculateAToBCubes(int a, int b)
    {
        int i;

        for (i = a; i <= b; i++)
        {
            Console.WriteLine(i + " в кубе = " + (i * i * i));
        }

        
    }

}