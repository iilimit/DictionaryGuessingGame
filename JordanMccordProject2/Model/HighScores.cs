using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordanMccordProject2.Model
{
    public class HighScores
    {
        public List<HighScore> Scores { get; }

        public HighScores()
        {
            this.Scores = new List<HighScore>();
        }

        public void addScore(string name, int score, int time)
        {
            this.Scores.Add(new HighScore(name,score,time));
        }
    }
}
