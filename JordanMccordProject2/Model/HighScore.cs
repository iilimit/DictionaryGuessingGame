using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordanMccordProject2.Model
{

    public class HighScore : IComparable<HighScore>
    {
        public string name { get; set; }
        public int score { get; set; }
        public int time { get; set; }

        public HighScore()
        {
            this.name = string.Empty;
            this.score = 0;
            this.time = 30;
        }


        public HighScore(string name, int score, int time)
        {
            this.name = name;
            this.score = score;
            this.time = time;
        }

        public int CompareTo(HighScore? other)
        {
            if (this.score < other.score)
            {
                return 1;
            } else if (this.score > other.score)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Score: {this.score}, Name: {this.name}, Time: {this.time}s";
        }
    }
}
