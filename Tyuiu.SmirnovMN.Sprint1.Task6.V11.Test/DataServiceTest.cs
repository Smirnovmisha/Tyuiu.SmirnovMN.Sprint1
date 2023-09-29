using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint1.Task6.V11.Lib;

namespace Tyuiu.SmirnovMN.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Hello, world!";
            DataService ds = new DataService();
            bool res = ds.CheckeFirstLetterRepetition(strTest);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
