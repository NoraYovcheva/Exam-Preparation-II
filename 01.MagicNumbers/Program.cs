namespace _01.MagicNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isThereNoMatchingNumbers = true;

            for (int i = 1; i <= n; i++)
            {
                int currentNumber = i;
                int digitSum = 0;
                bool isAllDigitsPrime = true;

                while (currentNumber > 0)
                {
                    int digit = currentNumber % 10;
                    currentNumber = currentNumber / 10;

                    bool isDigitPrime = digit == 2 || digit == 3 || digit == 5 || digit == 7;

                    if (isDigitPrime)
                    {
                        digitSum = digitSum + digit;
                    }
                    else
                    {
                         isAllDigitsPrime = false;
                        break;
                    }
                }

                if (isAllDigitsPrime && digitSum % 2 == 0)
                {
                    Console.Write(i + " ");
                    isThereNoMatchingNumbers = false;
                }
            }

            if (isThereNoMatchingNumbers)
            {
                Console.WriteLine("no");
            }

        }
    }
}
