using System;

namespace Lesson_2_menu
{
    class Program
    {
        //public virtual void InputData(){}
        static readonly string continum = "нажмите Enter что бы вернуться в меню";
        
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
                            Task_1.InputData();
                            Console.WriteLine(continum);
                            break;
                        }
                    case (2):
                       {
                            Console.Clear();
                            Task_2.InputData();
                            Console.WriteLine(continum);
                            break;
                        }
                    case (3):
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
                        }
                    default:
                            break;

                    }

                Console.ReadKey();
            }
        }
    }
}
