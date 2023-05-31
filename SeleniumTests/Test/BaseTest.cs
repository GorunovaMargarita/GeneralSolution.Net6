using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Test
{
    [TestFixture]
    public class BaseTest
    {
        protected int numberOne = 0;
        protected int numberTwo = 0;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            numberOne = 1;
            Console.WriteLine("One time setup");
        }

        [SetUp]
        public void Setup()
        {
            numberTwo++;
            Console.WriteLine("Set up");
        }
        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Tear Down");
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("One time Tear Down");
        }
    }
}
