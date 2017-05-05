using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class Difficulty
    {
        public string determineDiff(int streak){
            if (streak >= 1 && streak < 10)
            {
                string currDiff = "easy";
                return currDiff;
            }
            else if (streak >= 10 && streak < 20)
            {
                string currDiff = "medium";
                return currDiff;
            }
            else if (streak >= 20 && streak < 30)
            {
                string currDiff = "hard";
                return currDiff;
            }
            else if (streak >= 30)
            {
                string currDiff = "expert";
                return currDiff;
            }
            return null;
        }
    }
}
