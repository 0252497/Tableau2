using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Prog2
{
    [TestClass]
    public class TesterConvertisseur
    {
        [TestMethod]
        public void _01_Convertir()
        {
            AreEqual("la", Convertisseur.Convertir('A'));
            AreEqual("sol", Convertisseur.Convertir('G'));
            IsNull(Convertisseur.Convertir('g'));
            IsNull(Convertisseur.Convertir('H'));
            IsNull(Convertisseur.Convertir((char)255));
            IsNull(Convertisseur.Convertir(char.MaxValue));
        }
    }
}
