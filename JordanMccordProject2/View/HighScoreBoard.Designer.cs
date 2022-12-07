namespace JordanMccordProject2.View
{
    partial class HighScoreBoard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byTimeAndScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoreBoardListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byScoreToolStripMenuItem,
            this.byTimeAndScoreToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.viewToolStripMenuItem.Text = "&Sort";
            // 
            // byScoreToolStripMenuItem
            // 
            this.byScoreToolStripMenuItem.Name = "byScoreToolStripMenuItem";
            this.byScoreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.byScoreToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.byScoreToolStripMenuItem.Text = "By &Score";
            this.byScoreToolStripMenuItem.Click += new System.EventHandler(this.byScoreToolStripMenuItem_Click);
            // 
            // byTimeAndScoreToolStripMenuItem
            // 
            this.byTimeAndScoreToolStripMenuItem.Name = "byTimeAndScoreToolStripMenuItem";
            this.byTimeAndScoreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.byTimeAndScoreToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.byTimeAndScoreToolStripMenuItem.Text = "By &Time and Score";
            // 
            // highScoreBoardListBox
            // 
            this.highScoreBoardListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highScoreBoardListBox.FormattingEnabled = true;
            this.highScoreBoardListBox.ItemHeight = 21;
            this.highScoreBoardListBox.Location = new System.Drawing.Point(12, 27);
            this.highScoreBoardListBox.Name = "highScoreBoardListBox";
            this.highScoreBoardListBox.Size = new System.Drawing.Size(343, 319);
            this.highScoreBoardListBox.TabIndex = 1;
            // 
            // HighScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 354);
            this.Controls.Add(this.highScoreBoardListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HighScoreBoard";
            this.Text = "HighScoreBoard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem byScoreToolStripMenuItem;
        private ToolStripMenuItem byTimeAndScoreToolStripMenuItem;
        private ListBox highScoreBoardListBox;
    }
}