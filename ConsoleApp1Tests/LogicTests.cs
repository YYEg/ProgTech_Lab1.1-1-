using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void SquareSMoreThanCircleS()
        {
            string outMessage = Logic.DoCompare(6, 1);
            

            Assert.AreEqual("Площадь квадрата больше площади круга!", outMessage);
        }

        [TestMethod()]
        public void CircleSMoreThanSquareS()
        {
            string outMessage = Logic.DoCompare(6, 6);

            Assert.AreEqual("Площадь круга больше площади квадрата!", outMessage);
        }

        [TestMethod()]
        public void CircleSAreEqualSquareS()
        {
            string outMessage = Logic.DoCompare(0, 0);


            Assert.AreEqual("Площади круга и квадрата одинаковы!", outMessage);
        }
    }
}