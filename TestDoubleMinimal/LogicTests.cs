namespace TestDoubleMinimal
{
    [TestClass]
    public sealed class LogicTests
    {
        [TestMethod]
        public void TestSum1()
        {
            int[] testNums = { 11, 22, 33, -22 };
            int expected = -11;
            
            int actual = Program.FindMinimalsSummirize(testNums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum2()
        {
            int[] testNums = { 3, 1, 2, 1, 1, 2, 3, 2, 3, 4, 1 };
            int expected = 2;

            int actual = Program.FindMinimalsSummirize(testNums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum3()
        {
            int[] testNums = { 4, 0, 3, 19, 492, -10, 1 };
            int expected = -10;

            int actual = Program.FindMinimalsSummirize(testNums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum4()
        {
            int[] testNums = { 0, -1, 2, -2, 1 };
            int expected = -3;

            int actual = Program.FindMinimalsSummirize(testNums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum5()
        {
            int[] testNums = { 30, 20, 10, 0, 10, 20, 30 };
            int expected = 10;

            int actual = Program.FindMinimalsSummirize(testNums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum6()
        {
            int[] testNums = { -30, -20, -10, 0, -10, -20, -30 };
            int expected = -60;

            int actual = Program.FindMinimalsSummirize(testNums);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum7()
        {
            int[] testNums = { 30, 20, 10, 0, -10, -20, -30 };
            int expected = -50;

            int actual = Program.FindMinimalsSummirize(testNums);

            Assert.AreEqual(expected, actual);
        }
    }
}
