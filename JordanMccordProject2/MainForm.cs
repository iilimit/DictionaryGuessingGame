using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Timer = System.Windows.Forms.Timer;

namespace JordanMccordProject2
{
    public partial class MainForm : Form
    {
        private List<char> bag;
        private Timer time;
        private int currentTime;
        private List<char> drawnLetters;
        private readonly string invalidLetterError = "Invalid letter";

        public int score
        {
            get;
            set;
        }

        public List<string> correctlyGuessedWords
        {
            get;
            set;
        }

        public MainForm()
        {
            InitializeComponent();
            this.bag = new List<char>();
            this.drawnLetters = new List<char>();
            this.correctlyGuessedWords = new List<string>();
            this.fillBag();
            this.drawRandomLetters();
            this.score = 0;
            this.givenLettersLabel.Text = string.Join(",", this.drawnLetters);
            this.currentTime = 30;
            this.timeLeftLabel.Text = this.currentTime.ToString();
            this.time = new Timer();
            timer.Interval = 1000; 
            this.timer.Tick += TimerOnTick;
        }

        private void drawRandomLetters()
        {
            var rand = new Random();

            for (int i = 0; i < 7; i++)
            {
                int randomInt = rand.Next(this.bag.Count);
                this.drawnLetters.Add(this.bag.ElementAt(randomInt));
            }
        }

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

            for (int i = 0; i < 2; i++)
            {
                this.bag.AddRange(twoLetter);
            }

            for (int i = 0; i < 3; i++)
            {
                this.bag.AddRange(threeLetter);
            }

            for (int i = 0; i < 4; i++)
            {
                this.bag.Add('l');
            }

            for (int i = 0; i < 5; i++)
            {
                this.bag.AddRange(fiveLetter);
            }

            for (int i = 0; i < 6; i++)
            {
                this.bag.AddRange(sixLetter);
            }

            for (int i = 0; i < 8; i++)
            {
                this.bag.Add('o');
            }

            for (int i = 0; i < 9; i++)
            {
                this.bag.Add('t');
            }
            for (int i = 0; i < 11; i++)
            {
                this.bag.Add('e');
            }
        }

        //works
        private bool checkValidWord(string word)
        {
            string path =
                "C:\\Users\\jorda\\source\\repos\\jmccord8\\JordanMccordProject2\\JordanMccordProject2\\dictionary.txt";
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (line.Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private void updateScore(string word)
        {
            int wordLength = word.Length;
            int points = 0;

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

            this.score += points;
        }

        private void setTo60SecsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.updateTimer(60);
        }

        private void setTo120SecsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.updateTimer(120);
        }

        private void setTo180SecsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.updateTimer(180);
        }

        private void TimerOnTick(object? sender, EventArgs e)
        {
            this.currentTime--;
            this.timeLeftLabel.Text = this.currentTime.ToString();

            if (this.currentTime <= 0)
            {
                this.endGame();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.timer.Start();
            this.userWordTextBox.Enabled = true;
            this.startButton.Enabled = false;
            this.twistButton.Enabled = true;
        }

        private void endGame()
        {
            this.timer.Stop();
            this.submitButton.Enabled = false;
            this.userWordTextBox.Enabled = false;
            this.startButton.Enabled = false;
            this.twistButton.Enabled = false;
            EndGame eg = new EndGame(this);
            eg.ShowDialog();
        }

        private void updateTimer(int value)
        {
            this.currentTime = value;
            this.timeLeftLabel.Text = this.currentTime.ToString();
        }

        private void refreshScore()
        {
            this.scoreCountLabel.Text = score.ToString();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string submittedWord = this.userWordTextBox.Text;


            if(guesedWordsListBox.Items.Contains(submittedWord))
            {
                statusLabel.Text = "Word already guessed";
                this.userWordTextBox.Clear();
            }
            else if (checkValidWord(submittedWord))
            {
                updateScore(submittedWord);
                refreshScore();
                this.userWordTextBox.Clear();
                statusLabel.Text = $"Points added for '{submittedWord}'";
                this.correctlyGuessedWords.Add(submittedWord);
                this.addItemsToListBox(this.correctlyGuessedWords);
            }
            else
            {
                statusLabel.Text = "Word not found";
                this.userWordTextBox.Clear();
            }
        }

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

        private void userWordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.submitButton_Click(this, new EventArgs());
            }
        }

        private void twistButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            var shuffled = this.drawnLetters.OrderBy(_ => rand.Next()).ToList();
            this.drawnLetters.Clear();
            this.drawnLetters = shuffled;
            this.givenLettersLabel.Text = string.Join(",", this.drawnLetters);
        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void addItemsToListBox(List<string> words)
        {
            this.guesedWordsListBox.Items.Clear();
            foreach (var word in words)
            {
                this.guesedWordsListBox.Items.Add(word);
            }
        }
    }
}