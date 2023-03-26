    class CollatzConjecture
    {
        static void Main(string[] args)
        {
            CalculateCollatzConjecture();
        }

        private static void CalculateCollatzConjecture()
        {
            int n;

            for (int i = 20; i <= 30; i++)
            {
                n = i;
                while (n != 1)
                {
                    if (n % 2 == 0)
                        n /= 2;
                    else
                        n = (3 * n + 1) / 2;

                    Console.Write(" |" + n + "|");
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

   