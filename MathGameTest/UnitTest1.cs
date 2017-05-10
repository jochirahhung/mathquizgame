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

        [TestMethod]
        public void generateQuestionTest()
        {
            questionGenerator gen = new questionGenerator();
            double number = 0.0;
            int streak = 5;
            gen.generateQuestion(streak);

            number = gen.answer;

            Assert.IsTrue(number >= 1 && number < 21);
        }

        [TestMethod]
        public void generateQuestion2Test()
        {
            questionGenerator gen = new questionGenerator();
            double number = 0.0;
            int streak = 15;
            gen.generateQuestion(streak);

            number = gen.answer;

            Assert.IsTrue(number >= 0 && number < 41);
        }
    }
}
