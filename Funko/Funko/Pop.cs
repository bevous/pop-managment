
namespace Funko
{
    /// <summary>
    /// The pop.
    /// </summary>
    public class Pop
    {
        /// <summary>
        /// The number.
        /// </summary>
        private int number;

        /// <summary>
        /// The type.
        /// </summary>
        private string type;

        /// <summary>
        /// The size.
        /// </summary>
        private int size;

        private string name;

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        public int Number
        {
            get => this.number;

            set => this.number = value > 0 ? value : 0;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type
        {
            get => this.type;
            set => this.type = value == string.Empty ? "No name given." : value;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get => this.name;
            set => this.name = value != string.Empty ? value : "no name given";
        }

        /// <summary>
        /// Gets or sets a value indicating whether exclusive.
        /// </summary>
        public bool Exclusive
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        public int Size
        {
            get => this.size;
            set => this.size = (value == 3 || value == 6 || value == 10) ? value : 3;
        }

        /// <summary>
        /// The equals.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is Pop)
            {
                var other = obj as Pop;
                return this.Number == other.Number && 
                        this.Name == other.Name && 
                        this.Type == other.Type && 
                        this.Size == other.Size;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The get hash code.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public override int GetHashCode()
        {
            return (this.Name, this.Type).GetHashCode();
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return this.Name.ToString();
        }

        /// <summary>
        /// The ==.
        /// </summary>
        /// <param name="lhs">
        /// The lhs.
        /// </param>
        /// <param name="rhs">
        /// The rhs.
        /// </param>
        /// <returns>
        /// </returns>
        public static bool operator ==(Pop lhs, Pop rhs) =>
            (!object.ReferenceEquals(lhs, null)) && lhs.Equals(rhs);

        /// <summary>
        /// The !=.
        /// </summary>
        /// <param name="lhs">
        /// The lhs.
        /// </param>
        /// <param name="rhs">
        /// The rhs.
        /// </param>
        /// <returns>
        /// </returns>
        public static bool operator !=(Pop lhs, Pop rhs) => !(lhs == rhs);
    }
}
