using System;

namespace Lesson_2_menu
{

    /*Написать метод возвращающий минимальное из трех чисел*/
    public class Task_1
    {
      
        public Task_1() { }

        public static void InputData()
        {
            Console.WriteLine("Введите три числа что бы определить минимальное");
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());

            int min = Minimum(a, b, c);
            

            Console.WriteLine("Минимальное число - " + min);
        
         }

        public static int Minimum(int a, int b, int c)
        {
            int min;
            if (a < b && a < c){ min = a; }

            else if (b < a && b < c){ min = b; }

            else { min = c; }

            return min;
         }


        


    }
}
