using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulation;
using System.Collections.Generic;

namespace StringManipulationTests
{

    [TestClass]
    public class StringManipulationStacksTests
    {
        [TestMethod]
        public void TestGetReversedString()
        {
            StringManipulationUsingStacks obj = new StringManipulationUsingStacks();
            string reversed = obj.GetReversedString("LARGE");
            Assert.IsTrue(reversed == "EGRAL");
        }
    }

    [TestClass]
    public class StringManipulationArrayReverseTests
    {
        [TestMethod]
        public void TestGetReversedString()
        {
            StringManipulationUsingArrayReverse obj = new StringManipulationUsingArrayReverse();
            string reversed = obj.GetReversedString("LARGE");
            Assert.IsTrue(reversed == "EGRAL");
        }
    }

    [TestClass]
    public class ExtensionMethodsTests
    {
        [TestMethod]
        public void TestGetCharStack()
        {
            Stack<char> stack = "LARGE".ToStack();
            Assert.IsTrue(stack.Pop() == 'E');
            Assert.IsTrue(stack.Pop() == 'G');
            Assert.IsTrue(stack.Pop() == 'R');
            Assert.IsTrue(stack.Pop() == 'A');
            Assert.IsTrue(stack.Pop() == 'L');
        }
    }
}
