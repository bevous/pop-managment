namespace FileIO
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // What is the benefit of the using statement?
            // the using statement will Auto Close the resource. 
            using (var dialog = new OpenFileDialog())
            {
                // a few things to set up with the dialog box
                // the starting directory and the file filter. 
                dialog.InitialDirectory = @"C:\";
                dialog.RestoreDirectory = true;
                // Filter has the syntax of text|filter
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;

                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var fileName = dialog.FileName;
                    using (var reader = 
                        new StreamReader(
                            new FileStream(
                                fileName, FileMode.Open, FileAccess.Read)))
                    {
                        while (reader.Peek() != -1)
                        {
                            var line = reader.ReadLine();
                            // "12|Shane|May|3.6
                            var tokens = line?.Split('|');
                            var student = new Student
                                              {
                                                  Id = int.Parse(tokens[0]),
                                                  FirstName = tokens[1],
                                                  LastName = tokens[2],
                                                  Gpa = double.Parse(tokens[3])
                                              };
                            this.Students.Add(student);
                        }
                    }
                } // else, the user did not click ok, so Ok, we DoNothing();
            }

            this.BindListBox();
        }

        private void BindListBox()
        {
            this.StudentListBox.DataSource = null;
            this.StudentListBox.DataSource = this.Students;
            this.StudentListBox.ClearSelected();
            //this.StudentListBox.SelectedIndex = -1;
        }

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            if (this.StudentListBox.SelectedIndex >= 0)
            {
                var student = this.StudentListBox.SelectedItem as Student;
                var addEditForm = new AddEditForm(student);
                var result = addEditForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Students.Remove(student);
                    this.Students.Add(addEditForm.Student);
                    this.BindListBox();
                }
            }
            else
            {
                var addEditForm = new AddEditForm();
                var result = addEditForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Students.Add(addEditForm.Student);
                    this.BindListBox();
                } // else, the user clicked cancel, DoNothing();
            }
        }

        private void StudentListBox_DoubleClick(object sender, EventArgs e)
        {
            this.StudentListBox.ClearSelected();
            //this.StudentListBox.SelectedIndex = -1;
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            if (this.StudentListBox.SelectedIndex >= 0)
            {
                var confirmation = MessageBox.Show(
                    "Really delete?", 
                    "Confirm delete", 
                    MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {

                    this.Students.RemoveAt(this.StudentListBox.SelectedIndex);
                    // Maybe we should ask if they want to delete the student. 

                    this.BindListBox();
                } // else, did not confirm deletion, DoNothing();

            } // else, no student selected to delete, DoNothing();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveDialog.RestoreDirectory = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var fileOut = new StreamWriter(
                        new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write)))
                    {
                        foreach (var student in this.Students)
                        {
                            fileOut.WriteLine(student.FileString);
                        }
                    }
                } 
            }
        }
    }
}
