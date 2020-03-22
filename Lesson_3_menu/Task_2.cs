using System;
using System.IO;

namespace Lesson_3_menu
{
   /* Из файла вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется
     подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран*/
    public  class Task_2
    {
        public static void InputeData(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int sum = 0;
            foreach (var line in lines)
            {
                Console.WriteLine(line);
                _ = PositivOddNumber(int.Parse(line)) == true ? sum += int.Parse(line) : sum += 0;
            }
                
            Console.WriteLine("Сумма положительных нечетных чисел  = {0}", sum);
        }

        public static bool PositivOddNumber(int a)
        {
            if (a > 0 && a % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
