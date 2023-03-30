    class CollatzConjecture
    {
        static void Main(string[] args)
        {
            ShowCollatzConjecture(20, 30);
        }

        private static void ShowCollatzConjecture(int x, int y)
        {
            int n;

            for (int i = x; i <= y; i++)
            {
                n = i;
                while (n != 1)
                {
                    if (n % 2 == 0)
                        n /= 2;
                    else
                        n = (3 * n + 1) / 2;

                    Console.Write(" | " + n + " |");
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            
        }
    }

   