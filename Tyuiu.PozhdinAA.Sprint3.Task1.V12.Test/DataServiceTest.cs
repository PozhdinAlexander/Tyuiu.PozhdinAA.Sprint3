using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PozhdinAA.Sprint3.Task1.V12.Lib;

namespace Tyuiu.PozhdinAA.Sprint3.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 10;
            Assert.AreEqual(1.001, ds.GetSumSeries(value, startValue, stopValue));

        }
    }
}