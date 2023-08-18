using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using System.Diagnostics;
using System.Runtime.InteropServices;
//Old
//using System.Windows.Forms;
using System.Threading;
using WindowsInput;

namespace MacroCreator
{
    internal class focuser
    {

        //This class focuses the items

        public static bool tryfocusApplication(String applicationName)
        {
            Console.WriteLine("Loading...");
            Console.WriteLine("Adding Initialising Dependencies & Files To Focuser");
            //Imports the libraries
            Console.WriteLine("Initialising Libraries, {user32.dll}");
            [DllImport("user32.dll")]
            static extern int SetForegroundWindow(IntPtr point);

            //Find the process names
            Process[] ps = Process.GetProcessesByName(applicationName);
            Console.WriteLine(ps.Length);
            foreach (var p in ps)
            {
                Console.WriteLine(p);
            }
            //Gets thingy
            Process process = ps.FirstOrDefault();
            Console.WriteLine(process);

            if (process != null)
            {
                //Focuses the window
                Console.WriteLine("Focusing Windows Proccess...");
                IntPtr h = process.MainWindowHandle;
                SetForegroundWindow(h);

                return true;
            }
            else
            {
                //Returns false if application is not active
                return false;
            }
        }
    }
}
