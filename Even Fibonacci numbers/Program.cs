namespace Even_Fibonacci_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4000000;
            int first = 2;
            int second = 3;
            int summ = 2;

            while (second <= n)
            {
                int next = first + second;
                first = second; second = next;

                if (next % 2 == 0) summ += next;
            }

            Console.WriteLine("Сумма: " + summ);
        }
    }
}