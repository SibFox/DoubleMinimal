namespace TestDoubleMinimal
{
    [TestClass]
    public sealed class ExceptionTests
    {
        [TestMethod]
        public void TestNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.FindMinimalsSummirize(null));
        }

        [TestMethod]
        public void TestNoNums()
        {
            Assert.ThrowsException<ArgumentException>(() => Program.FindMinimalsSummirize(Array.Empty<int>()));            
        }

        [TestMethod]
        public void TestOverflow()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Program.FindMinimalsSummirize(new int[101]));
        }
    }
}
