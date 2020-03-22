using System;

namespace Lesson_1_Task_4
{
    class Program
    {

        /*Написать программу обмена значениями двух переменных
        а) с использованием третьей переменной;
        б) без использования третьей переменной.*/
        static void Main(string[] args)
        {
            int a = 20;
            int b = 50;
            int c = a;

            a = b;
            b = c;


            Console.WriteLine("a - было 20, b - было 50");
            Console.WriteLine("a - стало {0}, b - стало {1}", a, b);

            int d = 40;
            int e = 100;

            d = d + e;

            e = d - e;
            d = d - e;

            Console.WriteLine("e - было 40, d - было 100");
            Console.WriteLine("e - стало {0}, d - стало {1}", d, e);

            Console.ReadKey();
        }
    }
}
