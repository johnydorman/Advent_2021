using System;
using System.IO;

namespace AdventOfCode.Utils
{
    class FileReader
    {
        public static string[] InputAsArray(string input)
        {
            return File.ReadAllLines(@"C:\Users\johnd\source\repos\AdventOfCode\AdventOfCode\rss\" + input);
        }
    }
}
