using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment2
{
    class Compare_Files
    {
        public static void fileComparison(string firstFile, string secondFile)
        {
            if (firstFile == secondFile)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("These files are the same.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("These files are not the same.");
            }
        }
    }
}
