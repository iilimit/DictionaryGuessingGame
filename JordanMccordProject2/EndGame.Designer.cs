namespace JordanMccordProject2
{
    partial class EndGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.correctWordsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.finalScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // correctWordsListBox
            // 
            this.correctWordsListBox.FormattingEnabled = true;
            this.correctWordsListBox.ItemHeight = 15;
            this.correctWordsListBox.Location = new System.Drawing.Point(278, 73);
            this.correctWordsListBox.Name = "correctWordsListBox";
            this.correctWordsListBox.Size = new System.Drawing.Size(222, 154);
            this.correctWordsListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correctly guessed words:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(184, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "GAME OVER!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Your final score is: ";
            // 
            // finalScoreLabel
            // 
            this.finalScoreLabel.AutoSize = true;
            this.finalScoreLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finalScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.finalScoreLabel.Location = new System.Drawing.Point(112, 96);
            this.finalScoreLabel.Name = "finalScoreLabel";
            this.finalScoreLabel.Size = new System.Drawing.Size(38, 45);
            this.finalScoreLabel.TabIndex = 4;
            this.finalScoreLabel.Text = "0";
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 240);
            this.Controls.Add(this.finalScoreLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.correctWordsListBox);
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox correctWordsListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label finalScoreLabel;
        private Button button1;
    }
}