using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog2.ConsolePlus;
using static System.Console;
using static System.ConsoleColor;
using static System.String;

namespace Prog2
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Convertisseur en code morse";

            if (args.Length == 0)
            {
                ColorWriteLine(Yellow, "USAGE : CodeMorse mot1 mot2 etc.");
                return;
            }

            foreach (string arg in args)
            {
                ColorWrite(Yellow, "{0}\t", arg);
                ColorWriteLine(Magenta, "{0}", Morse.Encoder(arg));
            }
        }
    }
}
