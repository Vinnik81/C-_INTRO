using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Program
    {
        public static void MinMax(int[]arr, out int min, out int max)
        {
             min = arr[0];
             max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i]) min = arr[i];
                
                if (max < arr[i]) max = arr[i];
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"########################################## HOME WORK 1 ############################################################");
            Console.Write($"Введите номер задачи (от 1 до 6): ");
            int TASK = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n");
            switch(TASK)
            {
                case 1:
                    //Task 1
                    string str = "It's easy to win forgiveness for being wrong;\n" +
                        "being right is what gets you into real trouble.\n" +
                        "Bjare Stroustrup";
                    Console.WriteLine(str);
                    break;

                case 2:
                    //Task 2
                    int[] arr = new int[5];
                    int sum = 0;
                    int mul = 1;
                    Console.WriteLine($"Введите пять чисел: ");
                    for (int i = 0; i < arr.Length; i++) arr[i] = int.Parse(Console.ReadLine());
                    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]}" + "\t");
                    for (int i = 0; i < arr.Length; i++) sum += arr[i];
                    Console.WriteLine($"\nСумма элементов равна:  {sum}");
                    for (int i = 0; i < arr.Length; i++) mul *= arr[i];
                    Console.WriteLine($"Произведение элементов равно:  {mul}");
                    MinMax(arr, out int min, out int max);
                    Console.WriteLine($"Минимальное значение равно: {min}");
                    Console.WriteLine($"Максимальное значение равно: {max}");
                    break;

                case 3:
                    //Task 3
                    int[] brr = new int[6];
                    Console.WriteLine($"Введите шестизначное число (каждую цифру через Enter): ");
                    for (int i = 0; i < brr.Length; i++)
                    {
                        brr[i] = int.Parse(Console.ReadLine());
                        if (brr[i] >= 10) Console.WriteLine($"Error!!! Неправильно наброна цифра!");
                    }
                    Console.Write($"Шестизначное число: ");
                    for (int i = 0; i < brr.Length; i++) Console.Write($"{brr[i]}");
                    Console.Write($"\nВвывод реверса числа: ");
                    for (int i = brr.Length - 1; i > -1; --i) Console.Write((brr[i]));
                    break;

                case 4:
                    //Task 4
                    int res = 0;
                    int two = 1;
                    Console.Write($"Введите начальное число диапазона: ");
                    int one = int.Parse(Console.ReadLine());
                    Console.Write($"Введите конечное значение диапазона: ");
                    int end = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Вывод ряда Фибоначи: ");
                    do
                    {
                        res = one + two;
                        Console.Write($"\t{res}");
                        one = two;
                        two = res;
                    }
                    while (res < end);
                    break;

                case 5:
                    //Task 5
                    Console.Write($"Введите число A: ");
                    int A = int.Parse(Console.ReadLine());
                    Console.Write($"Введите число B: ");
                    int B = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Вывод массива: ");
                    if (A > 0 && B > 0 && A < B)
                    {
                        for (int i = A; i <= B; i++)
                        {
                            for (int j = 0; j <= i - 1; j++)
                            {
                                Console.Write($"{i}");

                            }
                            Console.WriteLine($"");
                        }
                    }
                    break;

                case 6:
            //Task 6
            Console.Write($"Введите символ: ");
            char s = char.Parse(Console.ReadLine());
            Console.Write($"Введите количество символов: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write($"Введите направления линии (1 - горизонтальное или 2 - вертикальное): ");
            int dir = int.Parse(Console.ReadLine());
            if(num > 0)
            {
                switch(dir)
                {
                    case 1: for (int i = 0; i < num; i++) Console.Write($"{s}"); break;
                    case 2: for (int i = 0; i < num; i++) Console.WriteLine($"{s}"); break;
                    default: Console.WriteLine($"Вы ввели неправильное направление!!!");break;
                }
            }
                    break;
                default: Console.WriteLine($"Error!!! Неверный номер задачи!"); break;
            }

        }
    }
}
