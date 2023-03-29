public class FibonacciRecursion {
    static Dictionary<int, int> memo = new Dictionary<int, int>() { {0,0}, {1,1} };

    private static int CalculateRecursiveFibonacci(int n){
        if (!memo.ContainsKey(n)){
            memo[n] = CalculateRecursiveFibonacci(n - 1) + CalculateRecursiveFibonacci(n - 2);
        }
        return memo[n];
    }

    public static void Main(string[] args) {
        Console.WriteLine(CalculateRecursiveFibonacci(5));
        Console.WriteLine(CalculateRecursiveFibonacci(10));
    }
}