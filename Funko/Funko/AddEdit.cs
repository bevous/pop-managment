using System;
using System.Windows.Forms;

namespace Funko
{
    /// <summary>
    /// The add edit.
    /// </summary>
    public partial class AddEdit : Form
    {
        /// <summary>
        /// Gets or sets the edit form pop.
        /// </summary>
        public Pop EditFormPop { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddEdit"/> class.
        /// </summary>
        public AddEdit()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// signals that the user is done entering values.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void DoneButton_Click(object sender, EventArgs e)
        {
            bool IsNumber = int.TryParse(this.NumberTextBox.Text, out var NewNumber);
            bool IsSize = int.TryParse(this.SizeTextBox.Text, out var NewSize);
            var name = this.NameTextBox.Text;
            var type = this.TypeTextBox.Text;
            if (IsNumber && 
                IsSize && 
                this.NameTextBox.Text != string.Empty && 
                this.TypeTextBox.Text != string.Empty)
            {
                this.EditFormPop = new Pop
                                       {
                                           Name = name,
                                           Number = NewNumber,
                                           Exclusive = this.ExclusiveCheckBox.Checked,
                                           Size = NewSize,
                                           Type = type
                                       };
            }
            else
            {
                if (!IsNumber)
                {
                    this.NumberTextBox.BackColor = Color.Red;
                } // else, is a number DoNothing();

                if (!IsSize)
                {
                    this.SizeTextBox.BackColor = Color.Red;
                } // else, is valid size DoNothing();

                this.DialogResult = DialogResult.None;
            }
        }
    }
}
