namespace _02.MinMaxValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();

            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = numbers[i];

                if (maxNumber < currentNumber)
                {
                    maxNumber = currentNumber;
                }
                if (minNumber > numbers[i])
                {
                    minNumber = numbers[i];
                }
            }
            Console.WriteLine(maxNumber);
            Console.WriteLine(minNumber);
        }
    }
}
