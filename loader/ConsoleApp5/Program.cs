using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n [IMPORTANT] Please make sure to turn bcdedit on before accusing it of not working");
            Console.WriteLine("\n [LOADING] Finding Drv.sys");
            if (File.Exists(Directory.GetCurrentDirectory() + "\\Drv.sys"))
            {
                Console.WriteLine(" [LOADED] Found Drv.sys!");
                Console.WriteLine(" [LOADING] Loading Drv.sys...");
                Process.Start("Cmd.exe", "/c sc create GGKernelLoader binpath" + Directory.GetCurrentDirectory() + "\\Drv.sys" + " type=kernel");
                Process.Start("Cmd.exe", "/c sc start GGKernelLoader");
                Console.WriteLine(" [LOADED] Loaded Drv.sys!");
            }
            else
            {
                Console.WriteLine(" [ERROR] Didnt find Drv.sys!");
            }

            Console.ReadLine();
        }
    }
}
