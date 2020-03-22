using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_3_menu
{
    public class Task_1_Complex
    {
        private double Re { get; set; }
        private double Im { get; set; }
        
        
        public Task_1_Complex() 
        {
            Re = 0;
            Im = 0;
        }

        public Task_1_Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }


        public Task_1_Complex Plus(Task_1_Complex x2)
        {
            Task_1_Complex x3 = new Task_1_Complex();
            x3.Re = Re + x2.Re;
            x3.Im = Im + x2.Im;
            return x3;
        }

        public Task_1_Complex Difference(Task_1_Complex x2)
        {
            Task_1_Complex x3 = new Task_1_Complex();
            x3.Re = Re - x2.Re;
            x3.Im = Im - x2.Im;
            return x3;
        }

        public Task_1_Complex Multiply(Task_1_Complex x2)
        {
            Task_1_Complex x3 = new Task_1_Complex();
            x3.Re = Re * x2.Re - Im * x2.Im;
            x3.Im = Im* x2.Re + Re* x2.Im;
            return x3;
        }

        public Task_1_Complex Division(Task_1_Complex x2)
        {
            Task_1_Complex x3 = new Task_1_Complex();
            x3.Re = (Re * x2.Re + Im * x2.Im) / (Math.Pow(x2.Re, 2) + Math.Pow(x2.Im, 2));
            x3.Im = (Im * x2.Re - Re * x2.Im) / (Math.Pow(x2.Re, 2) + Math.Pow(x2.Im, 2));
            return x3;
        }

        public override string ToString()
        {
            return Re + "+" + Im + "i";
        }
    }
}
