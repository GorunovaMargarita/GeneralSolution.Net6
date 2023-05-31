using NUnit.Framework.Interfaces;
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
    public class BaseCalculatorTest
    {
        protected Calculator calculator;
        [SetUp]
        public void Setup()
        {
            Trace.Listeners.Add(new ConsoleTraceListener());
            calculator = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
           calculator = null;
        }
        
    }
}
