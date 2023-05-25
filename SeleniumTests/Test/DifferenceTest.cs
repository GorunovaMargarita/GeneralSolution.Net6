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
    public class DifferenceTest : BaseCalculatorTest
    {

        [Test]
        [Category("Smoke"), Description("Health check test")]
        public void DifferenceSimple()
        {
            var expected = 4;
            var actual = calculator.Difference(5, 1);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        [Category("DiffWithZero")]
        public void DifferenceWithZero(
        [Values(2, 3, 4, 0)] double operand1,
        [Values(0)] double operand2)
        {
            var actual = calculator.Difference(operand1, operand2);
            Assert.That(actual, Is.EqualTo(operand1));
        }
        [Test]
        [Category("DiffWithZero")]
        public void DifferenceWithZeroNegativeValues(
        [Values(-2, -3, -4)] double operand1,
        [Values(0)] double operand2)
        {
            var actual = calculator.Difference(operand1, operand2);
            Assert.That(actual, Is.EqualTo(operand1));
        }

        [Test]
        [Category("DiffWithZero")]
        public void DifferenceZeroVithPositive(
            [Random(6, 10, 4)] double operand2,
            [Values(0)] double operand1)
        {
            var actual = calculator.Difference(operand1, operand2);
            Assert.That(actual, Is.EqualTo(-operand2));
        }
        [TestCase(0.05, 10.05, 10)]
        [TestCase(1.2222, 2.5555, 1.3333)]
        [TestCase(-3.79440445485, 4.42785, 8.22225445485)]
        public void DifferenceBetweenFraction(double expected, double operand1, double operand2)
        {
            Assert.That(
                calculator.Difference(operand1, operand2),
                Is.EqualTo(expected));
        }
    }
}
