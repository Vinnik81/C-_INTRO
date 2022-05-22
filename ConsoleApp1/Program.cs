using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public int age;
        public string name;

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }


        public Person()
        {

        }
    }


    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }


    class Program
    {
        // . NET
        // Language : C# , VB.NET , F#
        // Desktop : WindowsForms , WPF , UWP
        // Mobile : Xamarin
        // Web Back-End : ASP.NET
        // Web Front-End : Blazor
        // Games : Unity

        // C#
        // winforms
        // wpf
        // Design Patterns (SOLID)
        // system programming
        // network programming
        // MS SQL SERVER

        // Front
        // HTML (BOOTSTRAP)
        // css (scss,saas)
        // js (jquery)

        //Back
        // ASP.NET


        // Angular React
        // Ajure

        // PHP
        // Java
        // Spring
        // UNITY









        // ref out in  => Value type


        //static void Test(in int num)
        //{
        //    int number = num + 10;
        //} 


        //static void Test(int a = 10)
        //{
        //    Console.WriteLine(a);
        //}

        //static void Test(params int[] arr)
        //{
        //    // logic
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}


        static void Test(Person person)
        {
            person.age = 999;
            person.name = "999";
        }
        static void Test(ref Point point)
        {
            point.x = 999;
            point.y = 999;
        }

        public static void MinMax(int[] arr, out int min, out int max)
        {
            // 1,2,3,4,5,6,7,8,9

            min = arr[0];
            max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }

                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
        }

        public static void Test(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 10;
            }
        }
        static void Main(string[] args)
        {

            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int[] arr = new int[6];
            //arr[0] = 10; ;
            //Console.WriteLine(arr[1]);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

            //foreach (var num in arr)
            //{
            //    Console.Write($"{num} ");
            //}


            //int[,] arr = {
            //    {1,3,4,5 },
            //    {1,2,3,4 },
            //    {1,2,3, 5 },
            //    {1,2,3,4 },
            //    {1,2,3,4 }
            //};


            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}


            //int[][] arr =
            //{
            //    new  int[]{1,2,3,4,5},
            //    new int[] {6,7,8,9,10,11,12},
            //    new int[] {20,30}
            //};


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write($"{arr[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}



            //foreach (var subArr in arr)
            //{
            //    foreach (var item in subArr)
            //    {
            //        Console.Write($"{item} ");
            //    }
            //    Console.WriteLine();
            //}


            // string str = "";
            //StringBuilder builder = new StringBuilder(1000);
            //string str = "Farid";
            //for (int i = 0; i < 200; i++)
            //{
            //    Console.WriteLine(builder.Capacity);
            //     //str += i;
            //    builder.Append(i);

            //}
            //Console.WriteLine(builder);


            //string str = "Hello my dear frend Farid";
            //string str = "                    Hellol                                   ";
            // Console.WriteLine(str.Length);
            //Console.WriteLine(str.IndexOf("l"));
            // Console.WriteLine(str.LastIndexOf("l"));
            //Console.WriteLine(str.IndexOfAny(new char[] { 'e', 'l', 'o', 'o' }));
            //Console.WriteLine(str.Contains('s'));
            //Console.WriteLine(str.LastIndexOfAny(new char[] { 'e', 'l', 'o', 'o' }));
            //str = str.Trim();
            //Console.WriteLine(str.Trim());
            //Console.WriteLine(str.Insert(1, "h"));
            //Console.WriteLine(str.Substring(str.IndexOf('F'), str.Length - str.IndexOf('F')));
            //Console.WriteLine(str.Substring(str.IndexOf('F'), str.Length - str.IndexOf('F')));
            //Console.WriteLine(str.StartsWith("hello"));
            //Console.WriteLine(str.EndsWith("Farid"));
            //Console.WriteLine(str.ToLower());
            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.Remove(str.IndexOf('F'), str.Length - str.IndexOf('F')));

            string str = "Hello my name is Farid";


            // Console.WriteLine(str.PadRight(5, '~'));
            //Console.WriteLine(str.PadLeft(10, '~'));


            //var arr = str.Split(' ');
            //arr = str.Split(new char[] { 'm', ' ' });

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item.ToUpper()); ;
            //}


            //str = "Abdullayev Farid Ashraf";
            //string[] arr = str.Split(' ');
            //string surname = arr[0];
            //string name = arr[1];
            //string middlename = arr[2];


            //Console.WriteLine(surname);


            //int count = 10;

            //int x = ++count;
            //Console.WriteLine(x); //11

            //count = 10;
            // x = count++;
            ////x = 10 , count = 11
            //Console.WriteLine(x);//10
            //count = 10;
            // x = count--;
            //Console.WriteLine(x);//10
            //count = 10;
            // x = --count;
            //Console.WriteLine(x);//9


            //int num = 0;
            //num++; // => 0 , потом +
            //++num; // + , затем +

            //num = 0;

            //num--;  // => 0 , потом -
            //--num;  // - , затем =>


            //int count = 9;

            //while (count < 10) // true
            //{
            //    Console.Write(++count); //1-10
            //    Console.WriteLine("\n-----------------------");
            //}


            //int count = 9;
            //do
            //{
            //    Console.WriteLine(count--);  
            //} while (count < 1); //false 

            //  9


            //breake , continue

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i); // 0,2,4
            //    if (i == 5)
            //    {
            //      //  break;
            //      continue;
            //    }
            //    i++;
            //}

            //0-9 Игорь
            // 6 != Алексей 
            // 1-8 и не вывоедит 9 Баграт
            // 0-2-4-6-8 Артур
            // 0-2-4-5-6-8 Артур


            //////////////////////////////////////////////////////
            ///
            //int age = 18;
            //bool hasMoney = true;


            //if (age<10 || hasMoney || hasMoney || hasMoney || hasMoney || hasMoney || hasMoney || hasMoney)
            //{

            //}


            /////////////////////////////////////////////////////////////////////////////////

            //string str = "Hello";
            //double a = 4.3;

            //switch (a)
            //{
            //    case 4.2:
            //    case 5.2:
            //    case 1.2:
            //    case 3.2:
            //        Console.WriteLine("Hello hi");
            //        break;

            //    case 4.5:
            //        break;
            //    default:
            //        break;
            //}






            //Test(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}




            // arr[6] = 7;
            //   Console.WriteLine(arr.Length);







            //////////////////////////////////////////////////////////////////////////

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //MinMax(arr, out int min, out int max);

            //Console.WriteLine($"Min = {min}");
            //Console.WriteLine($"Max = {max}");


            //Person person = new Person(); ;
            //person.name = "Farid";
            //person.age = 26;

            //Console.WriteLine($"Name : {person.name} , Age : {person.age}");
            //Test(person);
            //Console.WriteLine($"Name : {person.name} , Age : {person.age}");


            //Point point = new Point(); ;
            //point.x = 10;
            //point.y = 15;

            //Console.WriteLine($"X : {point.x} , Y : {point.y}");
            //Test(ref point);
            //Console.WriteLine($"X : {point.x} , Y : {point.y}");







            //Value types  Struct

            //byte B;      Byte
            //short        Int16
            //int          Int32
            //long         Int64
            //char         Char
            //bool         Boolean
            //float        Float
            //double       Double
            //decimal      Decimal


            //Reference type  Class
            //string      String


            //Value type    - Stack | Struct
            //Referencetype - Heap  | Class









            //int[] arr = { 1, 2, 3, 4, 5, 6 };


            //Test(1,2,3,4,5,6,4,5,6,7,8);




            //int num = 10;  

            ////Console.WriteLine($"Num : {num}");    // 10 

            //Test(in num);  

            //Console.WriteLine($"Num : {num}");    //  11 






            // Console.Write("Enter your name : ");

            // string name = Console.ReadLine();

            // Console.Write("Enter your age : ");

            // //int age = int.Parse(Console.ReadLine());
            // int.TryParse(Console.ReadLine(), out int age);

            //// var age = Console.ReadLine(); 
            // Console.WriteLine($"Name : {name} , Age : {age}");
        }







        //static void Main(string[] args)
        //{
        //    //byte a;            // 1    
        //    //short b            // 2  
        //    //int c              // 4
        //    //long d             // 8

        //    //float e            // 4
        //    //double f           // 8
        //    //decimal g          // 16 

        //    //bool h             // 1
        //    //char h             // 2

        //    //string str
        //    //
        //    // int a = 10; // a
        //    // var x = 10; 
        //    //var x = "Hello";
        //    //x = 4; 
        //    //int a = 10;
        //    //Console.WriteLine("Hello world");


        //    //Console.Write("Hello");
        //    //Console.WriteLine("Hello"); 


        //    // Console.WriteLine("Hello\n\ts");


        //    //string name = "Farid";
        //    //int age = 26;

        //    //Console.Write("Name : ");
        //    //Console.WriteLine(name);

        //    //Console.Write("Age : ");
        //    //Console.WriteLine(age);


        //    //Console.WriteLine("Name : " + name);
        //    //Console.WriteLine("Age : " + age);



        //    //Console.WriteLine("Name : {0} , Age : {1} {1} {1} {1} {1}", name , age);


        //    //Console.WriteLine($"Name : {name} , Age : {age }");


        //    //Console.WriteLine(@"D:\Programmer\Web\Baku\JavsScript\4.Events Game\.idea");


        //    //Console.WriteLine(@"\n,\t");

        //    //Console.WriteLine(@"Farid");

        //    //int x = 5;
        //    //int y = 0;
        //    //Console.WriteLine(x/y);


        //    //Console.Beep(10000, 1000);

        //   // Console.WriteLine(,);

        //}
    }
}
