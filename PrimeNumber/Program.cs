namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static bool isPrime(int n)
            {
                bool result = true;

                if (n <= 1)
                {
                    result = false;
                }
                else
                {
                    for (int i = 2; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            result = false;
                        }
                    }
                }
                return result;
            }
        }
    }
}
