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
        Random rand2 = new Random();
        Difficulty difficulty = new Difficulty();
        int num1;
        int num2;
        private int firstNum(string diff, int streak)
        {
            int number1 = 0;
            diff = difficulty.determineDiff(streak);
            return number1;
        }

        private int secondNum(string diff, int streak)
        {
            int number2 = 0;
            diff = difficulty.determineDiff(streak);
            return number2;
        }

        public int determineOperator(string diff, int streak)
        {
            Random randOp = new Random();
            int answer = 0;
            int randomOperator = 0;
            diff = difficulty.determineDiff(streak);
            if (diff.Equals("easy", StringComparison.CurrentCultureIgnoreCase))
            {
                randomOperator = randOp.Next(1, 3);
                num1 = rand.Next(1, 11);
                num2 = rand.Next(1, 11);
                if (randomOperator == 1)
                {
                    answer = additionOperator(num1, num2);
                }
                else
                {
                    answer = subtractionOperator(num1, num2);
                }
            }
            else if (diff.Equals("medium", StringComparison.CurrentCultureIgnoreCase))
            {
                randomOperator = randOp.Next(1, 4);
                num1 = rand.Next(1, 21);
                num2 = rand.Next(1, 21);
                if (randomOperator == 1)
                {
                    answer = additionOperator(num1, num2);
                }
                else if(randomOperator == 2)
                {
                    answer = subtractionOperator(num1, num2);
                }
                else
                {
                    answer = multiplicationOperator(num1, num2);
                }
            }
            else if(diff.Equals("hard", StringComparison.CurrentCultureIgnoreCase))
            {
                randomOperator = randOp.Next(1, 5);
                num1 = rand.Next(1, 51);
                num2 = rand.Next(1, 51);
                if (randomOperator == 1)
                {
                    answer = additionOperator(num1, num2);
                }
                else if (randomOperator == 2)
                {
                    answer = subtractionOperator(num1, num2);
                }
                else if(randomOperator == 3)
                {
                    answer = multiplicationOperator(num1, num2);
                }
                else
                {
                    answer = divisionOperator(num1, num2);
                }
            }
            else if (diff.Equals("expert", StringComparison.CurrentCultureIgnoreCase))
            {
                randomOperator = randOp.Next(1, 5);
                num1 = rand.Next(1, 101);
                num2 = rand.Next(1, 101);
                if (randomOperator == 1)
                {
                    answer = additionOperator(num1, num2);
                }
                else if (randomOperator == 2)
                {
                    answer = subtractionOperator(num1, num2);
                }
                else if (randomOperator == 3)
                {
                    answer = multiplicationOperator(num1, num2);
                }
                else
                {
                    answer = divisionOperator(num1, num2);
                }
            }
            Console.WriteLine(answer);
            return answer;
        }

        private int additionOperator(int number, int number2)
        {
            return number + number2;
        }

        private int subtractionOperator(int number, int number2)
        {
            return number - number2;
        }

        private int multiplicationOperator(int number, int number2)
        {
            return number * number2;
        }

        private int divisionOperator(int number, int number2)
        {
            return number / number2;
        }

        public void generateQuestion(string diff, int streak)
        {
            determineOperator(diff, streak);
        }


    }
}
