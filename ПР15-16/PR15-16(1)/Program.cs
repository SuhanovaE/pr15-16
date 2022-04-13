using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15_16_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кол-во  комплексных чисел {0}", Complex.HowMany());
            Complex[] a;
            Complex d;
            a = new Complex[3];
            a[0] = new Complex(-1, 1);
            a[1] = new Complex(2, 5);
            a[2] = new Complex(3, 0);
            Console.WriteLine("Кол-во  комплексных чисел {0}", Complex.HowMany());
            d = new Complex();
            for(int i = 0; i<a.Length; i++)
            {
                a[i].PrintComp();
                d = d + a[i];

            }
            Console.Write("Сумма равна "); d.PrintComp();
            Console.WriteLine("Модуль суммы равен {0:0.00}", d.Abs());
            Console.WriteLine("Кол-во  комплексных чисел {0}", Complex.HowMany());
            Console.ReadKey();
        }
        
    }
}
