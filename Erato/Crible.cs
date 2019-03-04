/* Programme qui affiche une liste des nombres premiers plus petits ou égaux au maximum fourni.
 * 
 * Auteure : Véronique Giguère
 * Création : 25 février 2019
 */
using System;
using System.Collections.Generic;

namespace Prog2
{
    public static class Crible
    {
        /// <summary>
        /// Trouve la liste des nombres premiers plus petits ou égaux au max fourni.
        /// </summary>
        /// <param name="max">nombre maximum</param>
        /// <returns>liste des nombres premiers plus petits ou égaux à max</returns>
        public static List<int> Ératosthène(int max = 100)
        {
            List<int> nombresPremiers = new List<int>(); 

            for (int i = 2; i <= max; ++i)
            {
                if (EstPremier(i))
                {
                    nombresPremiers.Add(i);
                }
            }

            return nombresPremiers;
        }

        /// <summary>
        /// Renvoie si un nombre est premier. 
        /// (Réf. : "Introduction à la programmation avec C#", Michel Michaud.)
        /// </summary>
        /// <param name="nombre">le nombre à vérifier</param>
        /// <returns>vrai si le nombre est premier, false sinon</returns>
        public static bool EstPremier(int nombre)
        {
            bool premier = nombre % 2 != 0 || nombre == 2;

            for (int diviseur = 3; premier && diviseur <= nombre / diviseur; diviseur += 2)
            {
                if (nombre % diviseur == 0)
                {
                    premier = false;
                }
            }

            return premier;
        }
    }
}
