using NUnit.Framework;
using SeleniumTests.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator calculator;

        [OneTimeSetUp] 
        public void SetUp() 
        { 
            calculator = new Calculator();
        }

        [Test]
        [Category("Smoke")]
        public void SimpleTest()
        {
            var expected = 4;
            var actual = calculator.Add(2, 2);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void SimpleTestWithVals(
            [Values(1,2,3)] double operand1,
            [Random(0,10,1)] double operand2)
        {
            var actual = calculator.Add(operand1, operand2);
            Assert.That(actual, Is.GreaterThan(1));
        }

        [TestCase(4, 2, 2)]
        [TestCase(4, 1, 2)]
        [TestCase(4, 4, 0)]
        public void SumTest(double expected, double operand1, double operand2)
        {
            Assert.That(
                calculator.Add(operand1, operand2), 
                Is.EqualTo(expected));
        }

        [TestCase(4, 2, ExpectedResult = 6)]
        [TestCase(4, 1, ExpectedResult = 5)]
        [TestCase(4, 4, ExpectedResult = 8)]
        public double SumTestWithExpRes(double operand1, double operand2)
        {
            return calculator.Add(operand1, operand2);
        }

        [Test]
        [Category("Smoke")]
        public void SoftAssert()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(1, 1);
                Assert.AreEqual(2, 2);
                Assert.AreEqual(3, 1);
            }
            ); 
        }
    }
}
