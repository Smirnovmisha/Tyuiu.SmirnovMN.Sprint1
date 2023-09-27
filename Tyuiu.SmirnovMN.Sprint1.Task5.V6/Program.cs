using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SmirnovMN.Sprint1.Task5.V6.Lib;

namespace Tyuiu.SmirnovMN.Sprint1.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение k: ");
            int k = int.Parse(Console.ReadLine());

            int dayOfWeek = DayOfWeekCalculator.CalculateDayOfWeek(k);
            Console.WriteLine($"День недели для {k}-го дня: {dayOfWeek}");
        }
    }
}
