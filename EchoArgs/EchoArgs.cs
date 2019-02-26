/* Programme qui affiche la quantité d'arguments reçus et leur valeur.
 * 
 * Auteure : Véronique Giguère
 * Création : 25 février 2019
 */
using System;
using static System.Console;
using static Prog2.ConsolePlus;
using static System.ConsoleColor;

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
