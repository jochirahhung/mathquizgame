using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class Game
    {
        questionGenerator questGen = new questionGenerator();
        Difficulty diff = new Difficulty();
        static void Main(string[] args)
        {
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
                if (playerAnswer == questGen.answer.ToString())
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