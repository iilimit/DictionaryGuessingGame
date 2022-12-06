﻿using JordanMccordProject2.IO;
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
using static System.Windows.Forms.DataFormats;

namespace JordanMccordProject2
{
    public partial class EndGame : Form
    {
        private readonly MainForm mainForm;
        private readonly TextIo textIo;
        private readonly HighScores finalHighScores;

        public EndGame(Form callingForm)
        {
            InitializeComponent();
            this.mainForm = callingForm as MainForm;
            this.finalScoreLabel.Text = this.mainForm.score.ToString();
            this.finalHighScores = this.mainForm.highScores;
            this.textIo = new TextIo();
            foreach (var item in mainForm.correctlyGuessedWords)
            {
                this.correctWordsListBox.Items.Add(item);
            }
        }
    }
}