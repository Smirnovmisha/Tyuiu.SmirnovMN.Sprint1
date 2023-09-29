﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SmirnovMN.Sprint1.Task7.V12.Lib
{
    public class DataService : ISprint1Task7V12
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Pow((x + 1 / x - 1), x) + 18 * x * Math.Pow(y, 2);
            double result = Math.Round(res, 3);
            return result;
        }
    }
}
