using System;
using System.Windows.Forms;

namespace Funko
{
    /// <summary>
    /// The main form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The pops.
        /// </summary>
        public PopList Pops = new PopList();

        /// <summary>
        /// binds the pops list to the control.
        /// </summary>
        private void BindPops()
        {
            this.PopDataGridView.DataSource = null;
            this.PopDataGridView.DataSource = this.Pops;
        }

        /// <summary>
        /// The open tool strip menu item_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.CheckPathExists = true;
                open.CheckFileExists = true;
                open.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                open.InitialDirectory = @"C:\";

                var result = open.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var fileName = open.FileName;
                    PopList.Delim = this.DeliminatorTextBox.Text[0];
                    this.Pops = PopList.GetAll(fileName);
                    this.BindPops();
                } // else, the user closed the dialog box, DoNothing();
            }
        }

        /// <summary>
        /// The save tool strip menu item_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var save = new SaveFileDialog())
            {
                save.CheckPathExists = true;
                save.InitialDirectory = @"C:\";
                save.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                var result = save.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var fileName = save.FileName;
                    PopList.Delim = char.Parse(this.DeliminatorTextBox.Text);
                    this.Pops.SaveAll(fileName);
                } // else, no file selected, DoNothing();
            }
        }

        /// <summary>
        /// The add edit button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AddEditButton_Click(object sender, EventArgs e)
        {
            var entryForm = new AddEdit();
            var result = entryForm.ShowDialog(); // This creates the form as an application modal dialog form. 

            if (result == DialogResult.OK)
            {
                if (!this.Pops.Contains(entryForm.EditFormPop))
                {
                    this.Pops.Add(entryForm.EditFormPop);
                    this.BindPops();
                } // else, pop exists DoNothing();
            } // else, form Exited DoNothing();
        }
    }
}