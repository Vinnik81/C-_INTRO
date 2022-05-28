using System;

namespace HomeWork_2
{
    class Program
    {
        public static void MinMax(int[,] Arr, out int min, out int max)
        {
            min = Arr[0, 0];
            max = Arr[0, 0];
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (min > Arr[i, j]) min = Arr[i, j];
                    if (max < Arr[i, j]) max = Arr[i, j];
                }
            }
        }
        static void Main(string[] args)
        {
            // Task 1, 2
            //int[] arr = new int[10];
            //Console.WriteLine($"Введите значение элементов массива: ");
            //for (int i = 0; i < arr.Length; i++) arr[i] = int.Parse(Console.ReadLine());
            //foreach (int num in arr) Console.Write($"{num}\t");
            //Console.WriteLine($"\nВывод чётных элементов массива:");
            //foreach (int num in arr)
            //{
            //    if (num % 2 == 0) Console.Write($"{num}\t");
            //}
            //Console.WriteLine($"\nВывод нечётных элементов массива:");
            //foreach (int num in arr)
            //{
            //    if (num % 2 != 0) Console.Write($"{num}\t");
            //}
            //Console.Write($"\nВведите значение на которое нужно уменьшить количество элементов: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"\nВывод c меньшим количеством элементов массива, чем задано:");
            //for (int i = 0; i < arr.Length - n; i++) Console.Write($"{arr[i]}\t");

            // Task 3
            //int[] brr = new int[5] { 765, 34, 765, 8, 765 };
            //int count = 0;
            //Console.Write($"Введите число: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 0; i < brr.Length; i++)
            //{
            //    if (number == brr[i]) count++;
            //}
            //Console.WriteLine($"{number} встречается {count} раз.");

            //Task 4
            //const int M = 4;
            //const int N = 4;
            //int[] arr = new int[M];
            //Console.WriteLine($"Введите эелементы первого массива: ");
            //for (int i = 0; i < arr.Length; i++) arr[i] = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Первый массив: ");
            //foreach (int num in arr) Console.Write($"{num}\t");
            //int[] brr = new int[N];
            //Console.WriteLine($"\nВведите эелементы второго массива: ");
            //for (int i = 0; i < brr.Length; i++) brr[i] = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Второй массив: ");
            //foreach (int num in brr) Console.Write($"{num}\t");
            //int count = 0;
            //for (int i = 0; i < M; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        if (arr[i] == brr[j]) count++;
            //    }
            //}
            //Console.Write($"\nКоличество совпадений: {count}");
            //int p = count;
            //int[] crr = new int[p];
            //p = 0;
            //for (int j = 0; j < N; j++)
            //{
            //    for (int k = 0; k < M; k++)
            //    {
            //        if (brr[j] == arr[k])
            //        {
            //            crr[p] = brr[j];
            //            p++;
            //        }
            //    }
            //}
            //Console.WriteLine($"\nРезультирующий масиив: ");
            //for (int i = 0; i < p; i++) Console.Write($"{crr[i]}\t");

            //Task 5
            //int[,] Arr = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            //MinMax(Arr, out int min, out int max);
            //Console.WriteLine($"Миримальное значение массива: {min}");
            //Console.WriteLine($"Максимальное значение массива: {max}");

            //Task 6, 7, 8
            //Console.WriteLine($"Введите строку: ");
            //string str = Console.ReadLine();
            //Console.WriteLine($"str: {str}");
            //string[] strArr = str.Split(' ');
            //Console.WriteLine($"Количество слов в строке: {strArr.Length}");
            //Console.WriteLine($"Реверсирование строки: ");
            //for (int i = str.Length - 1; i >= 0; --i) Console.Write(str[i]);

            //Task 8
            //Console.WriteLine($"Введите строку: ");
            //string str = Console.ReadLine().ToLower();
            //int count = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if
            //        (
            //        str[i] == 'а' || str[i] == 'е' || str[i] == 'ё' || str[i] == 'и' || str[i] == 'о' ||
            //        str[i] == 'у' || str[i] == 'ы' || str[i] == 'э' || str[i] == 'ю' || str[i] == 'я'
            //        )
            //        count++;
            //}
            //Console.WriteLine($"\nКоличество гласных букв в строке: {count}");

            //Task 9
            Console.WriteLine($"Введите строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine($"Введите слова для поиска: ");
            string str2 = Console.ReadLine();
            int i = 0;
            int x = -1;
            int count = -1;
            while (i != -1)
            {
                i = str1.IndexOf(str2, x + 1);
                x = i;
                count++;
            }
            Console.Write($"\nКоличество найденных слов: {count}");

        }
    }
}
