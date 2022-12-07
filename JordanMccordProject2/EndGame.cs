﻿using JordanMccordProject2.Model;

namespace JordanMccordProject2;

/// <summary>
///     EndGame class
/// </summary>
/// <seealso cref="System.Windows.Forms.Form" />
public partial class EndGame : Form
{
    #region Data members

    /// <summary>
    ///     The main form
    /// </summary>
    private readonly MainForm mainForm;

    /// <summary>
    ///     The final high scores
    /// </summary>
    private readonly HighScores _finalHighScores;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="EndGame" /> class.
    /// </summary>
    /// <param name="callingForm">The calling form.</param>
    /// <exception cref="System.InvalidOperationException"></exception>
    public EndGame(Form callingForm)
    {
        this.InitializeComponent();
        this.mainForm = callingForm as MainForm ?? throw new InvalidOperationException();
        this.finalScoreLabel.Text = this.mainForm.Score.ToString();
        this._finalHighScores = this.mainForm.HighScores;
        foreach (var item in this.mainForm.CorrectlyGuessedWords)
        {
            this.correctWordsListBox.Items.Add(item);
        }
    }

    #endregion
}