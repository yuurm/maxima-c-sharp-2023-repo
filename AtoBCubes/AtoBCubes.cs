class AtoBCubes
{
    static void Main(string[] args)
    {
        CalculateAToBCubes();
    }

    private static void CalculateAToBCubes()
    {
        int a, b, i;

        Console.Write("A: ");
        a = int.Parse(Console.ReadLine()!);

        Console.Write("B: ");
        b = int.Parse(Console.ReadLine()!);

        for (i = a; i <= b; i++)
        {
            Console.WriteLine(i + " в кубе = " + (i * i * i));
        }

        Console.ReadKey();
    }
}