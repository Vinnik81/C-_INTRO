using System;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1, 2
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
            //int[] brr = new int[5] {765, 34, 765, 8, 765};
            //int count = 0;
            //Console.Write($"Введите число: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 0; i < brr.Length; i++)
            //{
            //    if (number == brr[i]) count++;
            //}
            //Console.WriteLine($"{number} встречается {count} раз.");

            //Task 4
            int M = 4;
            int[] arr = new int[M];
            Console.WriteLine($"Введите эелементы первого массива: ");
            for (int i = 0; i < arr.Length; i++) arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"Первый массив: ");
            foreach (int num in arr) Console.Write($"{num}\t");
            int N = 4;
            int[] brr = new int[N];
            Console.WriteLine($"\nВведите эелементы второго массива: ");
            for (int i = 0; i < brr.Length; i++) brr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"Второй массив: ");
            foreach (int num in brr) Console.Write($"{num}\t");
            int count = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (arr[i] == brr[j]) count++;
                }
            }
            int p = (M + N) - count;
            int[] crr = new int[p];
            int item = 0;
            for (int i = 0; i < M; i++)
            {
                    crr[item] = arr[i];
                    item++;
            }
            int pov = 0;
            int index = 0;
            for (int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (arr[i] == brr[j]) pov++;
                }
                if (pov == 0)
                {
                    crr[item] = brr[index];
                    item++;
                    index++;
                }
            }
            Console.WriteLine($"\nРезультирующий масиив: ");
            for (int i = 0; i < p; i++) Console.Write($"{crr[i]}\t");
        }
    }
}
