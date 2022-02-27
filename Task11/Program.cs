using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {

            Solution solution;
            try
            {
                Console.WriteLine("Введите значение k");
                solution.k = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение b");
                solution.b = Convert.ToDouble(Console.ReadLine());
                solution.Root();
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат исходных данных");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Попытка деления на 0!");
            }
            Console.ReadKey();
        }


        struct Solution
        {
            public double k;
            public double b;


            public void Root()
            {
                
                    double x = -b / k;
                Console.WriteLine("x={0}", x);

            }


        }
    }
}

