using System;
using static System.Char;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2
{
    public static class Convertisseur
    {
        // --- Tables de conversion ---

        /// <summary>
        /// Table de conversion pour note anglais vers note français.
        /// </summary>
        static readonly string[] NotesFr = new string[128];

        // --- Méthodes ---

        public static string Convertir(char noteEn)
        {
            if (NotesFr.Contains(n => n == noteEn))
            {
                return NotesFr[noteEn];
            }
            else
                return null;
        }

        /// <summary>
        /// Constructeur statique. Appelé automatiquement au démarrage du programme.
        /// </summary>
        static Convertisseur()
        {
            InitialiserTableDeConversion();
        }

        /// <summary>
        /// Pour initialiser la table de conversion.
        /// </summary>
        static void InitialiserTableDeConversion()
        {
            NotesFr['A'] = "la";
            NotesFr['B'] = "si";
            NotesFr['C'] = "do";
            NotesFr['D'] = "ré";
            NotesFr['E'] = "mi";
            NotesFr['F'] = "fa";
            NotesFr['G'] = "sol";
        }
    }
}
