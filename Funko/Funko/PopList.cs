

namespace Funko
{
    using System.Collections.Generic;

    /// <summary>
    /// The pop list.
    /// </summary>
    public class PopList : List<Pop>
    {
        /// <summary>
        /// Gets or sets the delim.
        /// </summary>
        public static char Delim { get; set; }

        /// <summary>
        /// The get all.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <returns>
        /// The <see cref="PopList"/>.
        /// </returns>
        public static PopList GetAll(string fileName)
        {
            PopManager.Delimiter = Delim;
            return PopManager.GetPops(fileName);
        }

        /// <summary>
        /// The save all.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        public void SaveAll(string fileName)
        {
            PopManager.Delimiter = Delim;
            PopManager.SavePops(fileName, this);
        }
    }
}
