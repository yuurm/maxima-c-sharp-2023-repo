class DigitsInNum {
    static void Main(string[] args) {
        Console.Write("Введите целое число: ");
        int n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        // Значение n может быть отрицательным.
        // Берем абсолютное значение числа.
        n = Math.Abs(n);

        while (n != 0) { // Повторять до тех пор...
            // вывод последней цифры числа
            Console.WriteLine(n % 10);

            // удаление последней цифры числа
            n /= 10;
        }
    }
}