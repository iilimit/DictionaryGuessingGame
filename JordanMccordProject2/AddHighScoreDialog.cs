namespace JordanMccordProject2;

/// <summary>
/// AddHighScoreDialog Class
/// </summary>
/// <seealso cref="System.Windows.Forms.Form" />
public partial class AddHighScoreDialog : Form
{
    #region Properties

    /// <summary>
    /// Gets or sets the name of the control.
    /// </summary>
    public new string Name { get; set; }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="AddHighScoreDialog"/> class.
    /// </summary>
    public AddHighScoreDialog()
    {
        this.Name = string.Empty;
        this.InitializeComponent();
    }

    #endregion

    #region Methods

    /// <summary>
    /// Handles the 1 event of the submitButton_Click control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    /// <exception cref="System.Exception"></exception>
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

    /// <summary>
    /// Handles the 1 event of the cancelButton_Click control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cancelButton_Click_1(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }

    /// <summary>
    /// Handles the KeyDown event of the nameTextBox control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
    private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            this.submitButton_Click_1(this, EventArgs.Empty);
        }
    }

    #endregion
}