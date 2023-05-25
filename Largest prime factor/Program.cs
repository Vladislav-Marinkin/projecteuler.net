namespace Largest_prime_factor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num = 600851475143;
            long largestPrimeFactor = FindLargestPrimeFactor(num);

            Console.WriteLine(largestPrimeFactor);
        }

        static long FindLargestPrimeFactor(long number)
        {
            long largestFactor = 0;

            while (number % 2 == 0)
            {
                largestFactor = 2;
                number /= 2;
            }

            for (long i = 3; i <= Math.Sqrt(number); i += 2)
            {
                while (number % i == 0)
                {
                    largestFactor = i;
                    number /= i;
                }
            }

            if (number > 1)
            {
                largestFactor = number;
            }

            return largestFactor;
        }
    }
}