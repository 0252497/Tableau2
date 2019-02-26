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

            var total = 0.0;
            var ligne = "";

            for (int i = 0; i < args.Length; ++i)
            {
                if (!double.TryParse(args[i], out double nombre))
                {
                    ConsolePlus.ColorWriteLine(ConsoleColor.Red, "Nombre invalide: {0}", args[i]);
                    return;
                }

                if (i == 0)
                {
                    ligne += args[i];
                }
                else
                {
                    ligne += " + " + args[i];
                }

                total += nombre;
            }
        }
    }
}