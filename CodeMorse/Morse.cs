using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Prog2.ConsolePlus;
using static System.Char;
using static Prog2.StringUtil;

namespace Prog2
{
    public static class Morse
    {
        /// <summary>
        /// Table de conversion d'un caractère vers son code morse.
        /// </summary>
        static readonly string[] AlphabetMorse = new string[128];

        /// <summary>
        /// Encode un caractère ASCII en code morse international.
        /// </summary>
        /// <param name="c">le caractère ASCII à encoder</param>
        /// <returns>le code morse associé ou null si le caractère n'e</returns>
        public static string Encoder(char c)
            => (ToUpper(c) < 0 || AlphabetMorse.Length < ToUpper(c) || 
                AlphabetMorse[ToUpper(c)] == null) ? null : AlphabetMorse[ToUpper(c)];

        /// <summary>
        /// Encode un caractère ASCII en code morse international.
        /// </summary>
        /// <param name="mot">le mot à encoder</param>
        /// <param name="erreur">les caractères non reconnus seront remplacés par ce code d'erreur</param>
        /// <param name="séparateur">les lettres seront remplacées par ce séparateur</param>
        /// <returns>le mot encodé en morse</returns>
        public static string Encoder(string mot, string erreur = "??", string séparateur = " ")
        {
            char[] caractères = mot.SansAccents().ToUpper().ToCharArray();

            string motEnMorse = "";

            for (int i = 0; i < caractères.Length; ++i)
            {
                if (Encoder(caractères[i]) == null)
                {
                    motEnMorse += erreur;
                }
                else
                {
                    motEnMorse += AlphabetMorse[caractères[i]];
                }

                if (caractères.Length > 1 && i < caractères.Length - 1)
                {
                    motEnMorse += séparateur;
                }
            }

            return motEnMorse;
        }

        /// <summary>
        /// Pour initialiser la table de conversion.
        /// </summary>
        static void InitialiserTableDeConversion()
        {
            AlphabetMorse['A'] = ".-";
            AlphabetMorse['B'] = "-...";
            AlphabetMorse['C'] = "-.-.";
            AlphabetMorse['D'] = "-..";
            AlphabetMorse['E'] = ".";
            AlphabetMorse['F'] = "..-.";
            AlphabetMorse['G'] = "--.";
            AlphabetMorse['H'] = "....";
            AlphabetMorse['I'] = "..";
            AlphabetMorse['J'] = ".---";
            AlphabetMorse['K'] = "-.-";
            AlphabetMorse['L'] = ".-..";
            AlphabetMorse['M'] = "--";
            AlphabetMorse['N'] = "-.";
            AlphabetMorse['O'] = "---";
            AlphabetMorse['P'] = ".--.";
            AlphabetMorse['Q'] = "--.-";
            AlphabetMorse['R'] = ".-.";
            AlphabetMorse['S'] = "...";
            AlphabetMorse['T'] = "-";
            AlphabetMorse['U'] = "..-";
            AlphabetMorse['V'] = "...-";
            AlphabetMorse['W'] = ".--";
            AlphabetMorse['X'] = "-..-";
            AlphabetMorse['Y'] = "-.--";
            AlphabetMorse['Z'] = "--..";
            AlphabetMorse['0'] = "-----";
            AlphabetMorse['1'] = ".----";
            AlphabetMorse['2'] = "..---";
            AlphabetMorse['3'] = "...--";
            AlphabetMorse['4'] = "....-";
            AlphabetMorse['5'] = ".....";
            AlphabetMorse['6'] = "-....";
            AlphabetMorse['7'] = "--...";
            AlphabetMorse['8'] = "---..";
            AlphabetMorse['9'] = "----.";
            AlphabetMorse['='] = "-...-";
            AlphabetMorse['+'] = ".-.-.";
            AlphabetMorse['!'] = "-.-.--";
            AlphabetMorse['?'] = "..--..";
            AlphabetMorse['.'] = ".-.-.-";
            AlphabetMorse['&'] = ".-...";
            AlphabetMorse[':'] = "---...";
            AlphabetMorse['-'] = "-....-";
            AlphabetMorse['\u0027'] = ".----.";
            AlphabetMorse[','] = "--..--";
            AlphabetMorse['@'] = ".--.-.";
            AlphabetMorse['/'] = "-..-.";
            AlphabetMorse['('] = "-.--.";
            AlphabetMorse[')'] = "-.--.-";
            AlphabetMorse['\u005C'] = "";
            AlphabetMorse['_'] = "..--.-";
            AlphabetMorse['"'] = ".-..-.";
            AlphabetMorse[';'] = "-.-.-.";
        }

        /// <summary>
        /// Pour initialiser la table de conversion.
        /// </summary>
        static Morse()
        {
            InitialiserTableDeConversion();
        }

    }
}
