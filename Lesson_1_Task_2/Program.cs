using System;


namespace Lesson_1_Task_2
{
    class Program
    {
        /* Ввести вес и рост человека. Расчитать и вывести индекс массы тела по формуле I=m/(h*h);*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш рост");

            int height = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Введите ваш вес");

            int weight = int.Parse(Console.ReadLine());

            double index = weight / (height * height);

            Console.WriteLine("индекс массы телла: " + index);

            Console.ReadLine();
        }
    }
}
