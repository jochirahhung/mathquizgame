using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class questionGenerator
    {
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

        private int determineOperator(string diff, int streak)
        {
            int answer = 0;
            int randomOperator;
            diff = difficulty.determineDiff(streak);
            return answer;
        }

        private int additionOperator(int number, int number2)
        {
            
        }

        private int subtractionOperator(int number, int number2)
        {

        }

        private int multiplicationOperator(int number, int number2)
        {

        }

        private int divisionOperator(int number, int number2)
        {

        }

        public void generateQuestion()
        {
            num1 = firstNum();
            num2 = secondNum();
            determineOperator();
        }


    }
}
