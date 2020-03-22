using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_2_menu
{

    /*Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000.
    Хорошим называется число, которое делится на сумму своих цифр.Реализовать подсчет
    времени выполнения программы, используя структуру DateTime.*/
    class Task_4
    {

        public Task_4() { }


        public static void InputData()
        {

            Console.WriteLine("Подсчет хороших чисел в диапозоне от 1 до 1 000 000");
            var start = DateTime.Now.Millisecond;

            int result = Сalculation();

            var finish = DateTime.Now.Millisecond;


            Console.WriteLine("Cумма \"Хороших\" чисел =  {0}", result);
            Console.WriteLine("Подсчет произведен за: {0} ms", finish - start);   
        }
        public static int Сalculation()
        {
            int result = 0;
            for (int i = 1; i <= 1000000; ++i)
            {

                if (i % GoodOrNot(i) == 0)
                {
                    result ++;
                }
                else
                {
                    continue;
                }
            }

            return result;
        }
        private static int GoodOrNot(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
            }

            return sum;
                        
        }
    }
}
