namespace SeleniumTests.Test
{
    public class UnitTest : BaseTest
    {

        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1");
            Assert.AreEqual(numberOne, numberTwo);
        }
        [Test]
        public void Test2()
        {
            Console.WriteLine("Test2");
            Assert.AreEqual(numberOne, numberTwo);
        }
    }
}