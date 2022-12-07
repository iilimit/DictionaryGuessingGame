using JordanMccordProject2.IO;
using JordanMccordProject2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach (var score in highScores.Scores)
            {
                this.highScoreBoardListBox.Items.Add(score);
            }

        }

        private void byScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.highScoreBoardListBox.Items.Clear();
            this.highScores.Scores.Sort();
            foreach (var score in highScores.Scores)
            {
                this.highScoreBoardListBox.Items.Add(score);
            }
        }
    }
}
