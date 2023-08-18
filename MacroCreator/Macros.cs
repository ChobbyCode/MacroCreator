using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using System.IO;

namespace MacroCreator
{
    internal class Macros
    {

        focuser focus = new focuser();
        ErrorHandler err = new ErrorHandler();

        public static void runFromMC(string MCLoc)
        {
            Console.WriteLine("Unimplemented Method Error.");
        }

        public static void runMacroText(string Macro, int Times)
        {
            for(int i = 0; i < Times; i++)
            {
                //For loop nesting >:(
                for(int l = 0; l < Macro.Length; l++)
                {
                    Console.WriteLine(Macro[l]);
                }
            }
        }

        public static void quickMacro(string Macro, int Times, string targetApplication)
        {
            if (focuser.tryfocusApplication(targetApplication))
            {

                InputSimulator isim = new InputSimulator();
                //Call the key escape to focus application
                //This will be in the app config file and is modifiable
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.ESCAPE);

                for (int i = 0; i < Times; i++)
                {
                    //For loop nesting >:(
                    for (int l = 0; l < Macro.Length; l++)
                    {
                        //Console.WriteLine(Macro[l]);

                        if (Macro[l].ToString() == "{")
                        {
                            if (Macro[l+1].ToString() == ":")
                            {
                                //Special Character
                                if (Macro[l + 2].ToString() == "e")
                                {
                                    //Enter
                                    //This has to use the old depricated stuff >:( I can't get it to work in isim
                                    SendKeys.SendWait("{Enter}");
                                    l = l + 2;
                                }
                                else if (Macro[l + 2].ToString() == "t")
                                {
                                    //Tab
                                    isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);
                                    l = l + 2;
                                }
                                else if (Macro[l + 2].ToString() == "s")
                                {
                                    isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.ESCAPE);
                                }
                            }
                            else
                            {
                                //Not Special Character
                                writeKey(Macro[l], isim);
                            }
                        }
                        else
                        {
                            //Not Special Character
                            writeKey(Macro[l], isim);
                        }
                    }
                }
            }
            else
            {
                ErrorHandler.ShowError("Failed to focus application");
            }
        }

        private static void writeKey(char Key, InputSimulator isim)
        {
            if(Key.ToString() == " "){
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.SPACE);
            }
            else if (Key.ToString() == "a")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_A);
            }
            else if (Key.ToString() == "b")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_B);
            }
            else if (Key.ToString() == "c")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_C);
            }
            else if (Key.ToString() == "d")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_D);
            }
            else if (Key.ToString() == "e")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_E);
            }
            else if (Key.ToString() == "f")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_F);
            }
            else if (Key.ToString() == "g")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_G);
            }
            else if (Key.ToString() == "h")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_H);
            }
            else if (Key.ToString() == "i")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_I);
            }
            else if (Key.ToString() == "j")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_J);
            }
            else if (Key.ToString() == "k")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_K);
            }
            else if (Key.ToString() == "l")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_L);
            }
            else if (Key.ToString() == "m")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_M);
            }
            else if (Key.ToString() == "n")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_N);
            }
            else if (Key.ToString() == "o")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_O);
            }
            else if (Key.ToString() == "p")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_P);
            }
            else if (Key.ToString() == "q")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_Q);
            }
            else if (Key.ToString() == "r")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_R);
            }
            else if (Key.ToString() == "s")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_S);
            }
            else if (Key.ToString() == "t")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_T);
            }
            else if (Key.ToString() == "u")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_U);
            }
            else if (Key.ToString() == "v")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_V);
            }
            else if (Key.ToString() == "w")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_W);
            }
            else if (Key.ToString() == "x")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_X);
            }
            else if (Key.ToString() == "y")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_Y);
            }
            else if (Key.ToString() == "z")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_Z);
            }


            // Capital Letters

            else if (Key.ToString() == "A")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_A);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "B")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_B);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "C")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_C);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "D")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_D);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "E")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_E);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "F")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_F);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "G")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_G);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "H")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_H);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "I")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_I);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "J")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_J);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "K")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_K);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "L")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_L);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "M")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_M);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "N")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_N);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "O")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_O);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "P")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_P);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "Q")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_Q);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "R")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_R);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "S")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_S);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "T")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_T);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "U")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_U);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "V")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_V);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "W")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_W);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "X")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_X);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "Y")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_Y);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }
            else if (Key.ToString() == "Z")
            {
                isim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_Z);
                isim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);
            }

            //Numbers

            else if (Key.ToString() == "1")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_1);
            }
            else if (Key.ToString() == "2")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_2);
            }
            else if (Key.ToString() == "3")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_3);
            }
            else if (Key.ToString() == "4")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_4);
            }
            else if (Key.ToString() == "5")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_5);
            }
            else if (Key.ToString() == "6")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_6);
            }
            else if (Key.ToString() == "7")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_7);
            }
            else if (Key.ToString() == "8")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_8);
            }
            else if (Key.ToString() == "9")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_9);
            }
            else if (Key.ToString() == "0")
            {
                isim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_0);
            }
        }
    }
}
