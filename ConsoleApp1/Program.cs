using System;


namespace Lesson_1_Task_1
{
    class Program
    {
        /*Написать программу “Анкета”. Последовательно задаются вопросы (имя, фамилия, возраст,
        рост, вес). В результате вся информация выводится в одну строчку.
        а) используя склеивание;
        б) используя форматированный вывод.*/

        static void Main(string[] args)
        {
            

            Console.WriteLine("Заполните анкету \nВведите ваше Имя");

            string name = Console.ReadLine();

            Console.WriteLine("Введите вашу Фамилию");

            string surName = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст");

            string age = Console.ReadLine();

            Console.WriteLine("Введите ваш рост");

            string height = Console.ReadLine();

            Console.WriteLine("Введите ваш вес");

            string weight = Console.ReadLine();

            Console.WriteLine("Ваше имя: " + name + "\nВаша Фамилия: " + surName + "\nВаш возраст: " + age + "\nВаш рост: " + height + "\nВаш вес: " + weight);
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", name, surName, age, height, weight);

            Console.ReadLine();
        }

        
    }
}
