namespace JordanMccordProject2.Model;

/// <summary>
/// HighScore class
/// </summary>
/// <seealso />
public class HighScore : IComparable<HighScore>
{
    #region Properties

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name { get; set; }
    /// <summary>
    /// Gets or sets the score.
    /// </summary>
    /// <value>
    /// The score.
    /// </value>
    public int Score { get; set; }
    /// <summary>
    /// Gets or sets the time.
    /// </summary>
    /// <value>
    /// The time.
    /// </value>
    public int Time { get; set; }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="HighScore"/> class.
    /// </summary>
    public HighScore()
    {
        this.Name = string.Empty;
        this.Score = 0;
        this.Time = 30;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="HighScore"/> class.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="score">The score.</param>
    /// <param name="time">The time.</param>
    public HighScore(string name, int score, int time)
    {
        this.Name = name;
        this.Score = score;
        this.Time = time;
    }

    #endregion

    #region Methods

    /// <summary>
    /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
    /// </summary>
    /// <param name="other">An object to compare with this instance.</param>
    /// <returns>
    /// A value that indicates the relative order of the objects being compared. The return value has these meanings:
    /// <list type="table"><listheader><term> Value</term><description> Meaning</description></listheader><item><term> Less than zero</term><description> This instance precedes <paramref name="other" /> in the sort order.</description></item><item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="other" />.</description></item><item><term> Greater than zero</term><description> This instance follows <paramref name="other" /> in the sort order.</description></item></list>
    /// </returns>
    public int CompareTo(HighScore? other)
    {
        if (this.Score < other.Score)
        {
            return 1;
        }

        if (this.Score > other.Score)
        {
            return -1;
        }

        return 0;
    }

    /// <summary>
    /// Converts to string.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
        return $"Score: {this.Score}, Name: {this.Name}, Time: {this.Time}s";
    }

    #endregion
}