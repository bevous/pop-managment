using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funko
{
    using System.Runtime.CompilerServices;

    public class PopList : List<Pop>
    {
        public static char Delim { get; set; }
        

        public static PopList GetAll(string fileName)
        {
            PopManager.Delimiter = Delim;
            return PopManager.GetPops(fileName);
        }

        public void SaveAll(string fileName)
        {
            PopManager.Delimiter = Delim;
            PopManager.SavePops(fileName, this);
        }
    }
}
