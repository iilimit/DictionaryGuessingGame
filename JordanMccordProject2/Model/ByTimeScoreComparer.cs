namespace JordanMccordProject2.Model;

/// <summary>
/// ByTimeScoreComparer Class
/// </summary>
/// <seealso />
public class ByTimeScoreComparer : IComparer<HighScore>
{
    #region Methods

    /// <summary>
    /// Compares the specified score1.
    /// </summary>
    /// <param name="score1">The score1.</param>
    /// <param name="score2">The score2.</param>
    /// <returns></returns>
    /// <exception cref="System.ArgumentException"></exception>
    public int Compare(HighScore? score1, HighScore? score2)
    {
        if (score2 == null && score1 == null)
        {
            throw new ArgumentException();
        }

        if (score1.Time < score2.Time)
        {
            return 1;
        }

        if (score1.Time > score2.Time)
        {
            return -1;
        }

        return score2.Score.CompareTo(score1.Score);
    }

    #endregion
}