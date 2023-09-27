using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint1.Task5.V6.Lib;

namespace Tyuiu.SmirnovMN.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
        // Arrange
        int k = 100; // Здесь укажите значение k, для которого знаете ожидаемый результат

        // Act
        int result = DayOfWeekCalculator.CalculateDayOfWeek(k);

        // Assert
        Assert.Equal(expectedResult, result); // Здесь укажите ожидаемый результат
    }
    }
}
