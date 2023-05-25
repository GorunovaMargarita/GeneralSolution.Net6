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
    public class DivideTest : BaseCalculatorTest
    {

        [Test]
        [Category("Smoke"), Description("Health check test")]
        public void DivideFourToTwo()
        {
            var expected = 2;
            var actual = calculator.Divide(4, 2);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        [Category("DivideToZero")]
        public void DivideToZero(
            [Values(2, 3, 4, 0)] double operand1,
            [Values(0)] double operand2)
        {
            var actual = calculator.Divide(operand1, operand2);
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        [Category("DivideToZero")]
        public void DivideToZeroNegativeValues(
            [Random(-6, -2, 3)] double operand1,
            [Values(0)] double operand2)
        {
            var actual = calculator.Divide(operand1, operand2);
            Assert.That(actual, Is.EqualTo(0));
        }

        [TestCase(3, 9, 3)]
        [TestCase(5, 10, 2)]
        [TestCase(2, 4.4444, 2.2222)]
        public void DivideWithoutRemainderTest(double expected, double operand1, double operand2)
        {
            Assert.That(
                calculator.Divide(operand1, operand2),
                Is.EqualTo(expected));
        }
    }
}
