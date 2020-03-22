using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_2_menu
{
    //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел;
    class Task_3
    {
   

        public Task_3() { }

        public static void InputData()
        {
            int result = 0;
            Console.WriteLine("Введите число, при вводе \"0\" будет подсчитана сумма всех нечетных положительных чисел");
            
            Console.WriteLine("Введите число");
            while (true)
            {
               
               int inputNum = int.Parse(Console.ReadLine());
            
                if (inputNum != 0)
                {
                    Res(inputNum);
                }
                else
                {
                    Console.WriteLine("сумма всех нечетных положительных чисел =  {0}", result);
                    break;
                }
            }
            
          

        }

        public static int Res(int a)
        {
            int result = 0;
            if (a > 0 && a%2 != 0)
            {
               result += a;
            }

            return result;
        }
    }
}
