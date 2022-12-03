namespace JordanMccordProject2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTo60SecsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTo120SecsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTo180SecsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startButton = new System.Windows.Forms.Button();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.scoreCountLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.twistButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(201, 160);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // userWordTextBox
            // 
            this.userWordTextBox.Enabled = false;
            this.userWordTextBox.Location = new System.Drawing.Point(191, 112);
            this.userWordTextBox.Name = "userWordTextBox";
            this.userWordTextBox.Size = new System.Drawing.Size(100, 23);
            this.userWordTextBox.TabIndex = 1;
            this.userWordTextBox.TextChanged += new System.EventHandler(this.userWordTextBox_TextChanged);
            this.userWordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userWordTextBox_KeyDown);
            // 
            // givenLettersLabel
            // 
            this.givenLettersLabel.AutoSize = true;
            this.givenLettersLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.givenLettersLabel.Location = new System.Drawing.Point(201, 54);
            this.givenLettersLabel.Name = "givenLettersLabel";
            this.givenLettersLabel.Size = new System.Drawing.Size(132, 21);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewGameToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // startNewGameToolStripMenuItem
            // 
            this.startNewGameToolStripMenuItem.Name = "startNewGameToolStripMenuItem";
            this.startNewGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.startNewGameToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.startNewGameToolStripMenuItem.Text = "Start &New Game";
            this.startNewGameToolStripMenuItem.Click += new System.EventHandler(this.startNewGameToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exitGameToolStripMenuItem.Text = "&Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.timerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setTo60SecsToolStripMenuItem,
            this.setTo120SecsToolStripMenuItem,
            this.setTo180SecsToolStripMenuItem});
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.timerToolStripMenuItem.Text = "&Timer";
            // 
            // setTo60SecsToolStripMenuItem
            // 
            this.setTo60SecsToolStripMenuItem.Name = "setTo60SecsToolStripMenuItem";
            this.setTo60SecsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.setTo60SecsToolStripMenuItem.Text = "Set To &60 secs";
            this.setTo60SecsToolStripMenuItem.Click += new System.EventHandler(this.setTo60SecsToolStripMenuItem_Click);
            // 
            // setTo120SecsToolStripMenuItem
            // 
            this.setTo120SecsToolStripMenuItem.Name = "setTo120SecsToolStripMenuItem";
            this.setTo120SecsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.setTo120SecsToolStripMenuItem.Text = "Set To 1&20 secs";
            this.setTo120SecsToolStripMenuItem.Click += new System.EventHandler(this.setTo120SecsToolStripMenuItem_Click);
            // 
            // setTo180SecsToolStripMenuItem
            // 
            this.setTo180SecsToolStripMenuItem.Name = "setTo180SecsToolStripMenuItem";
            this.setTo180SecsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.setTo180SecsToolStripMenuItem.Text = "Set To 1&80 secs";
            this.setTo180SecsToolStripMenuItem.Click += new System.EventHandler(this.setTo180SecsToolStripMenuItem_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(201, 200);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Location = new System.Drawing.Point(67, 36);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(38, 15);
            this.timeLeftLabel.TabIndex = 10;
            this.timeLeftLabel.Text = "label3";
            // 
            // scoreCountLabel
            // 
            this.scoreCountLabel.AutoSize = true;
            this.scoreCountLabel.Location = new System.Drawing.Point(48, 63);
            this.scoreCountLabel.Name = "scoreCountLabel";
            this.scoreCountLabel.Size = new System.Drawing.Size(13, 15);
            this.scoreCountLabel.TabIndex = 11;
            this.scoreCountLabel.Text = "0";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(191, 138);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 15);
            this.statusLabel.TabIndex = 12;
            // 
            // twistButton
            // 
            this.twistButton.Enabled = false;
            this.twistButton.Location = new System.Drawing.Point(201, 240);
            this.twistButton.Name = "twistButton";
            this.twistButton.Size = new System.Drawing.Size(75, 23);
            this.twistButton.TabIndex = 13;
            this.twistButton.Text = "Twist";
            this.twistButton.UseVisualStyleBackColor = true;
            this.twistButton.Click += new System.EventHandler(this.twistButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 307);
            this.Controls.Add(this.twistButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.scoreCountLabel);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessedWordlabel);
            this.Controls.Add(this.guesedWordsListBox);
            this.Controls.Add(this.givenLettersLabel);
            this.Controls.Add(this.userWordTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Text Twist by McCord";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem timerToolStripMenuItem;
        private ToolStripMenuItem setTo60SecsToolStripMenuItem;
        private ToolStripMenuItem setTo120SecsToolStripMenuItem;
        private ToolStripMenuItem setTo180SecsToolStripMenuItem;
        private Button startButton;
        private Label timeRemainingLabel;
        private Label timeLeftLabel;
        private Label scoreCountLabel;
        private Label statusLabel;
        private Button twistButton;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem startNewGameToolStripMenuItem;
        private ToolStripMenuItem exitGameToolStripMenuItem;
    }
}