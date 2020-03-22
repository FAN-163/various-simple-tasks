using System;
using System.IO;
namespace Lesson_3_menu
{
    class Program
    {
        static readonly string continum = "нажмите Enter что бы вернуться в меню";
        public static string path = "C:\\Users\\Alex\\source\\repos\\training\\Lesson_3_menu\\data.txt";
        
        static void Main(string[] args)
        {
            

                    while (true)
            {
                Console.Clear();

                Console.WriteLine("1 - Task_1");
                Console.WriteLine("2 - Task_2");
                Console.WriteLine("3 - Task_3");
                Console.WriteLine("4 - Task_4");

                int num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case (1):
                        {
                            Console.Clear();
                            Task_1_Complex x1 = new Task_1_Complex(5, 5);
                            Task_1_Complex x2 = new Task_1_Complex(2, 2);
                            var result_dif = x1.Difference(x2);
                            var result_pl = x1.Plus(x2);
                            var result_mult = x1.Multiply(x2);
                            var result_div = x1.Division(x2);

                            Console.WriteLine("Разность равна: {0}, Сумма равно: {1}, Произведение равно: {2}, Отношение равно: {3}", result_dif, result_pl, result_mult, result_div);
                            Console.WriteLine(continum);
                            break;
                        }
                    case (2):
                        {
                            WriteOfFile();
                            Console.Clear();
                            Task_2.InputeData(path);
                            Console.WriteLine(continum);
                            break;
                        }
                    /*case (3):
                        {
                            Console.Clear();
                            Task_3.InputData();
                            Console.WriteLine(continum);
                            break;
                        }
                    case (4):
                        {
                            Console.Clear();
                            Task_4.InputData();
                            Console.WriteLine(continum);
                            break;
                        }*/
                    default:
                        continue;

                }

                Console.ReadKey();
            }

        }

        public static void WriteOfFile()
        {
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(file) ;
            
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
               sw.WriteLine(Convert.ToString(rnd.Next(-1000, 1000)));
            }

            sw.WriteLine("0");
            sw.Close();
            file.Close();
        }


    }
        
}
