using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    internal static class Filenames
    {
        private static int number;
        public static string NewName
            { get => $"..\\..\\..\\files\\file{++number}.txt"; }
    }
    
}
