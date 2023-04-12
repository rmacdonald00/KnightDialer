using KnightDialer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnighDialerTests
{
    [TestClass]
    public class KnightDialerTests
    {
        private Solution _knightDialer;
        [TestInitialize]
        public void Setup()
        {
            _knightDialer = new Solution();
        }

        [TestMethod]
        [DataRow(1,10)]
        [DataRow(2,20)]
        [DataRow(3, 46)]
        [DataRow(4, 104)]
        [DataRow(5, 240)]
        [DataRow(6, 544)]
        [DataRow(7, 1256)]
        [DataRow(8, 2848)]
        [DataRow(9, 6576)]
        [DataRow(10, 14912)]
        [DataRow(3131, 136006598)]
        [DataRow(4999, 659158877)]
        public void TestCases(int n, int expected)
        {
            var actual = _knightDialer.KnightDialer(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
