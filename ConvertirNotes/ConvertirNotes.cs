/* Programme qui convertit une note de musique anglaise vers sa note correspondante en français.
 * 
 * Auteure : Véronique Giguère
 * Création : 25 février 2019
 */
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
            Title = "Convertisseur de notes";

            if (args.Length == 0)
            {
                ColorWriteLine(Yellow, "USAGE : ConvertirNotes note 1 note 2 etc.");
                return;
            }

            foreach (string arg in args)
            {
                ColorWrite(Red, "{0}\t", arg);
            }

            WriteLine("");

            foreach (string arg in args)
            {
                char note = char.Parse(arg);

                if (Convertisseur.Convertir(note) != null)
                {
                    ColorWrite(Magenta, "{0}\t", Convertisseur.Convertir(note));
                }
                else
                {
                    ColorWrite(Magenta, "?\t");
                }
            }
        }
    }
}
