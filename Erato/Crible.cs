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

            int[] nombres = new int[max + 1];

            int compte = 2; 

            for (int i = 2; i <= max; ++i)
            {
                nombres[i] = compte;
                ++compte;
            }

            for (int i = 2; (i * i) <= max; ++i)
            {
                for (int j = i * i; j <= max; j = j + i)
                {
                    nombres[j] = 0;
                }
            }

            for (int i = 2; i <= max; ++i)
            {
                if (nombres[i] != 0)
                {
                    nombresPremiers.Add(nombres[i]);
                }
            }

            return nombresPremiers;
        }
    }
}
