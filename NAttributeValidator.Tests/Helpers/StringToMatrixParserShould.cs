using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NAttributeValidator.Helpers;

namespace NAttributeValidator.Tests.Helpers
{
    [TestClass]
    public class StringToMatrixParserShould
    {
        readonly StringToMatrixParser _mother = new StringToMatrixParser("\n","\t");

        [TestMethod]
        public void ReturnValidColumnsCountForSingleRow()
        {
            var input = "Test1\tTest2\tTest3";

            var result = _mother.Parse(input);

            Assert.AreEqual(result[0].Count, 3);
        }

        [TestMethod]
        public void ReturnValidColumnsCountForMultipleRow()
        {
            var input = "Test1\tTest2\tTest3\nTest1\tTest2";

            var result = _mother.Parse(input);

            Assert.AreEqual(result[0].Count, 3);
            Assert.AreEqual(result[1].Count, 2);
        }

        [TestMethod]
        public void ReturnValidRowsCountForSingleRow()
        {
            var input = "Test1\tTest2\tTest3";

            var result = _mother.Parse(input);

            Assert.AreEqual(result.Count, 1);
        }

        [TestMethod]
        public void ReturnValidRowsCountForMultipleRow()
        {
            var input = "Test1\tTest2\tTest3\nTest1\tTest2";

            var result = _mother.Parse(input);

            Assert.AreEqual(result.Count, 2);
        }
    }
}
