using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KulakovEE.Sprint0.Task4.V0.Lib;
namespace Tyuiu.KulakovEE.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]

        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(10, DataService.Subtraction(15, 5));
        }

        [TestMethod]

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]

        public void CheckedDivisonValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
