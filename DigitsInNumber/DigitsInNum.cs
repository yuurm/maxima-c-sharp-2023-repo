class DigitsInNum {
    static void Main(string[] args)
    {
        ShowDigitsInNum(10);
    }

    private static void ShowDigitsInNum(int n)
    {
        n = Math.Abs(n);

        while (n != 0)
        {
            Console.WriteLine(n % 10);

            n /= 10;
        }
    }


}