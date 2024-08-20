using System;
using Microsoft.Win32; // registry related

namespace FlexHEXRecentFilesCleanup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you sure you want to clear all of the recent files?");
            var keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Y)
            {
                Console.WriteLine(""); // add a blank line to stop the text appearing next to the "Y"
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Inv Softworks\\FlexHEX", true))
                {
                    if (key != null)
                    {
                        key.DeleteSubKeyTree("Recent File List");
                        Console.WriteLine("FlexHEX Recent Files was cleared sucessfully.");
                    }
                    else
                    {
                        Console.WriteLine("The tool was not be able to clear all of the recent files. Maybe it's because you've already cleaned it up or you haven't got FlexHEX installed on your computer.");
                    }
                }
                Console.ReadLine();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
