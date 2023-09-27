using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SmirnovMN.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            int n = 1; // Начинаем с понедельника

            for (int i = 1; i < k; i++)
            {
                n++;
                if (n == 8) // Если достигнут воскресенье, вернемся к понедельнику
                {
                    n = 1;
                }
            }

            return n;
        }
    }
}

