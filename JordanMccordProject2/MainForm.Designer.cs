﻿namespace JordanMccordProject2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.submitButton = new System.Windows.Forms.Button();
            this.userWordTextBox = new System.Windows.Forms.TextBox();
            this.givenLettersLabel = new System.Windows.Forms.Label();
            this.guesedWordsListBox = new System.Windows.Forms.ListBox();
            this.guessedWordlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(201, 173);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // userWordTextBox
            // 
            this.userWordTextBox.Location = new System.Drawing.Point(191, 112);
            this.userWordTextBox.Name = "userWordTextBox";
            this.userWordTextBox.Size = new System.Drawing.Size(100, 23);
            this.userWordTextBox.TabIndex = 1;
            // 
            // givenLettersLabel
            // 
            this.givenLettersLabel.AutoSize = true;
            this.givenLettersLabel.Location = new System.Drawing.Point(192, 54);
            this.givenLettersLabel.Name = "givenLettersLabel";
            this.givenLettersLabel.Size = new System.Drawing.Size(99, 15);
            this.givenLettersLabel.TabIndex = 2;
            this.givenLettersLabel.Text = "givenLettersLabel";
            // 
            // guesedWordsListBox
            // 
            this.guesedWordsListBox.FormattingEnabled = true;
            this.guesedWordsListBox.ItemHeight = 15;
            this.guesedWordsListBox.Location = new System.Drawing.Point(383, 54);
            this.guesedWordsListBox.Name = "guesedWordsListBox";
            this.guesedWordsListBox.Size = new System.Drawing.Size(175, 214);
            this.guesedWordsListBox.TabIndex = 3;
            // 
            // guessedWordlabel
            // 
            this.guessedWordlabel.AutoSize = true;
            this.guessedWordlabel.Location = new System.Drawing.Point(383, 36);
            this.guessedWordlabel.Name = "guessedWordlabel";
            this.guessedWordlabel.Size = new System.Drawing.Size(89, 15);
            this.guessedWordlabel.TabIndex = 4;
            this.guessedWordlabel.Text = "Guessed words:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(53, 62);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 15);
            this.scoreLabel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time Left:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessedWordlabel);
            this.Controls.Add(this.guesedWordsListBox);
            this.Controls.Add(this.givenLettersLabel);
            this.Controls.Add(this.userWordTextBox);
            this.Controls.Add(this.submitButton);
            this.Name = "MainForm";
            this.Text = "Text Twist by McCord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button submitButton;
        private TextBox userWordTextBox;
        private Label givenLettersLabel;
        private ListBox guesedWordsListBox;
        private Label guessedWordlabel;
        private Label label1;
        private Label scoreLabel;
        private Label label2;
        private System.Windows.Forms.Timer timer;
    }
}