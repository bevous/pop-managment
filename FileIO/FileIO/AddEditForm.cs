namespace FileIO
{
    using System.Windows.Forms;

    public partial class AddEditForm : Form
    {
        public Student Student { get; private set; }

        private bool IsAdd { get; set; }

        public AddEditForm(Student student = null)
        {
            this.InitializeComponent();
            this.Student = student;
            this.IsAdd = this.Student is null;
        }

        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            var id = int.Parse(this.IdTextBox.Text);
            var firstName = this.FirstNameTextBox.Text;
            var lastName = this.LastNameTextBox.Text;
            var gpa = double.Parse(this.GpaTextBox.Text);

            this.Student = new Student { Id = id, FirstName = firstName, LastName = lastName, Gpa = gpa };

        }

        private void AddEditForm_Load(object sender, System.EventArgs e)
        {
            if (!this.IsAdd)
            {
                this.IdTextBox.Text = this.Student.Id.ToString("G");
                this.FirstNameTextBox.Text = this.Student.FirstName;
                this.LastNameTextBox.Text = this.Student.LastName;
                this.GpaTextBox.Text = this.Student.Gpa.ToString("F3");
            } // else, it is add a new student, DoNothing();
        }
    }
}
