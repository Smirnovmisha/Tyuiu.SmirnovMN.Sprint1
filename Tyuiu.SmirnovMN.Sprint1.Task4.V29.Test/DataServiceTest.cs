using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint1.Task4.V29.Lib;

namespace Tyuiu.SmirnovMN.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 9;
            double wait = Math.Sqrt(14) / 1458;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
            


        }
    }
}
