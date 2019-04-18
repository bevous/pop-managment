using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funko
{
    class Pop
    {
        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        public int Number
        {
            get => this.Number;

            set => this.Number = value > 0 ? value : 0;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type
        {
            get => this.Type;
            set => this.Type = value ?? "N/A";
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get => this.Name;
            set => this.Name = value ?? "N/A";
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
            get => this.Size;
            set => this.Size = (value == 3 || value == 6 || value == 10) ? value : 3;
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
    }
}
