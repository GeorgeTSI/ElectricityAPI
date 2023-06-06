namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int p = 5;
            int k = 5;

            Assert.AreEqual(p, k);
        }
    }
}