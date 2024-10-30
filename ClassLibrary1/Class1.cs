using System;
using System.Linq;

namespace ClassLibrary1
{
    public static class Class1
    {
        public static double CalculateCosineSum(int[] numbers)
        {
          
            if (numbers == null || numbers.Length == 0)  // Проверка на пустой ли массив
            {
                throw new ArgumentException("Массив чисел не может быть пустым.");
            }

            double sum = numbers
                .Where(n => n < 3) // Фильтруем числа, меньшие 3
                .Sum(); 

            return Math.Cos(sum);    // Вычисление косинуса суммы
        }
    }
}

