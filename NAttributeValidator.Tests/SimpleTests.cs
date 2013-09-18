using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NAttributeValidator.Attributes;

namespace NAttributeValidator.Tests
{
    [TestClass]
    public class SimpleTests
    {
        class MyClass
        {
            [Required]
            private int h = 5;
        }

        [TestMethod]
        public void TestMethod1()
        {
            
        }
    }
}
