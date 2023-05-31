using NUnit.Framework;
using SeleniumTests.Calc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Test
{
    [TestFixture]
    public class AddTest : BaseCalculatorTest
    {

        [Test]
        [Category("Smoke"), Description("Health check test")]
        public void OneAndOne()
        {
            var expected = 2;
            var actual = calculator.Add(1, 1);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        [Category("Greater")]
        public void GreaterThanZero(
            [Values(2, 3, 4)] double operand1,
            [Values(-1)] double operand2)
        {
            var actual = calculator.Add(operand1, operand2);
            Assert.That(actual, Is.GreaterThan(0));
        }

        [Test]
        public void LessThanOrEqualZero(
            [Random(-6, -2, 3)] double operand1,
            [Random(2, 5, 3)] double operand2)
        {
            var actual = calculator.Add(operand1, operand2);
            Assert.That(actual, Is.LessThanOrEqualTo(0));
        }

        [TestCase(6, 2, 4)]
        [TestCase(10, 5, 5)]
        [TestCase(4.00001, 4, 0.00001)]
        public void SummTest(double expected, double operand1, double operand2)
        {
            Assert.That(
                calculator.Add(operand1, operand2),
                Is.EqualTo(expected));
        }
        [Test]
        [Category("SoftAssert")]
        [Retry(2)]
        public void ResultBetween(
        [Values(-1, 1)] double operand1,
        [Range(1, 5, 3)] double operand2)
        {
            var actual = calculator.Add(operand1, operand2);
            Assert.Multiple(() =>
            {
                Assert.That(actual, Is.GreaterThan(0));
                Assert.That(actual, Is.LessThanOrEqualTo(6));
                Assert.That(actual, Is.GreaterThan(1));
            }
            );
        }
        [Test]
        [Retry(100)]
        public void RetryTest()
        {
            var rnd = new Random();
            var actual = calculator.Add(rnd.Next(0,5), rnd.Next(0, 7));

            Assert.That(actual, Is.GreaterThan(8));
        }
    }
}
