class DigitsInNum {
    static void Main(string[] args)
    {
        CalculateDigitsInNum();
    }

    private static void CalculateDigitsInNum()
    {
        Console.Write("Введите целое число: ");
        int n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());


        n = Math.Abs(n);

        while (n != 0)
        {
            Console.WriteLine(n % 10);


            n /= 10;
        }
    }
}