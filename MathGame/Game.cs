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
                questGen.generateQuestion(streak);
                string playerAnswer = Console.ReadLine();
                if (playerAnswer == questGen.answer.ToString())
                {
                    Console.WriteLine("Correct!");
                    streak+=1;
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect :(");
                    loseStreak++;
                    streak--;
                }
            }
            if (loseStreak == 3)
            {
                Console.WriteLine("Game Over");
                Console.WriteLine(score);
            }
        }
    }
}