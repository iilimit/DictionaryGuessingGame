using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JordanMccordProject2
{
    public partial class AddHighScoreDialog : Form
    {
        public string Name { get; set; }

        public AddHighScoreDialog()
        {
            InitializeComponent();
        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.Name == string.Empty)
                {
                    throw new Exception();
                }
                this.Name = this.nameTextBox.Text;
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Missing or incorrect data.");
                DialogResult = DialogResult.None;
            }
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
