using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PozhdinAA.Sprint3.Task2.V24.Lib;

namespace Tyuiu.PozhdinAA.Sprint3.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int start = 1;
            int stop = 2;
            double a = 0.0;

            Assert.AreEqual(16, ds.GetMultiplySeries(a, start, stop));
        }
    }
}