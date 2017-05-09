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
            string currDiff = "";
            if (streak >= 1 && streak < 10)
            {
                currDiff = "easy";
            }
            else if (streak >= 10 && streak < 20)
            {
                currDiff = "medium";
            }
            else if (streak >= 20 && streak < 30)
            {
                currDiff = "hard";
            }
            else if (streak >= 30)
            {
                currDiff = "expert";
            }
            return currDiff;
        }
    }
}
