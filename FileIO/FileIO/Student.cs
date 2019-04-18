namespace FileIO
{
    public class Student
    {
        private int id;

        private string firstName;

        private string lastName;

        private double gpa;


        public int Id
        {
            get => this.id;
            set => this.id = value > 0 ? value : 0;
        }

        public string FirstName
        {
            get => this.firstName;
            set => this.firstName = value ?? string.Empty;
        }

        public string LastName
        {
            get => this.lastName;
            set => this.lastName = value ?? string.Empty;
        }

        public double Gpa
        {
            get => this.gpa;
            set => this.gpa = value.CompareTo(0.0) >= 0 && 
                              value.CompareTo(4.0) <= 0 ? value : 0.0;
        }

        public string FileString => $"{this.Id}|{this.FirstName}|{this.lastName}|{this.gpa:F2}";

        public override bool Equals(object obj)
        {
            if (obj is Student)
            {
                var that = obj as Student;
                return (this.Id, this.FirstName, this.LastName, this.Gpa).Equals(
                    (that.Id, that.FirstName, that.LastName, that.Gpa));
            }

            return false;
        }

        public override int GetHashCode() => 
            (this.Id, this.FirstName, this.LastName, this.Gpa).GetHashCode();

        public static bool operator ==(Student lhs, Student rhs) =>
            (!object.ReferenceEquals(lhs, null)) && lhs.Equals(rhs);

        public static bool operator !=(Student lhs, Student rhs) => !(lhs == rhs);

        public override string ToString() => 
            $"{this.Id} - {this.LastName}, {this.FirstName} {this.Gpa:F2}";
    }
}
