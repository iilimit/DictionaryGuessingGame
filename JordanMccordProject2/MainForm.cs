using JordanMccordProject2.IO;
using JordanMccordProject2.Model;
using JordanMccordProject2.View;

namespace JordanMccordProject2;

/// <summary>
/// MainForm Class
/// </summary>
/// <seealso cref="System.Windows.Forms.Form" />
public partial class MainForm : Form
{
    #region Data members

    /// <summary>
    /// The high score path
    /// </summary>
    public const string HighScorePath = "C:\\Users\\jorda\\Source\\Repos\\jmccord8\\JordanMccordProject2\\JordanMccordProject2\\highscores.csv";
    /// <summary>
    /// The text io
    /// </summary>
    private readonly TextIo textIo;
    /// <summary>
    /// The bag
    /// </summary>
    private readonly List<char> bag;
    /// <summary>
    /// The current time
    /// </summary>
    private int currentTime;
    /// <summary>
    /// The drawn letters
    /// </summary>
    private List<char> drawnLetters;
    /// <summary>
    /// The inital time
    /// </summary>
    private int initalTime;

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    private new string Name { get; set; }

    /// <summary>
    /// Gets the high scores.
    /// </summary>
    /// <value>
    /// The high scores.
    /// </value>
    public HighScores HighScores { get; }

    /// <summary>
    /// Gets or sets the score.
    /// </summary>
    /// <value>
    /// The score.
    /// </value>
    public int Score { get; set; }

    /// <summary>
    /// Gets or sets the correctly guessed words.
    /// </summary>
    /// <value>
    /// The correctly guessed words.
    /// </value>
    public List<string> CorrectlyGuessedWords { get; set; }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class.
    /// </summary>
    public MainForm()
    {
        this.InitializeComponent();
        this.Name = string.Empty;
        this.bag = new List<char>();
        this.drawnLetters = new List<char>();
        this.CorrectlyGuessedWords = new List<string>();
        this.fillBag();
        this.drawRandomLetters();
        this.textIo = new TextIo();
        this.Score = 0;
        this.givenLettersLabel.Text = string.Join(",", this.drawnLetters);
        this.currentTime = 30;
        this.initalTime = 30;
        this.timeLeftLabel.Text = this.currentTime.ToString();
        this.HighScores = new HighScores();
        this.timer.Interval = 1000;
        this.timer.Tick += this.TimerOnTick;
    }

    #endregion

    #region Methods

    /// <summary>
    /// Draws the random letters.
    /// </summary>
    private void drawRandomLetters()
    {
        var rand = new Random();

        for (var i = 0; i < 7; i++)
        {
            var randomInt = rand.Next(this.bag.Count);
            this.drawnLetters.Add(this.bag.ElementAt(randomInt));
        }
    }

    /// <summary>
    /// Fills the bag.
    /// </summary>
    private void fillBag()
    {
        char[] oneLetter = { 'j', 'k', 'q', 'x', 'z' };
        char[] twoLetter = { 'b', 'c', 'f', 'g', 'm', 'p', 'v' };
        char[] threeLetter = { 'd', 'u', 'w', 'y' };
        char[] fiveLetter = { 'h', 'r' };
        char[] sixLetter = { 'a', 'i', 'n', 's' };

        foreach (var letter in oneLetter)
        {
            this.bag.Add(letter);
        }

        for (var i = 0; i < 2; i++)
        {
            this.bag.AddRange(twoLetter);
        }

        for (var i = 0; i < 3; i++)
        {
            this.bag.AddRange(threeLetter);
        }

        for (var i = 0; i < 4; i++)
        {
            this.bag.Add('l');
        }

        for (var i = 0; i < 5; i++)
        {
            this.bag.AddRange(fiveLetter);
        }

        for (var i = 0; i < 6; i++)
        {
            this.bag.AddRange(sixLetter);
        }

        for (var i = 0; i < 8; i++)
        {
            this.bag.Add('o');
        }

        for (var i = 0; i < 9; i++)
        {
            this.bag.Add('t');
        }

        for (var i = 0; i < 11; i++)
        {
            this.bag.Add('e');
        }
    }

