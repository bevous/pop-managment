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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }
        public PopList Pops = new PopList();

        private void BindPops()
        {
            this.PopDataGridView.DataSource = null;
            this.PopDataGridView.DataSource = this.Pops;
        }

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
                    this.Pops = PopList.GetAll(fileName);
                    this.BindPops();
                } // else, the user closed the dialog box, DoNothing();
            }
        }

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

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            var entryForm = new AddEdit();
            var result = entryForm.ShowDialog(); // This creates the form as an application modal dialog form. 

            if (result == DialogResult.OK)
            {
                this.Pops.Add(entryForm.EditFormPop);
                this.BindPops();
            } // else, form Exited DoNothing();
        }
    }
}