using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroCreator
{
    internal class ErrorHandler
    {

        public static void ShowError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: " + error);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