    /// <summary>
    /// Checks the valid word.
    /// </summary>
    /// <param name="word">The word.</param>
    /// <returns></returns>
    private bool checkValidWord(string word)
    {
        var path =
            "C:\\Users\\jorda\\source\\repos\\jmccord8\\JordanMccordProject2\\JordanMccordProject2\\dictionary.txt";
        var lines = File.ReadAllLines(path);

        foreach (var line in lines)
        {
            if (string.Equals(line, word, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Updates the score.
    /// </summary>
    /// <param name="word">The word.</param>
    private void updateScore(string word)
    {
        var wordLength = word.Length;
        var points = 0;

        if (wordLength == 3)
        {
            points = 90;
        }
        else if (wordLength == 4)
        {
            points = 160;
        }
        else if (wordLength == 5)
        {
            points = 250;
        }
        else if (wordLength == 6)
        {
            points = 360;
        }
        else if (wordLength == 7)
        {
            points = 490;
        }

        this.Score += points;
    }

    /// <summary>
    /// Handles the Click event of the setTo60SecsToolStripMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void setTo60SecsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.updateTimer(60);
    }

    /// <summary>
    /// Handles the Click event of the setTo120SecsToolStripMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void setTo120SecsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.updateTimer(120);
    }

    /// <summary>
    /// Handles the Click event of the setTo180SecsToolStripMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void setTo180SecsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.updateTimer(180);
    }

    /// <summary>
    /// Timers the on tick.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void TimerOnTick(object? sender, EventArgs e)
    {
        this.currentTime--;
        this.timeLeftLabel.Text = this.currentTime.ToString();

        if (this.currentTime <= 0)
        {
            this.endGame();
        }
    }

    /// <summary>
    /// Handles the Click event of the startButton control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void startButton_Click(object sender, EventArgs e)
    {
        this.timer.Start();
        this.userWordTextBox.Enabled = true;
        this.startButton.Enabled = false;
        this.twistButton.Enabled = true;
    }

    /// <summary>
    /// Ends the game.
    /// </summary>
    private void endGame()
    {
        this.timer.Stop();
        this.submitButton.Enabled = false;
        this.userWordTextBox.Enabled = false;
        this.startButton.Enabled = false;
        this.twistButton.Enabled = false;
        this.openAddHighScoreDialog();
        this.HighScores.addScore(this.Name, Convert.ToInt32(this.scoreCountLabel.Text),
            Convert.ToInt32(this.initalTime));
        this.saveHighScore();
        var eg = new EndGame(this);
        eg.ShowDialog();
    }

    /// <summary>
    /// Opens the add high score dialog.
    /// </summary>
    private void openAddHighScoreDialog()
    {
        var addScoreDialog = new AddHighScoreDialog();

        if (addScoreDialog.ShowDialog() == DialogResult.OK)
        {
            this.Name = addScoreDialog.Name;
        }
    }

    /// <summary>
    /// Saves the high score.
    /// </summary>
    private void saveHighScore()
    {
        this.textIo.writeViaStreamWriter(
            HighScorePath,
            this.HighScores);
    }

    /// <summary>
    /// Updates the timer.
    /// </summary>
    /// <param name="value">The value.</param>
    private void updateTimer(int value)
    {
        this.currentTime = value;
        this.initalTime = value;
        this.timeLeftLabel.Text = this.currentTime.ToString();
    }

    /// <summary>
    /// Refreshes the score.
    /// </summary>
    private void refreshScore()
    {
        this.scoreCountLabel.Text = this.Score.ToString();
    }

    /// <summary>
    /// Handles the Click event of the submitButton control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void submitButton_Click(object sender, EventArgs e)
    {
        var submittedWord = this.userWordTextBox.Text.ToLower();

        if (this.guesedWordsListBox.Items.Contains(submittedWord))
        {
            this.statusLabel.Text = @"Word already guessed";
            this.userWordTextBox.Clear();
        }
        else if (this.checkValidWord(submittedWord))
        {
            this.updateScore(submittedWord);
            this.refreshScore();
            this.userWordTextBox.Clear();
            this.statusLabel.Text = $@"Points added for '{submittedWord}'";
            this.CorrectlyGuessedWords.Add(submittedWord);
            this.addItemsToListBox(this.CorrectlyGuessedWords);
        }
        else
        {
            this.statusLabel.Text = @"Word not found";
            this.userWordTextBox.Clear();
        }
    }

    /// <summary>
    /// Handles the TextChanged event of the userWordTextBox control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void userWordTextBox_TextChanged(object sender, EventArgs e)
    {
        if (this.userWordTextBox.Text.Length >= 3)
        {
            this.submitButton.Enabled = true;
        }
        else
        {
            this.submitButton.Enabled = false;
        }
    }

    /// <summary>
    /// Handles the KeyDown event of the userWordTextBox control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
    private void userWordTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            this.submitButton_Click(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Handles the Click event of the twistButton control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void twistButton_Click(object sender, EventArgs e)
    {
        var rand = new Random();
        var shuffled = this.drawnLetters.OrderBy(_ => rand.Next()).ToList();
        this.drawnLetters.Clear();
        this.drawnLetters = shuffled;
        this.givenLettersLabel.Text = string.Join(",", this.drawnLetters);
    }

    /// <summary>
    /// Handles the Click event of the startNewGameToolStripMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Restart();
        Environment.Exit(0);
    }

    /// <summary>
    /// Handles the Click event of the exitGameToolStripMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }

    /// <summary>
    /// Adds the items to ListBox.
    /// </summary>
    /// <param name="words">The words.</param>
    private void addItemsToListBox(List<string> words)
    {
        this.guesedWordsListBox.Items.Clear();
        foreach (var word in words)
        {
            this.guesedWordsListBox.Items.Add(word);
        }
    }

    /// <summary>
    /// Handles the Click event of the highScoreBoardToolStripMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void highScoreBoardToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var hsb = new HighScoreBoard();
        hsb.ShowDialog();
    }

    #endregion
}