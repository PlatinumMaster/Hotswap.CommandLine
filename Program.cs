using System;
using Hotswap;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Write better Command Line Interface
            if (args.Length == 2)
            {
                string BaseROMPath = args[0];
                string ProjectConfigPath = args[1];
                try
                {
                    new Patcher(BaseROMPath, ProjectConfigPath);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}