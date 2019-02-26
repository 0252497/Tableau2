using System;
using static System.Console;
using static Prog2.ConsolePlus;
using static System.ConsoleColor;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "EchoArgs";
            ColorWriteLine(Green, "Nombre d'arguments reçus : {0}", args.Length);

            foreach(var arg in args)
            {
                ColorWriteLine(Yellow, " * {0}", arg);
            }
        }
    }
}
