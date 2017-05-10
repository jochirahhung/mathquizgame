using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathGame;

namespace MathGameTest
{
    [TestClass]
    public class UnitTest1
    {




        [TestMethod]
        public void determineDiffTest()
        {
            Difficulty diff = new Difficulty();
            int streak = 2;

            Assert.IsFalse(diff.determineDiff(streak).Equals(null));
        }

        [TestMethod]
        public void determineDiff2Test()
        {
            Difficulty diff = new Difficulty();
            int streak = 2;

            Assert.IsTrue(diff.determineDiff(streak).Equals("easy"));
        }

    }
}
