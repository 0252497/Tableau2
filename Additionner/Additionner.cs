/* Programme qui permet d'additionner deux nombres.
 * 
 * Auteure : Véronique Giguère
 * Création : 24 février 2019
 */
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
            Title = "Additionner";

            if (args.Length != 2)
            {
                ColorWriteLine(DarkYellow, "USAGE : Additionner nombre1 nombre2");
                return;
            }

            if (!double.TryParse(args[0], out double nombre1))
            {
                ColorWriteLine(Red, "Nombre invalide : {0}", args[0]);
                return;
            }

            if (!double.TryParse(args[1], out double nombre2))
            {
                ColorWriteLine(Red, "Nombre invalide : {0}", args[1]);
                return;
            }

            var total = nombre1 + nombre2;

            ColorWriteLine(Green, "{0} + {1} = {2}", nombre1, nombre2, total);
        }
    }
}
