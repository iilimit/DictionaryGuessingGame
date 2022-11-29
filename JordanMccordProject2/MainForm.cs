using System.Windows.Forms.VisualStyles;
using Timer = System.Windows.Forms.Timer;

namespace JordanMccordProject2
{
    public partial class MainForm : Form
    {
        private List<char> bag;
        private Timer time;
        private int currentTime;

        public MainForm()
        {
            InitializeComponent();
            this.bag = new List<char>();
            this.fillBag();
            this.givenLettersLabel.Text = this.bag.Count.ToString();
            this.currentTime = 30;
            this.timeLeftLabel.Text = this.currentTime.ToString();

            this.time = new Timer();
            timer.Interval = 1000; // One second timer
            this.timer.Tick += TimerOnTick;
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

        private int calculatePoints(string word)
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

            return points;
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
                this.timer.Stop();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.timer.Start();
        }

        private void updateTimer(int value)
        {
            this.currentTime = value;
            this.timeLeftLabel.Text = this.currentTime.ToString();
        }
    }
}