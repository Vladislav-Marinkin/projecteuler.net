namespace Multiples_of_3_or_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;

            for (int i = 0; i < 1000; i++)
                if (i % 3 == 0 || i % 5 == 0) summ += i;

            Console.WriteLine("Сумма: " + summ);
        }
    }
}