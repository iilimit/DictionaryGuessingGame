using JordanMccordProject2.IO;
using JordanMccordProject2.Model;

namespace JordanMccordProject2.View;

/// <summary>
/// HighScoreBoard Class
/// </summary>
/// <seealso cref="System.Windows.Forms.Form" />
public partial class HighScoreBoard : Form
{
    #region Data members

    /// <summary>
    /// The text io
    /// </summary>
    private readonly TextIo textIo;
    /// <summary>
    /// The high scores
    /// </summary>
    private HighScores highScores;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="HighScoreBoard"/> class.
    /// </summary>
    public HighScoreBoard()
    {
        this.InitializeComponent();
        this.textIo = new TextIo();
        this.highScores = new HighScores();
        this.readIntoBoard();
    }

    #endregion

    #region Methods

    /// <summary>
    /// Reads the into board.
    /// </summary>
    private void readIntoBoard()
    {
        this.highScores = this.textIo.readViaStreamRead();
        this.addScoresToListBox();
    }

    /// <summary>
    /// Handles the Click event of the byScoreToolStripMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void byScoreToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.highScoreBoardListBox.Items.Clear();
        this.highScores.Scores.Sort();
        this.addScoresToListBox();
    }

    /// <summary>
    /// Handles the Click event of the clearAllScoresToolStripMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void clearAllScoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
        File.WriteAllText(MainForm.HighScorePath, string.Empty);
        this.highScoreBoardListBox.Items.Clear();
    }

    /// <summary>
    /// Adds the scores to ListBox.
    /// </summary>
    private void addScoresToListBox()
    {
        foreach (var score in this.highScores.Scores)
        {
            this.highScoreBoardListBox.Items.Add(score);
        }
    }

    /// <summary>
    /// Handles the Click event of the byTimeAndScoreToolStripMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void byTimeAndScoreToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.highScoreBoardListBox.Items.Clear();
        this.highScores.Scores.Sort(new ByTimeScoreComparer());
        this.addScoresToListBox();
    }

    #endregion
}