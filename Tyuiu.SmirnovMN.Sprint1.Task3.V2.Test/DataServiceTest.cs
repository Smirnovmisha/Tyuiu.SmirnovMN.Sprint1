using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint1.Task3.V2.Lib;

namespace Tyuiu.SmirnovMN.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double pricepen = 2;
            int amountpen = 4;
            double pricenote = 3;
            int amountnote = 4;
            double wait = 8;
            var res = ds.PurchaseAmount(pricepen, amountpen, pricenote, amountnote );
            Assert.AreEqual(wait, res);
            
        }
    }
}
