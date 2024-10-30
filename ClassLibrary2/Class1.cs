using System;

namespace ClassLibrary2
{
    public static class CosineCalculator
    {
        public static double CalculateCosineSum(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Массив чисел не может быть пустым.");
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                if (number < 3)
                {
                    sum += number;
                }
            }

            return Math.Cos(sum);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество целых чисел (n):");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите n целых чисел:");
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            try
            {
                double result = CosineCalculator.CalculateCosineSum(numbers);
                Console.WriteLine($"Косинус суммы чисел < 3: {result:F4}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}