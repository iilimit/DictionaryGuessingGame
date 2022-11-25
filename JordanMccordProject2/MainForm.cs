using System.Windows.Forms.VisualStyles;

namespace JordanMccordProject2
{
    public partial class MainForm : Form
    {
        private List<char> letters;
        public MainForm()
        {
            InitializeComponent();

        }


        //works
        private bool checkValidWord(string word)
        {
            string path =
                "C:\\Users\\jmccord8\\source\\repos\\JordanMccordProject2\\JordanMccordProject2\\dictionary.txt";
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
    }
}