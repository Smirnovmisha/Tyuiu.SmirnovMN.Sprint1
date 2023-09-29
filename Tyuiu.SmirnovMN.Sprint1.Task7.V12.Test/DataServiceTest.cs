using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint1.Task7.V12.Lib;

namespace Tyuiu.SmirnovMN.Sprint1.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 3;
            double wait = 494;
            var result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);

        }
    }
}
