using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountingDuplicatesKata
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, CountingDuplicates.DuplicateCount(""));
            Assert.AreEqual(0, CountingDuplicates.DuplicateCount("abcde"));
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, CountingDuplicates.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }

    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(x => x).Select(y => y.Count() > 1).Count(c=>c);
        }
    }
}
