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

            foreach (int nombre in nombresEntiers)
            {
                ColorWrite(Magenta, "{0} ", nombre);
            }
        }
    }
}
