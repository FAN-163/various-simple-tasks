using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_2_menu
{
    class Task_2
    {
        // Написать метод подсчета количества цифр числа;
        
        public Task_2() { }

        public static void InputData()
        {
                Console.WriteLine("Введите число для подсчета количества цифр в нем");
                Console.WriteLine("Введите число");
                int inputNum = int.Parse(Console.ReadLine());
                int count = Counting(inputNum);

                Console.WriteLine("Количество цифр в введенном числе = " + count);
            
        }

        public static int Counting(int a)
        {
            var res = 0;
            while (a > 0)
            {
                a /= 10;

                res++;

            }
            return  res;

        }

    }
}
