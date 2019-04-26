using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funko
{
    using System.IO;

    /// <summary>
    /// The pop manager.
    /// </summary>
    class PopManager
    {
        /// <summary>
        /// Gets or sets the delimiter.
        /// </summary>
        public static char Delimiter { get; set; }

        /// <summary>
        /// The try parse.
        /// </summary>
        /// <param name="line">
        /// The line.
        /// </param>
        /// <param name="pop">
        /// The pop.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool TryParse(string line, out Pop pop)
        {
            if (line is null)
            {
                pop = new Pop { Name = string.Empty, Number = int.MinValue, Exclusive = false, Size = int.MinValue, Type = string.Empty };
                return false;
            }
            else
            {
                var tokens = line.Split(Delimiter);
                pop = new Pop { Name = tokens[0], Number = int.Parse(tokens[1]), Exclusive = bool.Parse(tokens[2]), Size = int.Parse(tokens[3]), Type = tokens[4] };
                return true;
            }
        }

        /// <summary>
        /// The get pops.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <returns>
        /// The <see cref="PopList"/>.
        /// </returns>
        public static PopList GetPops(string fileName)
        {
            var list = new PopList();
            using (var reader = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    TryParse(line, out var pop);
                    list.Add(pop);
                }
            }

            return list;
        }

        /// <summary>
        /// The save pops.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <param name="list">
        /// The list.
        /// </param>
        public static void SavePops(string fileName, PopList list)
        {
            using (var writer = new StreamWriter(
                new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write)))
            {
                foreach (var pop in list)
                {
                    writer.WriteLine(ToFileString(pop));
                }
            }
        }

        /// <summary>
        /// The to file string.
        /// </summary>
        /// <param name="pop">
        /// The pop.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string ToFileString(Pop pop) =>
            $"{pop.Name}{Delimiter}{pop.Number}{Delimiter}{pop.Exclusive}{Delimiter}{pop.Size}{Delimiter}{pop.Type}";
    }
}
