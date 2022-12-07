using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JordanMccordProject2.Model;

namespace JordanMccordProject2.IO
{
    public class TextIo
    {
        /// <summary>
        ///     Writes cars to files
        /// </summary>
        /// <param name="fileName">name of file</param>
        /// <param name="carLot">car lot object</param>
        public void WriteViaStreamWriter(string path, HighScores records)
        {
            string build;
            //change file name to highscores.txt or something
            using (StreamWriter outputFile = new StreamWriter(path, append: true))
            {
                foreach (var record in records.Scores)
                {
                    build = $"{record.name},{record.score},{record.time}";
                    outputFile.WriteLine(build);
                }
            }
        }

        /// <summary>
        ///     Reads cars from file
        /// </summary>
        /// <param name="fileName">name of file</param>
        /// <returns></returns>
        public HighScores ReadViaStreamRead()
        {
            var scores = new HighScores();
            try
            {
                using (var sr = new StreamReader("C:\\Users\\jorda\\Source\\Repos\\jmccord8\\JordanMccordProject2\\JordanMccordProject2\\highscores.csv"))
                {
                    while (sr.Peek() >= 0)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        var name = line[0];
                        var score = Convert.ToInt16(line[1]);
                        var time = Convert.ToInt16(line[2]);
                        scores.addScore(name, score, time);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return scores;
        }
    }

}
