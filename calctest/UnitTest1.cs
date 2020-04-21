using NUnit.Framework;
using System;
using calculator2;


namespace calctest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase (1, 3, 4)]
        [TestCase(-2, -6, -8)]
       
        public void TestMethod1(int number1, int number2, int expRes)
        {
            int actRes = new Calculation().Sum(number1, number2);
            Assert.AreEqual(expRes, actRes);
        
        }

        [TestCase(10, 2, 5)]
        public void TestMethod3(int number1, int number2, int expRes)
        {
            int actRes = new Calculation().Division(number1, number2);
            Assert.AreEqual(expRes, actRes);

        }
    }
}
