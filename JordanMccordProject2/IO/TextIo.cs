using JordanMccordProject2.Model;

namespace JordanMccordProject2.IO;

/// <summary>
/// TextIo class
/// </summary>
public class TextIo
{
    #region Methods

    /// <summary>
    /// Writes cars to files
    /// </summary>
    /// <param name="path">The path.</param>
    /// <param name="records">The records.</param>
    public void writeViaStreamWriter(string path, HighScores records)
    {
        //change file Name to highscores.txt or something
        using (var outputFile = new StreamWriter(path, true))
        {
            foreach (var record in records.Scores)
            {
                var build = $"{record.Name},{record.Score},{record.Time}";
                outputFile.WriteLine(build);
            }
        }
    }

    /// <summary>
    /// Reads cars from file
    /// </summary>
    /// <returns></returns>
    public HighScores readViaStreamRead()
    {
        var scores = new HighScores();
        try
        {
            using (var sr = new StreamReader(
                       "C:\\Users\\jorda\\Source\\Repos\\jmccord8\\JordanMccordProject2\\JordanMccordProject2\\highscores.csv"))
            {
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine()?.Split(',');
                    if (line != null)
                    {
                        var name = line[0];
                        var score = Convert.ToInt16(line[1]);
                        var time = Convert.ToInt16(line[2]);
                        scores.addScore(name, score, time);
                    }
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            MessageBox.Show(ex.Message);
        }

        return scores;
    }

    #endregion
}