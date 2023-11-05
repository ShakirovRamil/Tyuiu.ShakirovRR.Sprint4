using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShakirovRR.Sprint4.Task2.V8.Lib;

namespace Tyuiu.ShakirovRR.Sprint4.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] a = { 1, 2, 3, 4, 3, 3, 3, 3 };
            int res = ds.Calculate(a);
            int wait = 15;

            Assert.AreEqual(wait, res);
        }
    }
}
