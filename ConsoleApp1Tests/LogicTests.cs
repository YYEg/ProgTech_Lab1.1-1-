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
            var Circle_S = Logic.Circle_area(3);
            var Square_S = Logic.Square_area(7);

            var OutMessage = Logic.Compare(Square_S, Circle_S);

            Assert.AreEqual("Площадь квадрата больше площади круга!", OutMessage);
        }

        [TestMethod()]
        public void CircleSMoreThanSquareS()
        {
            var Circle_S = Logic.Circle_area(5);
            var Square_S = Logic.Square_area(6);

            var OutMessage = Logic.Compare(Square_S, Circle_S);

            Assert.AreEqual("Площадь круга больше площади квадрата!", OutMessage);
        }

        [TestMethod()]
        public void CircleSAreEqualSquareS()
        {
            var Circle_S = Logic.Circle_area(0);
            var Square_S = Logic.Square_area(0);

            var OutMessage = Logic.Compare(Square_S, Circle_S);

            Assert.AreEqual("Площади круга и квадрата одинаковы!", OutMessage);
        }
    }
}