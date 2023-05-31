using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Calc
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b) => b == 0 ? 0:a / b;
        public double Difference(double a, double b) => Math.Round(a - b, 12);

    }
}
