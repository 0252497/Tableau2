using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Prog2
{
    [TestClass]
    public class TesterMorse
    {
        [TestMethod]
        public void _01_EncoderCaractère()
        {
            AreEqual(".-", Morse.Encoder('a'));
            AreEqual(".-", Morse.Encoder('A'));
            AreEqual(".----", Morse.Encoder('1'));
            AreEqual(".-.-.-", Morse.Encoder('.'));
            IsNull(Morse.Encoder(' '));
            IsNull(Morse.Encoder(char.MaxValue));
        }

        static void Tester(string attendu, string lettres)
        {
            var attendus = attendu.Split(' ');
            var reçus = Morse.Encoder(lettres).Split(' ');
            AreEqual(lettres.Length, attendus.Length);
            AreEqual(attendus.Length, reçus.Length);
            for(int i= 0; i < lettres.Length; i++)
            {
                AreEqual(attendus[i], reçus[i], $"caractère '{lettres[i]}'");
            }
        }

        [TestMethod]
        public void _02_EncoderMot()
        {
            AreEqual("", Morse.Encoder("")); 
            AreEqual(".-", Morse.Encoder("a")); 
            AreEqual(".- .-", Morse.Encoder("aa")); 
            AreEqual(".-", Morse.Encoder("à")); 
            AreEqual(".- ?? .-", Morse.Encoder("a a")); 
            AreEqual(".-|*|.-", Morse.Encoder("a a", "*", "|"));
            AreEqual("-...  ---  -.  .---  ---  ..-  .-.", Morse.Encoder("bonjour", séparateur:"  "));
            AreEqual(".-  ..-  .---  ---  ..-  .-.  -..  .----.  ....  ..-  ..", Morse.Encoder("aujourd'hui", séparateur: "  "));
            AreEqual(".-  --.  .  -.  -  -----  -----  --...", Morse.Encoder("agent007", séparateur: "  "));
        }

        [TestMethod]
        public void _03_EncoderExhaustif()
        {
            // Lettres
            Tester(".- -... -.-. -.. . ..-. --. .... .. .--- -.- .-.. -- -. --- .--. --.- .-. ... - ..- ...- .-- -..- -.-- --..",
                "abcdefghijklmnopqrstuvwxyz");
            // Chiffres
            Tester("----- .---- ..--- ...-- ....- ..... -.... --... ---.. ----.",
                "0123456789");
            // Symboles
            Tester(".-.-.- --..-- ..--.. .----. -..-. -.--. -.--.- .-... ---... -.-.-. -...- .-.-. -....- ..--.- .-..-. .--.-.",
                ".,?'/()&:;=+-_\"@");
        }

    }
}
