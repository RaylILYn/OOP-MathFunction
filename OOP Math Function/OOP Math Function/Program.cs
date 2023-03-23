//Задание 1.1 [Вариант 2]
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            double z;
            double m;

            Console.Write("Введите x= ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите b= ");
            double b = Convert.ToDouble(Console.ReadLine());

            m = (1.5 + b) - x * b;
            if (m == 0)
            {
                Console.Write("Ошибка! Деление на ноль");
                return;
            }
            z = Math.Pow(x, 3) / (1.5 + b) - x * b;
            Console.WriteLine("\nx={0}\tb={1}\nf={2,6:f3}", x, b, z);
            Console.ReadKey();
        }
    }
}