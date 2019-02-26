using System;
using static System.Console;
using static System.ConsoleColor;
using static Prog2.ConsolePlus;
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
            if (!int.TryParse(args[0], out int entier))
            {
                ColorWriteLine(Red, "{0} doit être un nombre entier", args[0]);
                return;
            }
            
            List<int> nombresEntiers = Crible.Ératosthène(entier);
           
            ColorWriteLine(Cyan, "Nombres premiers <= {0}", entier);

            for (int i = 0; i < nombresEntiers.Count; ++i)
            {
                if (i % 2 == 0)
                {
                    ColorWrite(Yellow, "{0} ", nombresEntiers[i]);
                }
                else
                {
                    ColorWrite(Magenta, "{0} ", nombresEntiers[i]);
                }
            }
        }
    }
}
