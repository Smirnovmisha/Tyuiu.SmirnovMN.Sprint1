﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint1.Task2.V2.Lib;

namespace Tyuiu.SmirnovMN.Sprint1.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertAngleToRad(x);
            Assert.AreEqual(0, 360, res);
        }
    }
}
