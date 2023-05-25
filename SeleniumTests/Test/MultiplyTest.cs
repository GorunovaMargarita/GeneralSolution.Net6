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
    public class MultiplyTest : BaseCalculatorTest
    {
        [Test]
        [Category("Smoke"), Description("Health check test")]
        public void TwoAndTwo()
        {
            var expected = 4;
            var actual = calculator.Multiply(2, 2);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        [Category("MyltiplyByOne"), Description("Operation with one")]
        public void MultiplyByOne(
        [Random(1, 10, 5)] double operand2)
        {
            var actual = calculator.Multiply(1, operand2);
            Assert.That(actual, Is.EqualTo(operand2));
        }
        [Test, Category("MyltiplyByOne")]
        public void MultiplyByOneNegativeValues(
        [Values(-1, -5, -100, -1000000)] double operand2)
        {
            var actual = calculator.Multiply(1, operand2);
            Assert.That(actual, Is.EqualTo(operand2));
        }
        [Test]
        public void MultiplyByZero(
            [Random(-6, -2, 3)] double operand1)
        {
            var actual = calculator.Multiply(operand1, 0);
            Assert.That(actual, Is.LessThanOrEqualTo(0));
        }

        [TestCase(8, 2, 4)]
        [TestCase(25, 5, 5)]
        [TestCase(0.00004, 4, 0.00001)]
        public void SummTest(double expected, double operand1, double operand2)
        {
            Assert.That(
                calculator.Multiply(operand1, operand2),
                Is.EqualTo(expected));
        }
    }
}
