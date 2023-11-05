using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShakirovRR.Sprint4.Task0.V22.Lib;

namespace Tyuiu.ShakirovRR.Sprint4.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int res = ds.GetSumOddArrEl(numsArray);
            int wait = 46;
            Assert.AreEqual(wait, res);
        }
    }
}