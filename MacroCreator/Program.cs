using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
//Old
//using System.Windows.Forms;
using System.Threading;
using System.Web;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using WindowsInput;
using static System.Formats.Asn1.AsnWriter;

namespace MacroCreator
{
    class Program
    {
        //Adds other classes functions

        focuser focus = new focuser(); // The class that allows you to focus on certain applications
        Macros macro = new Macros(); // The class that allows you to do the macro stuff

        static void Main(string[] args)
        {
            int page = 1;
            bool run = true;

            Console.WriteLine("Reading File Data... This may take a few moments...");

            String fileEnd = @"saves\locations.tmp";
            String filePath = AppDomain.CurrentDomain.BaseDirectory + fileEnd;
            Console.WriteLine(filePath);

            string[] fileLocations = File.ReadAllLines(filePath, Encoding.UTF8);

            Console.WriteLine();
            Console.WriteLine("Completed!");
            Console.WriteLine();

            while (run)
            {
                displayPage(page);

                page = CheckNewPage(page, Console.ReadLine());
            }
        }

        private static void displayPage(int page)
        {
            switch (page)
            {
                case 1:

                    //Main Menu
                    Console.WriteLine("MacroCreator DEBUG 1.0.0 17/08/23");
                    Console.WriteLine();
                    Console.WriteLine("---Macros---");
                    Console.WriteLine();
                    Console.WriteLine("(1) - Quick Macro");
                    Console.WriteLine("(2) - Run a .mc File");
                    Console.WriteLine("(3) - Create a .mc File");
                    Console.WriteLine("(4) - Supported Application Settings & Supported Application Presets(.mc) ");

                    Console.WriteLine();
                    Console.WriteLine("---Settings & Other---");
                    Console.WriteLine();

                    Console.WriteLine("(5) - Settings");
                    Console.WriteLine("(6) - Changelog");
                    Console.WriteLine("(x) - Exit");

                    break;

                case 2:

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Since version 0.2.1, special characters have been replaced with {:e & {:t instead of {Enter} & {Tab}");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.Write("Macro Code (e.g. Hamburger {:e): ");

                    string macro = Console.ReadLine();

                    Console.Write("Repeat Macro Times: ");

                    int times = Convert.ToInt16(Console.ReadLine());

                    Console.Write("Target Application (e.g. javaw = (Minecraft), notepad = (notepad):");

                    string target = Console.ReadLine();

                    Macros.quickMacro(macro, times, target);

                    break;

                case 4:

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Since version 0.2.1, special characters have been replaced with {:e & {:t instead of {Enter} & {Tab}");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.WriteLine("New Special Characters: {:e = Enter, {:t = Tab");
                    Console.WriteLine();
                    Console.Write("Enter the preset name: ");

                    string mcPresetName = Console.ReadLine();

                    Console.Write("Escape Character (Leave blank for Default): ");

                    string escapeCharacter = Console.ReadLine();

                    if(escapeCharacter == "")
                    {
                        escapeCharacter = "Default";
                    }

                    Console.Write("Starting Macro (This is only called once): ");

                    string startingMacro = Console.ReadLine();

                    Console.Write("Macro Delay: ");

                    int macroDelay = Convert.ToInt16(Console.ReadLine());

                    Console.Write("Macro Randomness (0 Least - 10 Most): ");

                    int macroRandomness = Convert.ToInt16(Console.ReadLine());




                    break;


                case 5:

                    

                    break;

                case 7:

                    //Changelog
                    Console.WriteLine("");
                    Console.WriteLine("Version 1.0.0");
                    Console.WriteLine("");
                    Console.WriteLine("-Reprogrammed the app from ground upwards.");
                    Console.WriteLine("-New InputSimulatorPlus support");
                    Console.WriteLine("-.mc files");
                    Console.WriteLine("-Depricated System.Windows.Forms (mostly)");
                    Console.WriteLine("-New layout");
                    Console.WriteLine("-New pages manager (backend)");
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to return...");

                    break;

                case 8:
                    Console.Write("Preset Name (Make it related): ");

                    string presetName = Console.ReadLine();

                    Console.Write("Program name (i.e. javaw, notepad): ");

                    string programName = Console.ReadLine();

                    Console.Write("Escape Character (Leave blank for default): ");

                    string escapeChar = Console.ReadLine();
                    if (escapeChar == "")
                    {
                        escapeChar = "Default";
                    }

                    Console.WriteLine("Creating files");

                    String fileEnd = @"applications\" + presetName + ".ap";
                    String filePath = AppDomain.CurrentDomain.BaseDirectory + fileEnd;

                    using (FileStream fs = File.Create(filePath)) ;

                    string[] contents = new string[] {
                    "#-------------- " + presetName + " MacroCreator Config File--------------",
                    "",
                    "//The name of the application, get it through Task Manager > Details",
                    "Application Name = " + programName,
                    "",
                    "",
                    "//Valid Responses | Default/Null/Valid Unicode Characters",
                    "Escape Character = " + escapeChar
                    };

                    File.WriteAllLines(filePath, contents);

                    Console.WriteLine("File Created...");

                    break;
            }
        }

        private static int CheckNewPage(int CurrentPage, string input)
        {
            if (CurrentPage == 1)
            {
                //Main Page Logic
                if (input.ToLower() == "1")
                {
                    //Change page to Quick Macro Page
                    return 2;
                }
                else if (input.ToLower() == "2")
                {
                    //Change page to Run .mc file
                    return 3;
                }
                else if (input.ToLower() == "3")
                {
                    //Create a .mc File
                    return 4;
                }
                else if (input.ToLower() == "4")
                {
                    //Change page to Supported Application Settings & Supported Application Presets(.mc)
                    return 5;
                }
                else if (input.ToLower() == "5")
                {
                    //Change page to settings
                    return 6;
                }
                else if (input.ToLower() == "6")
                {
                    //Change page to credits
                    return 7;
                }
                else
                {
                    return 1;
                }

            }
            else if (CurrentPage == 2)
            {




                return 1;
            }
            else if (CurrentPage == 7)
            {
                return 1;
            }
            else
            {
                return 1;
            }
        }
    }
}