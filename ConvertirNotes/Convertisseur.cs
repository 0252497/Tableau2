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

        /// <summary>
        /// Renvoie la note en français correspondante à la note anglaise.
        /// </summary>
        /// <param name="noteEn">la note anglaise</param>
        /// <returns>la note en français si elle existe, null sinon</returns>
        public static string Convertir(char noteEn) 
            => (noteEn < 0 || NotesFr.Length < noteEn || NotesFr[noteEn] == null) ? null : NotesFr[noteEn];

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
