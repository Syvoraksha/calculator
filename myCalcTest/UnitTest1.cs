using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator2;
using NUnit.Framework;

namespace myCalcTest
{
    [TestFixture]

    public class UnitTest1
    {
        [TestCase(107, 3019, 3126)]
        [TestCase(-2.5, 8765, 8762.5)]
        [TestCase(-105, 877986, 877881)]
        [TestCase(123.456, -987.567, -864.111)]
        [TestCase(-1065, -484, -1549)]
        [TestCase(-123456.789123, -987654.23444, -1111111.023563)]
        [TestCase(12.34, 0, 12.34)]

        public void TestSum(double number1, double number2, double expRes)
        {
            double actRes = new Calculation().Sum(number1, number2);
            Assert.AreEqual(expRes, actRes);

        }

        [TestCase(747, 1234, -487)]
        [TestCase(12332, 21, 12311)]
        [TestCase(-345.257, 877986, -878331.257)]
        [TestCase(123.456, -987.567, 1111.023)]
        [TestCase(-1065, 0, -1065)]
        [TestCase(-123456.789123, -987654.23444, 864197.445317)]

        public void TestDiff(double number1, double number2, double expRes)
        {
            double actRes = new Calculation().Diff(number1, number2);
            Assert.AreEqual(expRes, actRes);

        }

        [TestCase(747, 1234, 921798)]
        [TestCase(12332, -21.8765, -269780.998)]
        [TestCase(-345.257, -877986, 303130812.402)]
        [TestCase(0, -987.567, 0)]
        [TestCase(-0, 0, 0)]
        [TestCase(-1238.781, 9876.23, -12234486.07563)]

        public void TestMultiply(double number1, double number2, double expRes)
        {
            double actRes = new Calculation().Multiply(number1, number2);
            Assert.AreEqual(expRes, actRes);

        }

        [TestCase(747, 1234, "0.60535")]
        [TestCase(12332, -21.8765, "-563.70992")]
        [TestCase(-345.257, -877986, "0.00039")]
        [TestCase(0, -987.567, "0")]
        [TestCase(0, 0, "NaN")]
        [TestCase(123, 0, "∞")]
        [TestCase(123.456, 0, "∞")]


        public void TestDivision(double number1, double number2, string expRes)
        {
            string actRes = new Calculation().Division(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase(10, 4, 2)]
        [TestCase(123, -21, 18)]
        [TestCase(-123, 0, "NaN")]
        [TestCase(0, 0, "NaN")]

        public void TestEuclideanDivision(double number1, double number2, double expRes)
        {
            double actRes = new Calculation().EuclideanDivision(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }
    }
}
