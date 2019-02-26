using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (EstPremier(i) || i == 2)
                {
                    nombresPremiers.Add(i);
                }
            }

            return nombresPremiers;
        }

        /// <summary>
        /// Renvoie si un nombre est premier.
        /// </summary>
        /// <param name="nombre">le nombre à vérifier</param>
        /// <returns></returns>
        public static bool EstPremier(int nombre)
        {
            bool premier = nombre % 2 != 0;

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
