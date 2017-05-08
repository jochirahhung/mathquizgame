using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class questionGenerator
    {
        Random rand = new Random();
        Difficulty difficulty = new Difficulty();
        public int answer { get; set; }
        string[] operators = new string[4] { "+", "-", "*", "/" };

        private int randNum(string diff, int streak)
        {
            int number = 0;
            diff = difficulty.determineDiff(streak);

            if (diff.Equals("easy", StringComparison.CurrentCultureIgnoreCase))
            {
                number = rand.Next(1, 11);
            }
            else if (diff.Equals("medium", StringComparison.CurrentCultureIgnoreCase))
            {
                number = rand.Next(1, 21);
            }
            else if (diff.Equals("hard", StringComparison.CurrentCultureIgnoreCase))
            {
                number = rand.Next(1, 51);
            }
            else if (diff.Equals("expert", StringComparison.CurrentCultureIgnoreCase))
            {
                number = rand.Next(1, 101);
            }

            return number;
        }

        private int determineOperator(string diff)
        {
            Random randOp = new Random();
            int randomOperator = 0;

            if (diff.Equals("easy", StringComparison.CurrentCultureIgnoreCase))
            {
                randomOperator = randOp.Next(1, 2);
            }
            else if (diff.Equals("medium", StringComparison.CurrentCultureIgnoreCase))
            {
                randomOperator = randOp.Next(1, 3);
            }
            else if (diff.Equals("hard", StringComparison.CurrentCultureIgnoreCase))
            {
                randomOperator = randOp.Next(1, 4);
            }
            else if (diff.Equals("expert", StringComparison.CurrentCultureIgnoreCase))
            {
                randomOperator = randOp.Next(1, 5);
            }

            return randomOperator;
        }

        public int createQuestion(int streak)
        {
            string diff = difficulty.determineDiff(streak);
            int value = determineOperator(diff);

            int num1 = randNum(diff, streak);
            int num2 = randNum(diff, streak);

            while (num1 < num2)
            {
                num1 = randNum(diff, streak);
                num2 = randNum(diff, streak);
            }

            if (value == 1)
            {
                answer = num1 + num2;
            }
            else if (value == 2)
            {
                answer = num1 - num2;
            }
            else if (value == 3)
            {
                answer = num1 * num2;
            }
            else
            {
                answer = num1 / num2;
            }
            Console.WriteLine(num1 + operators[value - 1] + num2);

            return answer;
        }

        public void generateQuestion(int streak)
        {
            createQuestion(streak);
        }
    }
}