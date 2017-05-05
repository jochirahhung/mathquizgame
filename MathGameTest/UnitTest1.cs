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
            string diff = "easy";
            int streak = 3;
            int answer;

            //act
            answer = gen.determineOperator(diff, streak);

            //assert
            Assert.IsTrue(answer != 0);

        }
    }
}
