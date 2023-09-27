using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SmirnovMN.Sprint1.Task4.V29.Lib;

namespace Tyuiu.SmirnovMN.Sprint1.Task4.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("(Math.Sqrt(2) + Math.Abs(x - 2 * y)) / (3 * x * Math.Pow(y, 2)) = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
