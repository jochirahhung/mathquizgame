using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MathGame
{
    public class Game
    {
        questionGenerator questGen = new questionGenerator();
        Difficulty diff = new Difficulty();
        static void Main(string[] args)
        {
            Console.WriteLine("Rules:");
            Console.WriteLine("Welcome Everyone. This is our Math Game.");
            Console.WriteLine("Every 10 questions you get right, will increase in difficulty!");
            Console.WriteLine("Each time you go up in difficulty, you get more points for answering the question right!");
            Console.WriteLine("Getting one question wrong, decreases your streak by one, getting three wrong and you lose, have fun.");
            Console.WriteLine("When dividing, it rounds it up two decimal places, so do not exceed that please, or you get that wrong.");
            Console.WriteLine("");
            Game g = new Game();
            g.gameLoop();
        }

        public void gameLoop()
        {
            int streak = 1;
            int loseStreak = 0;
            int score = 0;
            while (loseStreak <= 2)
            {
                Console.WriteLine("Streak: " + streak);
                Console.WriteLine("Questions Wrong: " + loseStreak);
                Console.WriteLine("Score: " + score + " points");
                Console.WriteLine(" ");
                questGen.generateQuestion(streak);
                string playerAnswer = Console.ReadLine();
                double realAnswer = 0.0;
                double.TryParse(playerAnswer, out realAnswer);

                if (realAnswer == questGen.answer)
                {
                    Console.WriteLine("Correct! :)");
                    Console.WriteLine(" ");
                    streak += 1;
                    if (streak >= 0 && streak < 11)
                    {
                        score += 1;
                    }
                    else if (streak >= 11 && streak < 21)
                    {
                        score += 2;
                    }
                    else if (streak >= 21 && streak < 31)
                    {
                        score += 3;
                    }
                    else if (streak >= 31)
                    {
                        score += 4;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect :(");
                    Console.WriteLine(" ");
                    loseStreak++;
                    streak -= 1;
                    if (streak == 0)
                    {
                        streak = 1;
                    }
                }
            }
            if (loseStreak == 3)
            {
                Console.WriteLine("You got 3 questions wrong.  Game Over!");
                Console.WriteLine(" ");
                Console.WriteLine("Your final score: " + score + " points");
            }
        }
    }

}