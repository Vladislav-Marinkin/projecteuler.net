namespace Smallest_multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num = 2520;
            bool flag = true;

            while (flag)
            {
                num += 2520;

                for (int i = 11; i <= 20; i++)
                {
                    if (num % i != 0)
                    {
                        flag = true;
                        break;
                    }
                    flag = false;
                }
            }

            Console.WriteLine(num);
        }
    }
}