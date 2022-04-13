using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15_16_1_
{
    class Complex
    {
        private double r, i;
        private static uint Counter;
        public Complex()
        {
            r = 0;
            i = 0;
            Counter++;
        }
        public Complex(double Re, double Im)
        {
            r = Re; i = Im;
            Counter++;

        }
        public Complex(Complex c)
        {
            r = c.r; i = c.i;
            Counter++;

        }
        ~Complex()
        {
            Counter--;

        }
        public double Abs()
        {
            return Math.Sqrt(r * r + i * i);
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.r + c2.r, c1.i + c2.i);
        }
        public void PrintComp()
        {
            Console.WriteLine("Комплексное число {0:0.0} + {1:0.0}i", r, i);
        }
        public static uint HowMany()
        {
            return Counter;
        }
    }
}
