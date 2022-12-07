using JordanMccordProject2.IO;
using JordanMccordProject2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace JordanMccordProject2.View
{
    public partial class HighScoreBoard : Form
    {
        private readonly TextIo textIo;
        private HighScores highScores;
        public HighScoreBoard()
        {
            InitializeComponent();
            textIo = new TextIo();
            highScores = new HighScores();
            readIntoBoard();
        }

        private void readIntoBoard()
        {
            highScores = textIo.ReadViaStreamRead();
            addScoresToListBox();

        }

        private void byScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.highScoreBoardListBox.Items.Clear();
            this.highScores.Scores.Sort();
            addScoresToListBox();
        }

        private void clearAllScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(MainForm.highScorePath, string.Empty);
            this.highScoreBoardListBox.Items.Clear();
        }

        private void addScoresToListBox()
        {
            foreach (var score in highScores.Scores)
            {
                this.highScoreBoardListBox.Items.Add(score);
            }
        }

        private void byTimeAndScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.highScoreBoardListBox.Items.Clear();
            this.highScores.Scores.Sort(new ByTimeScoreComparer());
            addScoresToListBox();
        }
    }
}
