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
            gameLoop();
        }

        public void gameLoop()
        {
            int streak = 0;
            questGen.generateQuestion();
        }
    }
}
