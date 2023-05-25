namespace Smallest_multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long smallestMultiple = 2520;
            bool isMultipleFound = false;

            while (!isMultipleFound)
            {
                smallestMultiple += 2520;

                for (int i = 11; i <= 20; i++)
                {
                    if (smallestMultiple % i != 0)
                    {
                        isMultipleFound = false;
                        break;
                    }
                    isMultipleFound = true;
                }
            }

            Console.WriteLine(smallestMultiple);
        }
    }
}