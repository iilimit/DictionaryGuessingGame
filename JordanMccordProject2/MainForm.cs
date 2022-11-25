namespace JordanMccordProject2
{
    public partial class MainForm : Form
    {
        private List<char> letters;
        public MainForm()
        {
           // InitializeComponent();
            Console.WriteLine(checkValidWord("Hello"));
        }


        private bool checkValidWord(string word)
        {
            //Fix path
            string path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "dictionary.txt");
            string[] lines = System.IO.File.ReadAllLines(path);

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                if (word.Equals(line, StringComparison.OrdinalIgnoreCase))
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