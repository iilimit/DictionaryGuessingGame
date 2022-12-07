using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordanMccordProject2.Model
{
    public class ByTimeScoreComparer : IComparer<HighScore>
    {
        public int Compare(HighScore? score1, HighScore? score2)
        {
            if (score1.time < score2.time)
            {
                return 1;
            }
            if (score1.time > score2.time)
            {
                return -1;
            }
            return score2.score.CompareTo(score1.score);
        }
    }
}
