namespace Sum_square_difference
{
    internal class Program
    {
        static void Main()
        {
            int n = 1000;

            int sumOfSquares = n * (n + 1) * (2 * n + 1) / 6;
            int squareOfSum = n * (n + 1) / 2 * (n * (n + 1) / 2);

            Console.WriteLine(squareOfSum - sumOfSquares);
        }
    }
}