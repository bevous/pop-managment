using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funko
{
    public partial class AddEdit : Form
    {

        public Pop EditFormPop { get; set; }
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
            if (IsNumber && 
                IsSize && 
                this.NameTextBox.Text != string.Empty && 
                this.TypeTextBox.Text != string.Empty)
            {
                this.EditFormPop = new Pop
                                       {
                                           Name = this.NameTextBox.Text,
                                           Number = NewNumber,
                                           Exclusive = this.ExclusiveCheckBox.Checked,
                                           Size = NewSize,
                                           Type = this.TypeTextBox.Text
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
