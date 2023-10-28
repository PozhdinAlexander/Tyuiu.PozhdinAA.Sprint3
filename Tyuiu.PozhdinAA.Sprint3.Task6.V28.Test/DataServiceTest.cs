using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PozhdinAA.Sprint3.Task6.V28.Lib;

namespace Tyuiu.PozhdinAA.Sprint3.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int start = 1;
            int stop = 4;
            Assert.AreEqual(8, ds.GetSumTheDivisors(start, stop));
        }
    }
}