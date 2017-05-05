using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathGame;

namespace MathGameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void determineOperatorTest()
        {
            //arrange
            questionGenerator gen = new questionGenerator();
            int streak = 5;
            int answer;

            //act
            answer = gen.determineOperator(streak);

            //assert
            Assert.IsTrue(answer != 0);

        }

        [TestMethod]
        public void determineDiffTest()
        {
            Difficulty diff = new Difficulty();
            int streak = 2;

            Assert.IsFalse(diff.determineDiff(streak).Equals(null));

        }
    }
}
