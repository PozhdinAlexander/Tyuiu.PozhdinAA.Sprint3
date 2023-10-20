using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PozhdinAA.Sprint3.Task3.V25.Lib;

namespace Tyuiu.PozhdinAA.Sprint3.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();

            string input1 = "cvbmzuu";
            string input2 = "oruugtrr";
            string input3 = "dkuvuuudr";


            string str = input1 + input2 + input3;
            char chr = 'u';

            double res = ds.GetMinCharCount(str, chr);

            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}