using System;

namespace Lesson_1_Task_3
{
    class Program
    {
        /*а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1
        и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2x1,2)+ Math.Pow(y2y1,2).Вывести результат
        используя спецификатор формата F2 (с двумя знаками после запятой);
        б) *Выполните предыдущее задание оформив вычисления расстояния между точками в виде
        метода;*/

       static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Задайте координаты 2ух точек");
            Console.Write("Введите координату x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            static double Dist(int a, int b, int c, int d)
            {
                double dist = Math.Sqrt(Math.Pow(b - a, 2) + Math.Pow(d - c, 2));
                return dist;
            }



            Console.WriteLine("Расстояние между точками: " + distance.ToString("F2"));
            Console.Write("Расстояние между точками: " + Dist(x1, x2, y1, y2));

            Console.ReadLine();


        }
       
    }
}
