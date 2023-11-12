using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShakirovRR.Sprint4.Task5.V25.Lib;

namespace Tyuiu.ShakirovRR.Sprint4.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 1, 0, -3, 1, 2 }, { -4, -2, -3, 1, 2 }, { 1, 2, 2, 2, 1 }, { 1, 2, 2, 2, 1 }, { 1, 2, 2, 2, 1 }, };

            int res = ds.Calculate(mas2);
            int wait = 31;

            Assert.AreEqual(wait, res);
        }
    }
}