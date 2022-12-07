namespace JordanMccordProject2.Model;

/// <summary>
/// HighScores wrapper class for HighScore
/// </summary>
public class HighScores
{
    #region Properties

    /// <summary>
    /// Gets the scores.
    /// </summary>
    /// <value>
    /// The scores.
    /// </value>
    public List<HighScore> Scores { get; }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="HighScores"/> class.
    /// </summary>
    public HighScores()
    {
        this.Scores = new List<HighScore>();
    }

    #endregion

    #region Methods

    /// <summary>
    /// Adds the score.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="score">The score.</param>
    /// <param name="time">The time.</param>
    public void addScore(string name, int score, int time)
    {
        this.Scores.Add(new HighScore(name, score, time));
    }

    #endregion
}