using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NAttributeValidator.Helpers;
using NAttributeValidator.Validation;

namespace NAttributeValidator.Tests
{
    [TestClass]
    public class ExcelPasteOutputValidatorShould
    {
        readonly ExcelPasteOutputValidator _validator = new ExcelPasteOutputValidator(new StringToMatrixParser("\n", "\t"), 3);

        [TestMethod]
        public void ReturnNoErrorForCorrectColumnsAmount()
        {
            var input = "Test1	Test2	Test3";

            var result = _validator.Validate(input);

            Assert.IsTrue(result.IsValid);
        }

        [TestMethod]
        public void ReturnOneErrorForToFewColumnAmount()
        {
            var input = "Test1	Test2";

            var result = _validator.Validate(input);

            Assert.AreEqual(result.Messages.Count(), 1);
        }

        [TestMethod]
        public void ReturnOneErrorForToMuchColumnAmount()
        {
            var input = "Test1	Test2	Test3	Test4";

            var result = _validator.Validate(input);

            Assert.AreEqual(result.Messages.Count(), 1);
        }

    }
}
