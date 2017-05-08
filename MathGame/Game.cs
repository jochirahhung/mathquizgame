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
            questGen.generateQuestion(streak);
            string playerAnswer = Console.ReadLine();
            if (playerAnswer == questGen.answer.ToString())
            {
                Console.WriteLine("Correct!");
            }
            else{
                Console.WriteLine("Incorrect :(");
            }
        }
    }
}
